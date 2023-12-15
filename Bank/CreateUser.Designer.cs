namespace Bank
{
    partial class CreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameWindow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.TextBox();
            this.seriesText = new System.Windows.Forms.TextBox();
            this.postText = new System.Windows.Forms.ComboBox();
            this.isEmployee = new System.Windows.Forms.CheckBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.PatronymicText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.nameWindow);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 108);
            this.panel1.TabIndex = 0;
            // 
            // nameWindow
            // 
            this.nameWindow.AutoSize = true;
            this.nameWindow.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameWindow.ForeColor = System.Drawing.Color.White;
            this.nameWindow.Location = new System.Drawing.Point(150, 39);
            this.nameWindow.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameWindow.Name = "nameWindow";
            this.nameWindow.Size = new System.Drawing.Size(363, 35);
            this.nameWindow.TabIndex = 1;
            this.nameWindow.Text = "Создание пользователя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bank.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.idText);
            this.panel2.Controls.Add(this.numText);
            this.panel2.Controls.Add(this.seriesText);
            this.panel2.Controls.Add(this.postText);
            this.panel2.Controls.Add(this.isEmployee);
            this.panel2.Controls.Add(this.PasswordText);
            this.panel2.Controls.Add(this.loginText);
            this.panel2.Controls.Add(this.addressText);
            this.panel2.Controls.Add(this.phoneText);
            this.panel2.Controls.Add(this.PatronymicText);
            this.panel2.Controls.Add(this.nameText);
            this.panel2.Controls.Add(this.surnameText);
            this.panel2.Location = new System.Drawing.Point(57, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 642);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(238, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // idText
            // 
            this.idText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idText.AutoSize = true;
            this.idText.Location = new System.Drawing.Point(50, 27);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(73, 26);
            this.idText.TabIndex = 11;
            this.idText.Text = "label2";
            this.idText.Visible = false;
            // 
            // numText
            // 
            this.numText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numText.ForeColor = System.Drawing.Color.Silver;
            this.numText.Location = new System.Drawing.Point(303, 538);
            this.numText.MaxLength = 6;
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(341, 32);
            this.numText.TabIndex = 9;
            this.numText.Text = "Номер паспорта";
            this.numText.Enter += new System.EventHandler(this.surnameText_Enter);
            this.numText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneText_KeyPress);
            // 
            // seriesText
            // 
            this.seriesText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.seriesText.ForeColor = System.Drawing.Color.Silver;
            this.seriesText.Location = new System.Drawing.Point(55, 538);
            this.seriesText.MaxLength = 4;
            this.seriesText.Name = "seriesText";
            this.seriesText.Size = new System.Drawing.Size(210, 32);
            this.seriesText.TabIndex = 8;
            this.seriesText.Text = "Серия паспорта";
            this.seriesText.Enter += new System.EventHandler(this.surnameText_Enter);
            this.seriesText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneText_KeyPress);
            // 
            // postText
            // 
            this.postText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.postText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postText.FormattingEnabled = true;
            this.postText.Location = new System.Drawing.Point(55, 538);
            this.postText.Name = "postText";
            this.postText.Size = new System.Drawing.Size(589, 34);
            this.postText.TabIndex = 10;
            this.postText.Visible = false;
            this.postText.SelectedIndexChanged += new System.EventHandler(this.postText_SelectedIndexChanged);
            // 
            // isEmployee
            // 
            this.isEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.isEmployee.AutoSize = true;
            this.isEmployee.Location = new System.Drawing.Point(55, 492);
            this.isEmployee.Name = "isEmployee";
            this.isEmployee.Size = new System.Drawing.Size(184, 30);
            this.isEmployee.TabIndex = 7;
            this.isEmployee.Text = "Это сотрудник";
            this.isEmployee.UseVisualStyleBackColor = true;
            this.isEmployee.CheckedChanged += new System.EventHandler(this.isEmployee_CheckedChanged);
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordText.ForeColor = System.Drawing.Color.Silver;
            this.PasswordText.Location = new System.Drawing.Point(55, 443);
            this.PasswordText.MaxLength = 10;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(589, 32);
            this.PasswordText.TabIndex = 7;
            this.PasswordText.Text = "Пароль";
            this.PasswordText.Enter += new System.EventHandler(this.surnameText_Enter);
            // 
            // loginText
            // 
            this.loginText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginText.ForeColor = System.Drawing.Color.Silver;
            this.loginText.Location = new System.Drawing.Point(55, 379);
            this.loginText.MaxLength = 50;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(589, 32);
            this.loginText.TabIndex = 6;
            this.loginText.Text = "Логин";
            this.loginText.Enter += new System.EventHandler(this.surnameText_Enter);
            this.loginText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginText_KeyPress);
            // 
            // addressText
            // 
            this.addressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressText.ForeColor = System.Drawing.Color.Silver;
            this.addressText.Location = new System.Drawing.Point(55, 315);
            this.addressText.MaxLength = 60;
            this.addressText.Multiline = true;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(589, 32);
            this.addressText.TabIndex = 5;
            this.addressText.Text = "Адрес";
            this.addressText.Enter += new System.EventHandler(this.surnameText_Enter);
            this.addressText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressText_KeyPress);
            // 
            // phoneText
            // 
            this.phoneText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneText.ForeColor = System.Drawing.Color.Silver;
            this.phoneText.Location = new System.Drawing.Point(55, 251);
            this.phoneText.MaxLength = 11;
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(589, 32);
            this.phoneText.TabIndex = 4;
            this.phoneText.Text = "Номер телефона";
            this.phoneText.Enter += new System.EventHandler(this.surnameText_Enter);
            this.phoneText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneText_KeyPress);
            // 
            // PatronymicText
            // 
            this.PatronymicText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PatronymicText.ForeColor = System.Drawing.Color.Silver;
            this.PatronymicText.Location = new System.Drawing.Point(55, 190);
            this.PatronymicText.MaxLength = 20;
            this.PatronymicText.Name = "PatronymicText";
            this.PatronymicText.Size = new System.Drawing.Size(589, 32);
            this.PatronymicText.TabIndex = 3;
            this.PatronymicText.Text = "Отчество (при наличии)";
            this.PatronymicText.Enter += new System.EventHandler(this.surnameText_Enter);
            this.PatronymicText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameText_KeyPress);
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.ForeColor = System.Drawing.Color.Silver;
            this.nameText.Location = new System.Drawing.Point(55, 132);
            this.nameText.MaxLength = 20;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(589, 32);
            this.nameText.TabIndex = 2;
            this.nameText.Text = "Имя";
            this.nameText.Enter += new System.EventHandler(this.surnameText_Enter);
            this.nameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameText_KeyPress);
            // 
            // surnameText
            // 
            this.surnameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameText.ForeColor = System.Drawing.Color.Silver;
            this.surnameText.Location = new System.Drawing.Point(55, 71);
            this.surnameText.MaxLength = 20;
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(589, 32);
            this.surnameText.TabIndex = 1;
            this.surnameText.Text = "Фамилия";
            this.surnameText.Enter += new System.EventHandler(this.surnameText_Enter);
            this.surnameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameText_KeyPress);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateUser";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameWindow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox PatronymicText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.TextBox numText;
        private System.Windows.Forms.TextBox seriesText;
        private System.Windows.Forms.ComboBox postText;
        private System.Windows.Forms.CheckBox isEmployee;
    }
}