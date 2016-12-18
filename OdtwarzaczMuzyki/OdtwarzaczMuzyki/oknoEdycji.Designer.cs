namespace OdtwarzaczMuzyki
{
    partial class oknoEdycji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoEdycji));
            this.edycjaGroupBox = new System.Windows.Forms.GroupBox();
            this.anulujEdycjebutton = new System.Windows.Forms.Button();
            this.zapiszZmianyButton = new System.Windows.Forms.Button();
            this.nowyEmailProfilu = new System.Windows.Forms.TextBox();
            this.nowaNazwaProfilu = new System.Windows.Forms.TextBox();
            this.nowyEmailLabel = new System.Windows.Forms.Label();
            this.nowaNazwaLabel = new System.Windows.Forms.Label();
            this.tytulOkna = new System.Windows.Forms.Label();
            this.edycjaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // edycjaGroupBox
            // 
            this.edycjaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edycjaGroupBox.Controls.Add(this.anulujEdycjebutton);
            this.edycjaGroupBox.Controls.Add(this.zapiszZmianyButton);
            this.edycjaGroupBox.Controls.Add(this.nowyEmailProfilu);
            this.edycjaGroupBox.Controls.Add(this.nowaNazwaProfilu);
            this.edycjaGroupBox.Controls.Add(this.nowyEmailLabel);
            this.edycjaGroupBox.Controls.Add(this.nowaNazwaLabel);
            this.edycjaGroupBox.Controls.Add(this.tytulOkna);
            this.edycjaGroupBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edycjaGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.edycjaGroupBox.Location = new System.Drawing.Point(24, 37);
            this.edycjaGroupBox.Name = "edycjaGroupBox";
            this.edycjaGroupBox.Size = new System.Drawing.Size(390, 286);
            this.edycjaGroupBox.TabIndex = 0;
            this.edycjaGroupBox.TabStop = false;
            // 
            // anulujEdycjebutton
            // 
            this.anulujEdycjebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anulujEdycjebutton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anulujEdycjebutton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.anulujEdycjebutton.Location = new System.Drawing.Point(286, 236);
            this.anulujEdycjebutton.Name = "anulujEdycjebutton";
            this.anulujEdycjebutton.Size = new System.Drawing.Size(72, 32);
            this.anulujEdycjebutton.TabIndex = 1;
            this.anulujEdycjebutton.Text = "Anuluj";
            this.anulujEdycjebutton.UseVisualStyleBackColor = true;
            // 
            // zapiszZmianyButton
            // 
            this.zapiszZmianyButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapiszZmianyButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.zapiszZmianyButton.Location = new System.Drawing.Point(182, 236);
            this.zapiszZmianyButton.Name = "zapiszZmianyButton";
            this.zapiszZmianyButton.Size = new System.Drawing.Size(98, 32);
            this.zapiszZmianyButton.TabIndex = 5;
            this.zapiszZmianyButton.Text = "Zapisz zmiany";
            this.zapiszZmianyButton.UseVisualStyleBackColor = true;
            // 
            // nowyEmailProfilu
            // 
            this.nowyEmailProfilu.Location = new System.Drawing.Point(99, 142);
            this.nowyEmailProfilu.Name = "nowyEmailProfilu";
            this.nowyEmailProfilu.Size = new System.Drawing.Size(259, 29);
            this.nowyEmailProfilu.TabIndex = 4;
            // 
            // nowaNazwaProfilu
            // 
            this.nowaNazwaProfilu.Location = new System.Drawing.Point(99, 76);
            this.nowaNazwaProfilu.Name = "nowaNazwaProfilu";
            this.nowaNazwaProfilu.Size = new System.Drawing.Size(259, 29);
            this.nowaNazwaProfilu.TabIndex = 3;
            // 
            // nowyEmailLabel
            // 
            this.nowyEmailLabel.AutoSize = true;
            this.nowyEmailLabel.Location = new System.Drawing.Point(23, 150);
            this.nowyEmailLabel.Name = "nowyEmailLabel";
            this.nowyEmailLabel.Size = new System.Drawing.Size(50, 21);
            this.nowyEmailLabel.TabIndex = 2;
            this.nowyEmailLabel.Text = "email :";
            // 
            // nowaNazwaLabel
            // 
            this.nowaNazwaLabel.AutoSize = true;
            this.nowaNazwaLabel.Location = new System.Drawing.Point(23, 84);
            this.nowaNazwaLabel.Name = "nowaNazwaLabel";
            this.nowaNazwaLabel.Size = new System.Drawing.Size(58, 21);
            this.nowaNazwaLabel.TabIndex = 1;
            this.nowaNazwaLabel.Text = "nazwa :";
            // 
            // tytulOkna
            // 
            this.tytulOkna.AutoSize = true;
            this.tytulOkna.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytulOkna.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tytulOkna.Location = new System.Drawing.Point(48, 0);
            this.tytulOkna.Name = "tytulOkna";
            this.tytulOkna.Size = new System.Drawing.Size(111, 21);
            this.tytulOkna.TabIndex = 0;
            this.tytulOkna.Text = "EDYTUJ PROFIL";
            // 
            // oknoEdycji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.anulujEdycjebutton;
            this.ClientSize = new System.Drawing.Size(442, 344);
            this.Controls.Add(this.edycjaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(442, 344);
            this.MinimumSize = new System.Drawing.Size(442, 344);
            this.Name = "oknoEdycji";
            this.Text = "oknoEdycji";
            this.edycjaGroupBox.ResumeLayout(false);
            this.edycjaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox edycjaGroupBox;
        private System.Windows.Forms.Label tytulOkna;
        private System.Windows.Forms.Label nowaNazwaLabel;
        private System.Windows.Forms.Label nowyEmailLabel;
        private System.Windows.Forms.TextBox nowyEmailProfilu;
        private System.Windows.Forms.TextBox nowaNazwaProfilu;
        private System.Windows.Forms.Button zapiszZmianyButton;
        private System.Windows.Forms.Button anulujEdycjebutton;
    }
}