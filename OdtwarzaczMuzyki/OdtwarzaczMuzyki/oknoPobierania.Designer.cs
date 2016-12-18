namespace OdtwarzaczMuzyki
{
    partial class oknoPobierania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoPobierania));
            this.pobieranieGroupBox = new System.Windows.Forms.GroupBox();
            this.anulujPobieranieButton = new System.Windows.Forms.Button();
            this.zapiszUtworButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sciezkaZapisuLabel = new System.Windows.Forms.Label();
            this.linkUrlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pobieranieGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pobieranieGroupBox
            // 
            resources.ApplyResources(this.pobieranieGroupBox, "pobieranieGroupBox");
            this.pobieranieGroupBox.Controls.Add(this.anulujPobieranieButton);
            this.pobieranieGroupBox.Controls.Add(this.zapiszUtworButton);
            this.pobieranieGroupBox.Controls.Add(this.label2);
            this.pobieranieGroupBox.Controls.Add(this.sciezkaZapisuLabel);
            this.pobieranieGroupBox.Controls.Add(this.linkUrlTextBox);
            this.pobieranieGroupBox.Controls.Add(this.urlLabel);
            this.pobieranieGroupBox.Controls.Add(this.label1);
            this.pobieranieGroupBox.Name = "pobieranieGroupBox";
            this.pobieranieGroupBox.TabStop = false;
            // 
            // anulujPobieranieButton
            // 
            this.anulujPobieranieButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.anulujPobieranieButton, "anulujPobieranieButton");
            this.anulujPobieranieButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.anulujPobieranieButton.Name = "anulujPobieranieButton";
            this.anulujPobieranieButton.UseVisualStyleBackColor = true;
            // 
            // zapiszUtworButton
            // 
            resources.ApplyResources(this.zapiszUtworButton, "zapiszUtworButton");
            this.zapiszUtworButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.zapiszUtworButton.Name = "zapiszUtworButton";
            this.zapiszUtworButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Name = "label2";
            // 
            // sciezkaZapisuLabel
            // 
            resources.ApplyResources(this.sciezkaZapisuLabel, "sciezkaZapisuLabel");
            this.sciezkaZapisuLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sciezkaZapisuLabel.Name = "sciezkaZapisuLabel";
            // 
            // linkUrlTextBox
            // 
            resources.ApplyResources(this.linkUrlTextBox, "linkUrlTextBox");
            this.linkUrlTextBox.Name = "linkUrlTextBox";
            // 
            // urlLabel
            // 
            resources.ApplyResources(this.urlLabel, "urlLabel");
            this.urlLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.urlLabel.Name = "urlLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
            // 
            // oknoPobierania
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.anulujPobieranieButton;
            this.Controls.Add(this.pobieranieGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oknoPobierania";
            this.pobieranieGroupBox.ResumeLayout(false);
            this.pobieranieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pobieranieGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox linkUrlTextBox;
        private System.Windows.Forms.Button zapiszUtworButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sciezkaZapisuLabel;
        private System.Windows.Forms.Button anulujPobieranieButton;
    }
}