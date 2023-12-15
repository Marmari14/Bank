namespace Bank
{
    partial class Catpcha
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
            this.pictureCapcha = new System.Windows.Forms.PictureBox();
            this.textCapcha = new System.Windows.Forms.TextBox();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCapcha
            // 
            this.pictureCapcha.Location = new System.Drawing.Point(12, 12);
            this.pictureCapcha.Name = "pictureCapcha";
            this.pictureCapcha.Size = new System.Drawing.Size(371, 207);
            this.pictureCapcha.TabIndex = 0;
            this.pictureCapcha.TabStop = false;
            // 
            // textCapcha
            // 
            this.textCapcha.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCapcha.Location = new System.Drawing.Point(13, 252);
            this.textCapcha.Name = "textCapcha";
            this.textCapcha.Size = new System.Drawing.Size(434, 32);
            this.textCapcha.TabIndex = 1;
            // 
            // btnRedraw
            // 
            this.btnRedraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.btnRedraw.BackgroundImage = global::Bank.Properties.Resources.redraw;
            this.btnRedraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRedraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.btnRedraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedraw.Location = new System.Drawing.Point(389, 85);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(58, 55);
            this.btnRedraw.TabIndex = 2;
            this.btnRedraw.UseVisualStyleBackColor = false;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Green;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(156, 304);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(144, 32);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Catpcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(459, 348);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.textCapcha);
            this.Controls.Add(this.pictureCapcha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Catpcha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Я не робот";
            this.Load += new System.EventHandler(this.Capcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCapcha;
        private System.Windows.Forms.TextBox textCapcha;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Button btnOK;
    }
}