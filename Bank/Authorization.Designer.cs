namespace Bank
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.loginText = new System.Windows.Forms.TextBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginText
            // 
            this.loginText.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginText.ForeColor = System.Drawing.Color.Silver;
            this.loginText.Location = new System.Drawing.Point(70, 118);
            this.loginText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginText.MinimumSize = new System.Drawing.Size(304, 35);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(304, 36);
            this.loginText.TabIndex = 1;
            this.loginText.Tag = "";
            this.loginText.Text = "Логин";
            this.loginText.Click += new System.EventHandler(this.loginText_Click);
            this.loginText.TextChanged += new System.EventHandler(this.loginText_TextChanged);
            this.loginText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginText_KeyPress);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPassword.Location = new System.Drawing.Point(70, 224);
            this.showPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(152, 22);
            this.showPassword.TabIndex = 3;
            this.showPassword.Text = "Показать пароль";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(95, 276);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 74);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Вход";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordText.ForeColor = System.Drawing.Color.Silver;
            this.passwordText.Location = new System.Drawing.Point(70, 177);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordText.MinimumSize = new System.Drawing.Size(304, 35);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(304, 36);
            this.passwordText.TabIndex = 2;
            this.passwordText.Tag = "";
            this.passwordText.Text = "Пароль";
            this.passwordText.Click += new System.EventHandler(this.passwordText_Click);
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 51);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вход в систему";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.ForeColor = System.Drawing.Color.OrangeRed;
            this.timeText.Location = new System.Drawing.Point(192, 249);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(48, 18);
            this.timeText.TabIndex = 7;
            this.timeText.Text = "label1";
            this.timeText.Visible = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(434, 376);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.loginText);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeText;
    }
}

