using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Authorization : Form
    {
        int loginAttempt = 0;
        int Id_user = 0;
        string table_user = "";
        bool captchaValid = false;
        int waitingTime = 180;

        public bool SetValid
        {
            set { captchaValid = value; }
        }
        public Authorization()
        {
            InitializeComponent();
            passwordText.Text = "Пароль";
            loginText.Text = "Логин";
            loginText.ForeColor = Color.Silver;
            passwordText.ForeColor = Color.Silver;
            passwordText.UseSystemPasswordChar = false;
        }

        private void this_close(object sender, EventArgs e)
        {
            Close();
        }

        private void loginText_Click(object sender, EventArgs e)
        {
            if (loginText.Text == "Логин")
            {
                loginText.Text = "";
                loginText.ForeColor = Color.Black;
            }
        }

        private void passwordText_Click(object sender, EventArgs e)
        {
            if (passwordText.Text == "Пароль")
            {
                passwordText.Text = "";
                passwordText.ForeColor = Color.Black;
                passwordText.UseSystemPasswordChar = true;
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked) { passwordText.UseSystemPasswordChar = false; }
            else passwordText.UseSystemPasswordChar = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string query = query = "insert into Login_history values ";
            loginAttempt++;
            if (loginAttempt == 2|| loginAttempt==3)
            {
                Catpcha f = new Catpcha(this);
                f.ShowDialog();
                if (!captchaValid)
                    return;
            }
            else if (loginAttempt == 4)
            {
                loginText.Enabled = false;
                passwordText.Enabled = false;
                btnLogin.Enabled = false;
                timer1.Start();
                timeText.Visible = true;
                await Task.Delay(180000);
            }
            else if (loginAttempt == 5)
            {
                MessageBox.Show("Система заблокирована. Для разблокировки перезапустите приложение",
                    "Слишком много попыток входа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }

            if (!MyDataBase.authorization(loginText.Text, passwordText.Text, out Id_user, out table_user))
            {
                MessageBox.Show("Логин или пароль введены неверно!", "Ошибка входа");
                query = query+$"(GETDATE(), '{loginText.Text}', 0)";
                MyDataBase.insert_data(query);
            }
            else
            {
                query = query + $"(GETDATE(), '{loginText.Text}', 1)";
                MyDataBase.insert_data(query);
                MainWindow mainWindow = new MainWindow(Id_user, table_user);
                Hide();
                mainWindow.FormClosed += new FormClosedEventHandler(this_close);
                mainWindow.Show();
            }        
        }

        private void loginText_TextChanged(object sender, EventArgs e)
        {
            loginText.ForeColor = Color.Black;
            if (loginText.Text.Length>0 && passwordText.Text.Length>0) 
                btnLogin.Enabled = true;
            else 
                btnLogin.Enabled = false;
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            passwordText.ForeColor = Color.Black;
            if(!showPassword.Checked)
                passwordText.UseSystemPasswordChar = true;
            if (loginText.Text.Length > 0 && passwordText.Text.Length > 0 )
                btnLogin.Enabled = true;
            else
                btnLogin.Enabled = false;
        }

        private void loginText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar!='_') 
                e.Handled = true;

        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            passwordText.Text = "Пароль";
            loginText.Text = "Логин";
            loginText.ForeColor = Color.Silver;
            passwordText.ForeColor = Color.Silver;
            passwordText.UseSystemPasswordChar = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (waitingTime > 0)
            {
                waitingTime--;
                int min = waitingTime / 60;
                int sec = waitingTime % 60;
                timeText.Text = "Время ожидания: " + min + ":" + sec;
            }
            else
            {
                timer1.Stop();
                timeText.Visible = false;
                loginText.Enabled = true;
                passwordText.Enabled = true;
                btnLogin.Enabled = true;
            }
        }
    }
}
