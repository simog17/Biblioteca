namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.infoUserButton = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.infoBookButton = new System.Windows.Forms.Button();
            this.bookedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.usersListBox.Location = new System.Drawing.Point(12, 12);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(228, 277);
            this.usersListBox.TabIndex = 0;
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.Location = new System.Drawing.Point(329, 12);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(228, 277);
            this.booksListBox.TabIndex = 1;
            // 
            // infoUserButton
            // 
            this.infoUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUserButton.Location = new System.Drawing.Point(12, 313);
            this.infoUserButton.Name = "infoUserButton";
            this.infoUserButton.Size = new System.Drawing.Size(113, 52);
            this.infoUserButton.TabIndex = 2;
            this.infoUserButton.Text = "Info utente";
            this.infoUserButton.UseVisualStyleBackColor = true;
            this.infoUserButton.Click += new System.EventHandler(this.infoUserButton_Click);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(72, 394);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(433, 103);
            this.txt.TabIndex = 3;
            // 
            // infoBookButton
            // 
            this.infoBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBookButton.Location = new System.Drawing.Point(444, 313);
            this.infoBookButton.Name = "infoBookButton";
            this.infoBookButton.Size = new System.Drawing.Size(113, 52);
            this.infoBookButton.TabIndex = 4;
            this.infoBookButton.Text = "Info libro";
            this.infoBookButton.UseVisualStyleBackColor = true;
            this.infoBookButton.Click += new System.EventHandler(this.infoBookButton_Click);
            // 
            // bookedButton
            // 
            this.bookedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedButton.Location = new System.Drawing.Point(228, 315);
            this.bookedButton.Name = "bookedButton";
            this.bookedButton.Size = new System.Drawing.Size(113, 52);
            this.bookedButton.TabIndex = 5;
            this.bookedButton.Text = "Prestare";
            this.bookedButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 509);
            this.Controls.Add(this.bookedButton);
            this.Controls.Add(this.infoBookButton);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.infoUserButton);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.usersListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Button infoUserButton;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button infoBookButton;
        private System.Windows.Forms.Button bookedButton;
    }
}

