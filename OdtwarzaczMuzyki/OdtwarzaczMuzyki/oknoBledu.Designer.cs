namespace OdtwarzaczMuzyki
{
    partial class oknoBledu
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
            this.bladGroupBox = new System.Windows.Forms.GroupBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.bladLabel = new System.Windows.Forms.Label();
            this.bladGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bladGroupBox
            // 
            this.bladGroupBox.Controls.Add(this.bladLabel);
            this.bladGroupBox.Controls.Add(this.OKbutton);
            this.bladGroupBox.Location = new System.Drawing.Point(0, -10);
            this.bladGroupBox.Name = "bladGroupBox";
            this.bladGroupBox.Size = new System.Drawing.Size(243, 128);
            this.bladGroupBox.TabIndex = 0;
            this.bladGroupBox.TabStop = false;
            // 
            // OKbutton
            // 
            this.OKbutton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.OKbutton.Location = new System.Drawing.Point(82, 91);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 26);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "ok";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click_1);
            // 
            // bladLabel
            // 
            this.bladLabel.AutoSize = true;
            this.bladLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bladLabel.Location = new System.Drawing.Point(26, 49);
            this.bladLabel.Name = "bladLabel";
            this.bladLabel.Size = new System.Drawing.Size(0, 22);
            this.bladLabel.TabIndex = 0;
            this.bladLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bladLabel.UseCompatibleTextRendering = true;
            // 
            // oknoBledu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(244, 119);
            this.Controls.Add(this.bladGroupBox);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(244, 119);
            this.MinimumSize = new System.Drawing.Size(244, 119);
            this.Name = "oknoBledu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "okienkoBledu";
            this.bladGroupBox.ResumeLayout(false);
            this.bladGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bladGroupBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label bladLabel;
    }
}