using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class Auth : Form
    {
        private string connectionString = "Server=localhost;Database=shop;Trusted_Connection=True;";
        public string captchaText = String.Empty;
        private int loginAttempts = 0;
        private bool isBlocked = false;
        private DateTime blockStartTime;
        private bool isPermanentlyBlocked = false;

        public Auth()
        {
            InitializeComponent();
        }

        private int GetUserID(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserID FROM users WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result;
                    }
                }
            }
            return -1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isPermanentlyBlocked)
            {
                MessageBox.Show("Вы заблокированы навсегда.");
                return;
            }

            if (isBlocked)
            {
                TimeSpan timeSinceBlock = DateTime.Now - blockStartTime;
                if (timeSinceBlock.TotalMinutes < 3)
                {
                    MessageBox.Show("Попробуйте снова через " + (3 - timeSinceBlock.TotalMinutes) + " минут.");
                    return;
                }
                else
                {
                    isBlocked = false;
                    loginAttempts = 0;
                }
            }

            if (isPermanentlyBlocked)
            {
                MessageBox.Show("Вы заблокированы навсегда.");
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите имя пользователя и пароль.");
                return;
            }

            int userID = GetUserID(username);

            if (loginAttempts >= 1)
            {
                if (!ValidateCaptcha())
                {
                    MessageBox.Show("Неверная CAPTCHA.");
                    CaptchaLoad();
                    return;
                }
            }

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Авторизация успешна!");
                AddLoginHistory(userID, DateTime.Now, true);

                this.Hide();

                MainForm mainForm = new MainForm(userID);
                mainForm.Show();
            }
            else
            {
                loginAttempts++;

                if (loginAttempts >= 2)
                {
                    CaptchaLoad();
                    isBlocked = true;
                    blockStartTime = DateTime.Now;

                    // Проверка для перманентной блокировки
                    if (!isPermanentlyBlocked && loginAttempts >= 3)
                    {
                        isPermanentlyBlocked = true;
                        MessageBox.Show("Вы заблокированы навсегда.");
                    }
                    else
                    {
                        MessageBox.Show("Вы заблокированы на 3 минуты.");
                    }
                    AddLoginHistory(userID, DateTime.Now, false);
                }
                else
                {
                    Resize_Form();
                    CaptchaLoad();
                    MessageBox.Show("Неверное имя пользователя или пароль.");
                    AddLoginHistory(userID, DateTime.Now, false);
                }
            }
        }



        public bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool ValidateCaptcha()
        {
            return textBox1.Text == captchaText;
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            Graphics g = Graphics.FromImage((Image)result);

            g.Clear(Color.Gray);

            captchaText = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 4; ++i)
                captchaText += ALF[rnd.Next(ALF.Length)];

            g.DrawString(captchaText,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void pictureCaptcha_Click(object sender, EventArgs e)
        {
            CaptchaLoad();
        }

        public void CaptchaLoad()
        {
            pictureCaptcha.Image = this.CreateImage(pictureCaptcha.Width, pictureCaptcha.Height);
            pictureCaptcha.Visible = true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void AddLoginHistory(int userID, DateTime loginTime, bool loginSuccess)
        {
            if (userID == -1)
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO login_history (UserID, LoginTime, login_success) VALUES (@userID, @loginTime, @loginSuccess)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@loginTime", loginTime);
                    command.Parameters.AddWithValue("@loginSuccess", loginSuccess);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Resize_Form()
        {
            // Изменение размера формы
            this.Size = new Size(274, 274);
            textBox1.Visible = true;
            btnLogin.Location = new Point(15, 203);
        }
    }
}