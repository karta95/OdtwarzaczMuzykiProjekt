namespace OdtwarzaczMuzyki
{
    partial class oknoDodaniaPlaylisty
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
            this.dodajPlaylisteButton = new System.Windows.Forms.Button();
            this.anulujDodawanieButton = new System.Windows.Forms.Button();
            this.tytulOknaDodawania = new System.Windows.Forms.Label();
            this.nazwaPlaylistyLabel = new System.Windows.Forms.Label();
            this.nowaPlaylistaTextBox = new System.Windows.Forms.TextBox();
            this.dodawanieGroupBox = new System.Windows.Forms.GroupBox();
            this.dodawanieGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dodajPlaylisteButton
            // 
            this.dodajPlaylisteButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajPlaylisteButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dodajPlaylisteButton.Location = new System.Drawing.Point(127, 157);
            this.dodajPlaylisteButton.Name = "dodajPlaylisteButton";
            this.dodajPlaylisteButton.Size = new System.Drawing.Size(85, 28);
            this.dodajPlaylisteButton.TabIndex = 0;
            this.dodajPlaylisteButton.Text = "dodaj";
            this.dodajPlaylisteButton.UseVisualStyleBackColor = true;
            // 
            // anulujDodawanieButton
            // 
            this.anulujDodawanieButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anulujDodawanieButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anulujDodawanieButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.anulujDodawanieButton.Location = new System.Drawing.Point(218, 157);
            this.anulujDodawanieButton.Name = "anulujDodawanieButton";
            this.anulujDodawanieButton.Size = new System.Drawing.Size(85, 28);
            this.anulujDodawanieButton.TabIndex = 1;
            this.anulujDodawanieButton.Text = "anuluj";
            this.anulujDodawanieButton.UseVisualStyleBackColor = true;
            // 
            // tytulOknaDodawania
            // 
            this.tytulOknaDodawania.AutoSize = true;
            this.tytulOknaDodawania.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytulOknaDodawania.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tytulOknaDodawania.Location = new System.Drawing.Point(105, 24);
            this.tytulOknaDodawania.Name = "tytulOknaDodawania";
            this.tytulOknaDodawania.Size = new System.Drawing.Size(130, 21);
            this.tytulOknaDodawania.TabIndex = 2;
            this.tytulOknaDodawania.Text = "DODAJ PLAYLISTE";
            // 
            // nazwaPlaylistyLabel
            // 
            this.nazwaPlaylistyLabel.AutoSize = true;
            this.nazwaPlaylistyLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaPlaylistyLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nazwaPlaylistyLabel.Location = new System.Drawing.Point(12, 93);
            this.nazwaPlaylistyLabel.Name = "nazwaPlaylistyLabel";
            this.nazwaPlaylistyLabel.Size = new System.Drawing.Size(58, 21);
            this.nazwaPlaylistyLabel.TabIndex = 3;
            this.nazwaPlaylistyLabel.Text = "nazwa :";
            // 
            // nowaPlaylistaTextBox
            // 
            this.nowaPlaylistaTextBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowaPlaylistaTextBox.Location = new System.Drawing.Point(76, 85);
            this.nowaPlaylistaTextBox.Name = "nowaPlaylistaTextBox";
            this.nowaPlaylistaTextBox.Size = new System.Drawing.Size(227, 29);
            this.nowaPlaylistaTextBox.TabIndex = 4;
            // 
            // dodawanieGroupBox
            // 
            this.dodawanieGroupBox.Controls.Add(this.nowaPlaylistaTextBox);
            this.dodawanieGroupBox.Controls.Add(this.nazwaPlaylistyLabel);
            this.dodawanieGroupBox.Controls.Add(this.tytulOknaDodawania);
            this.dodawanieGroupBox.Controls.Add(this.anulujDodawanieButton);
            this.dodawanieGroupBox.Controls.Add(this.dodajPlaylisteButton);
            this.dodawanieGroupBox.Location = new System.Drawing.Point(0, -6);
            this.dodawanieGroupBox.Name = "dodawanieGroupBox";
            this.dodawanieGroupBox.Size = new System.Drawing.Size(337, 226);
            this.dodawanieGroupBox.TabIndex = 5;
            this.dodawanieGroupBox.TabStop = false;
            // 
            // oknoDodaniaPlaylisty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.anulujDodawanieButton;
            this.ClientSize = new System.Drawing.Size(339, 222);
            this.Controls.Add(this.dodawanieGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oknoDodaniaPlaylisty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "oknoDodaniaPlaylisty";
            this.dodawanieGroupBox.ResumeLayout(false);
            this.dodawanieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodajPlaylisteButton;
        private System.Windows.Forms.Button anulujDodawanieButton;
        private System.Windows.Forms.Label tytulOknaDodawania;
        private System.Windows.Forms.Label nazwaPlaylistyLabel;
        private System.Windows.Forms.TextBox nowaPlaylistaTextBox;
        private System.Windows.Forms.GroupBox dodawanieGroupBox;
    }
}