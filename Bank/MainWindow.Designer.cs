namespace Bank
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rowsCount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.tableName = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.changePhoto = new System.Windows.Forms.Button();
            this.UserPost = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.userPhoto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 763);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.panel4.Controls.Add(this.rowsCount);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnChange);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.searchText);
            this.panel4.Controls.Add(this.tableName);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.mainTable);
            this.panel4.Location = new System.Drawing.Point(254, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 663);
            this.panel4.TabIndex = 3;
            // 
            // rowsCount
            // 
            this.rowsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rowsCount.AutoSize = true;
            this.rowsCount.Location = new System.Drawing.Point(794, 177);
            this.rowsCount.Name = "rowsCount";
            this.rowsCount.Size = new System.Drawing.Size(62, 22);
            this.rowsCount.TabIndex = 9;
            this.rowsCount.Text = "label2";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(161, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Green;
            this.btnChange.Enabled = false;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(26, 153);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(113, 34);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Visible = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.button4.BackgroundImage = global::Bank.Properties.Resources.search;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(947, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 35);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchText.Location = new System.Drawing.Point(627, 24);
            this.searchText.MaxLength = 60;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(314, 35);
            this.searchText.TabIndex = 4;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            this.searchText.Enter += new System.EventHandler(this.searchText_Enter);
            this.searchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchText_KeyPress);
            this.searchText.Leave += new System.EventHandler(this.searchText_Leave);
            // 
            // tableName
            // 
            this.tableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableName.Location = new System.Drawing.Point(209, 89);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(546, 46);
            this.tableName.TabIndex = 3;
            this.tableName.Text = "Название главной таблицы";
            this.tableName.TextChanged += new System.EventHandler(this.tableName_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(192, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(20, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainTable
            // 
            this.mainTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.mainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.EnableHeadersVisualStyles = false;
            this.mainTable.Location = new System.Drawing.Point(29, 222);
            this.mainTable.Name = "mainTable";
            this.mainTable.ReadOnly = true;
            this.mainTable.RowHeadersVisible = false;
            this.mainTable.RowHeadersWidth = 51;
            this.mainTable.RowTemplate.Height = 24;
            this.mainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainTable.Size = new System.Drawing.Size(935, 421);
            this.mainTable.TabIndex = 0;
            this.mainTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainTable_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.changePhoto);
            this.panel3.Controls.Add(this.UserPost);
            this.panel3.Controls.Add(this.UserName);
            this.panel3.Controls.Add(this.userPhoto);
            this.panel3.Location = new System.Drawing.Point(12, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 664);
            this.panel3.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.btnExit.BackgroundImage = global::Bank.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(202)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(21, 576);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 68);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // changePhoto
            // 
            this.changePhoto.BackColor = System.Drawing.Color.Green;
            this.changePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePhoto.ForeColor = System.Drawing.Color.White;
            this.changePhoto.Location = new System.Drawing.Point(21, 223);
            this.changePhoto.Name = "changePhoto";
            this.changePhoto.Size = new System.Drawing.Size(171, 34);
            this.changePhoto.TabIndex = 3;
            this.changePhoto.Text = "Изменить фото";
            this.changePhoto.UseVisualStyleBackColor = false;
            this.changePhoto.Click += new System.EventHandler(this.changePhoto_Click);
            // 
            // UserPost
            // 
            this.UserPost.AutoSize = true;
            this.UserPost.Location = new System.Drawing.Point(3, 355);
            this.UserPost.Name = "UserPost";
            this.UserPost.Size = new System.Drawing.Size(51, 22);
            this.UserPost.TabIndex = 2;
            this.UserPost.Text = "Роль";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(3, 276);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(50, 22);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "ФИО";
            // 
            // userPhoto
            // 
            this.userPhoto.Location = new System.Drawing.Point(21, 34);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(171, 174);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 0;
            this.userPhoto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 80);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Банковские вклады";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(33, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 763);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(990, 680);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label UserPost;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.Label tableName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label rowsCount;
        private System.Windows.Forms.Button changePhoto;
        private System.Windows.Forms.PictureBox userPhoto;
    }
}