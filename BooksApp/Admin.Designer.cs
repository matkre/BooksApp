namespace BooksApp
{
    partial class AdminWindow
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pictureField = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.delTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.genText = new System.Windows.Forms.TextBox();
            this.authText = new System.Windows.Forms.TextBox();
            this.verText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.idLab = new System.Windows.Forms.Label();
            this.titLab = new System.Windows.Forms.Label();
            this.verLab = new System.Windows.Forms.Label();
            this.autLab = new System.Windows.Forms.Label();
            this.genLab = new System.Windows.Forms.Label();
            this.yeaLab = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.messageLab = new System.Windows.Forms.Label();
            this.fileButton = new System.Windows.Forms.Button();
            this.photoButton = new System.Windows.Forms.Button();
            this.fileLab = new System.Windows.Forms.Label();
            this.pictureLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureField)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(538, 370);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnClickCell);
            // 
            // pictureField
            // 
            this.pictureField.Location = new System.Drawing.Point(559, 50);
            this.pictureField.Name = "pictureField";
            this.pictureField.Size = new System.Drawing.Size(223, 281);
            this.pictureField.TabIndex = 2;
            this.pictureField.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(698, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(559, 353);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "DELETE";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(686, 427);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(86, 35);
            this.upButton.TabIndex = 5;
            this.upButton.Text = "UPDATE";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // delTextBox
            // 
            this.delTextBox.Location = new System.Drawing.Point(688, 355);
            this.delTextBox.Name = "delTextBox";
            this.delTextBox.Size = new System.Drawing.Size(51, 20);
            this.delTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(15, 443);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(40, 20);
            this.idText.TabIndex = 9;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(304, 490);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(100, 20);
            this.yearText.TabIndex = 10;
            // 
            // genText
            // 
            this.genText.Location = new System.Drawing.Point(198, 490);
            this.genText.Name = "genText";
            this.genText.Size = new System.Drawing.Size(100, 20);
            this.genText.TabIndex = 11;
            // 
            // authText
            // 
            this.authText.Location = new System.Drawing.Point(12, 490);
            this.authText.Name = "authText";
            this.authText.Size = new System.Drawing.Size(180, 20);
            this.authText.TabIndex = 12;
            // 
            // verText
            // 
            this.verText.Location = new System.Drawing.Point(245, 443);
            this.verText.Name = "verText";
            this.verText.Size = new System.Drawing.Size(159, 20);
            this.verText.TabIndex = 13;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(61, 443);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(178, 20);
            this.titleText.TabIndex = 14;
            // 
            // idLab
            // 
            this.idLab.AutoSize = true;
            this.idLab.Location = new System.Drawing.Point(28, 427);
            this.idLab.Name = "idLab";
            this.idLab.Size = new System.Drawing.Size(18, 13);
            this.idLab.TabIndex = 15;
            this.idLab.Text = "ID";
            // 
            // titLab
            // 
            this.titLab.AutoSize = true;
            this.titLab.Location = new System.Drawing.Point(127, 426);
            this.titLab.Name = "titLab";
            this.titLab.Size = new System.Drawing.Size(37, 13);
            this.titLab.TabIndex = 16;
            this.titLab.Text = "TITLE";
            // 
            // verLab
            // 
            this.verLab.AutoSize = true;
            this.verLab.Location = new System.Drawing.Point(283, 427);
            this.verLab.Name = "verLab";
            this.verLab.Size = new System.Drawing.Size(55, 13);
            this.verLab.TabIndex = 17;
            this.verLab.Text = "VERSION";
            // 
            // autLab
            // 
            this.autLab.AutoSize = true;
            this.autLab.Location = new System.Drawing.Point(70, 474);
            this.autLab.Name = "autLab";
            this.autLab.Size = new System.Drawing.Size(53, 13);
            this.autLab.TabIndex = 18;
            this.autLab.Text = "AUTHOR";
            // 
            // genLab
            // 
            this.genLab.AutoSize = true;
            this.genLab.Location = new System.Drawing.Point(226, 474);
            this.genLab.Name = "genLab";
            this.genLab.Size = new System.Drawing.Size(45, 13);
            this.genLab.TabIndex = 19;
            this.genLab.Text = "GENRE";
            // 
            // yeaLab
            // 
            this.yeaLab.AutoSize = true;
            this.yeaLab.Location = new System.Drawing.Point(337, 474);
            this.yeaLab.Name = "yeaLab";
            this.yeaLab.Size = new System.Drawing.Size(36, 13);
            this.yeaLab.TabIndex = 20;
            this.yeaLab.Text = "YEAR";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(688, 468);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 35);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // messageLab
            // 
            this.messageLab.AutoSize = true;
            this.messageLab.Location = new System.Drawing.Point(12, 539);
            this.messageLab.Name = "messageLab";
            this.messageLab.Size = new System.Drawing.Size(0, 13);
            this.messageLab.TabIndex = 22;
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(467, 426);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(86, 35);
            this.fileButton.TabIndex = 23;
            this.fileButton.Text = "File";
            this.fileButton.UseVisualStyleBackColor = true;
            // 
            // photoButton
            // 
            this.photoButton.Location = new System.Drawing.Point(467, 475);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(86, 35);
            this.photoButton.TabIndex = 24;
            this.photoButton.Text = "Picture";
            this.photoButton.UseVisualStyleBackColor = true;
            // 
            // fileLab
            // 
            this.fileLab.AutoSize = true;
            this.fileLab.Location = new System.Drawing.Point(559, 437);
            this.fileLab.Name = "fileLab";
            this.fileLab.Size = new System.Drawing.Size(10, 13);
            this.fileLab.TabIndex = 25;
            this.fileLab.Text = ":";
            // 
            // pictureLab
            // 
            this.pictureLab.AutoSize = true;
            this.pictureLab.Location = new System.Drawing.Point(559, 486);
            this.pictureLab.Name = "pictureLab";
            this.pictureLab.Size = new System.Drawing.Size(10, 13);
            this.pictureLab.TabIndex = 26;
            this.pictureLab.Text = ":";
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.pictureLab);
            this.Controls.Add(this.fileLab);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.messageLab);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.yeaLab);
            this.Controls.Add(this.genLab);
            this.Controls.Add(this.autLab);
            this.Controls.Add(this.verLab);
            this.Controls.Add(this.titLab);
            this.Controls.Add(this.idLab);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.verText);
            this.Controls.Add(this.authText);
            this.Controls.Add(this.genText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delTextBox);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.pictureField);
            this.Controls.Add(this.dataGridView);
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "E-Books";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureField;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.TextBox delTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox genText;
        private System.Windows.Forms.TextBox authText;
        private System.Windows.Forms.TextBox verText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label idLab;
        private System.Windows.Forms.Label titLab;
        private System.Windows.Forms.Label verLab;
        private System.Windows.Forms.Label autLab;
        private System.Windows.Forms.Label genLab;
        private System.Windows.Forms.Label yeaLab;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label messageLab;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.Label fileLab;
        private System.Windows.Forms.Label pictureLab;
    }
}