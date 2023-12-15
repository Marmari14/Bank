namespace Bank
{
    partial class CreateDeposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.shelfLifeText = new System.Windows.Forms.NumericUpDown();
            this.currencyText = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.betText = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfLifeText)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betText)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 83);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создать вклад";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bank.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 53);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameText.Location = new System.Drawing.Point(252, 69);
            this.nameText.MaxLength = 20;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(423, 32);
            this.nameText.TabIndex = 1;
            this.nameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameText_KeyPress);
            // 
            // shelfLifeText
            // 
            this.shelfLifeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shelfLifeText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shelfLifeText.Location = new System.Drawing.Point(252, 171);
            this.shelfLifeText.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.shelfLifeText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shelfLifeText.Name = "shelfLifeText";
            this.shelfLifeText.Size = new System.Drawing.Size(423, 32);
            this.shelfLifeText.TabIndex = 3;
            this.shelfLifeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shelfLifeText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // currencyText
            // 
            this.currencyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyText.FormattingEnabled = true;
            this.currencyText.Location = new System.Drawing.Point(252, 220);
            this.currencyText.Name = "currencyText";
            this.currencyText.Size = new System.Drawing.Size(423, 34);
            this.currencyText.TabIndex = 4;
            this.currencyText.SelectedIndexChanged += new System.EventHandler(this.currencyText_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(238, 274);
            this.btnSave.MaximumSize = new System.Drawing.Size(220, 51);
            this.btnSave.MinimumSize = new System.Drawing.Size(220, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 51);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ставка, %";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Срок хранения, мес";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Валюта хранения";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.betText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.currencyText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.shelfLifeText);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nameText);
            this.panel2.Location = new System.Drawing.Point(-3, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 360);
            this.panel2.TabIndex = 10;
            // 
            // betText
            // 
            this.betText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.betText.DecimalPlaces = 1;
            this.betText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betText.Location = new System.Drawing.Point(252, 124);
            this.betText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betText.Name = "betText";
            this.betText.Size = new System.Drawing.Size(421, 32);
            this.betText.TabIndex = 10;
            this.betText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.betText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.betText_KeyPress);
            // 
            // CreateDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(682, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 510);
            this.Name = "CreateDeposit";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfLifeText)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.NumericUpDown shelfLifeText;
        private System.Windows.Forms.ComboBox currencyText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown betText;
    }
}