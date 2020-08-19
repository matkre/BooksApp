namespace BooksApp
{
    partial class BooksApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksApp));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.messageViewField = new System.Windows.Forms.Label();
            this.downloadBook = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.LogAsAdmin = new System.Windows.Forms.Button();
            this.booksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1, 1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(640, 380);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnClickCell);
            // 
            // messageViewField
            // 
            this.messageViewField.AutoSize = true;
            this.messageViewField.Location = new System.Drawing.Point(12, 484);
            this.messageViewField.Name = "messageViewField";
            this.messageViewField.Size = new System.Drawing.Size(0, 13);
            this.messageViewField.TabIndex = 3;
            // 
            // downloadBook
            // 
            this.downloadBook.Location = new System.Drawing.Point(733, 387);
            this.downloadBook.Name = "downloadBook";
            this.downloadBook.Size = new System.Drawing.Size(131, 23);
            this.downloadBook.TabIndex = 5;
            this.downloadBook.Text = "Pobierz książkę";
            this.downloadBook.UseVisualStyleBackColor = true;
            this.downloadBook.Click += new System.EventHandler(this.downloadBook_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Menu;
            this.closeButton.Image = global::BooksApp.Properties.Resources.offBut;
            this.closeButton.Location = new System.Drawing.Point(949, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 27);
            this.closeButton.TabIndex = 6;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(647, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(296, 380);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // LogAsAdmin
            // 
            this.LogAsAdmin.Image = ((System.Drawing.Image)(resources.GetObject("LogAsAdmin.Image")));
            this.LogAsAdmin.Location = new System.Drawing.Point(931, 457);
            this.LogAsAdmin.Name = "LogAsAdmin";
            this.LogAsAdmin.Size = new System.Drawing.Size(41, 40);
            this.LogAsAdmin.TabIndex = 2;
            this.LogAsAdmin.UseVisualStyleBackColor = true;
            this.LogAsAdmin.Click += new System.EventHandler(this.LogAsAdmin_Click);
            // 
            // BooksApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.downloadBook);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.messageViewField);
            this.Controls.Add(this.LogAsAdmin);
            this.Controls.Add(this.dataGridView);
            this.Name = "BooksApp";
            this.Text = "E-Books";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource booksTableBindingSource;
        private System.Windows.Forms.Button LogAsAdmin;
        private System.Windows.Forms.Label messageViewField;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button downloadBook;
        private System.Windows.Forms.Button closeButton;
    }
}