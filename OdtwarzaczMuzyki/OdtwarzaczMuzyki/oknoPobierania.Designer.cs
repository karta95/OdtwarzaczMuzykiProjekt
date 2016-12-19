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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tytulOknaPobierania = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.wybierzSciezkebutton = new System.Windows.Forms.Button();
            this.sciezkaZapisuLabel = new System.Windows.Forms.Label();
            this.wyswietlenieSciezkiLabel = new System.Windows.Forms.Label();
            this.pobierzUtworButton = new System.Windows.Forms.Button();
            this.anulujPobieranieButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anulujPobieranieButton);
            this.groupBox1.Controls.Add(this.pobierzUtworButton);
            this.groupBox1.Controls.Add(this.wyswietlenieSciezkiLabel);
            this.groupBox1.Controls.Add(this.sciezkaZapisuLabel);
            this.groupBox1.Controls.Add(this.wybierzSciezkebutton);
            this.groupBox1.Controls.Add(this.urlTextBox);
            this.groupBox1.Controls.Add(this.urlLabel);
            this.groupBox1.Controls.Add(this.tytulOknaPobierania);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tytulOknaPobierania
            // 
            resources.ApplyResources(this.tytulOknaPobierania, "tytulOknaPobierania");
            this.tytulOknaPobierania.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tytulOknaPobierania.Name = "tytulOknaPobierania";
            // 
            // urlLabel
            // 
            resources.ApplyResources(this.urlLabel, "urlLabel");
            this.urlLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.urlLabel.Name = "urlLabel";
            // 
            // urlTextBox
            // 
            resources.ApplyResources(this.urlTextBox, "urlTextBox");
            this.urlTextBox.Name = "urlTextBox";
            // 
            // wybierzSciezkebutton
            // 
            resources.ApplyResources(this.wybierzSciezkebutton, "wybierzSciezkebutton");
            this.wybierzSciezkebutton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.wybierzSciezkebutton.Name = "wybierzSciezkebutton";
            this.wybierzSciezkebutton.UseVisualStyleBackColor = true;
            // 
            // sciezkaZapisuLabel
            // 
            resources.ApplyResources(this.sciezkaZapisuLabel, "sciezkaZapisuLabel");
            this.sciezkaZapisuLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sciezkaZapisuLabel.Name = "sciezkaZapisuLabel";
            // 
            // wyswietlenieSciezkiLabel
            // 
            resources.ApplyResources(this.wyswietlenieSciezkiLabel, "wyswietlenieSciezkiLabel");
            this.wyswietlenieSciezkiLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.wyswietlenieSciezkiLabel.Name = "wyswietlenieSciezkiLabel";
            // 
            // pobierzUtworButton
            // 
            resources.ApplyResources(this.pobierzUtworButton, "pobierzUtworButton");
            this.pobierzUtworButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.pobierzUtworButton.Name = "pobierzUtworButton";
            this.pobierzUtworButton.UseVisualStyleBackColor = true;
            // 
            // anulujPobieranieButton
            // 
            this.anulujPobieranieButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.anulujPobieranieButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.anulujPobieranieButton, "anulujPobieranieButton");
            this.anulujPobieranieButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.anulujPobieranieButton.Name = "anulujPobieranieButton";
            this.anulujPobieranieButton.UseVisualStyleBackColor = true;
            // 
            // oknoPobierania
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.anulujPobieranieButton;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oknoPobierania";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tytulOknaPobierania;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label wyswietlenieSciezkiLabel;
        private System.Windows.Forms.Label sciezkaZapisuLabel;
        private System.Windows.Forms.Button wybierzSciezkebutton;
        private System.Windows.Forms.Button pobierzUtworButton;
        private System.Windows.Forms.Button anulujPobieranieButton;
    }
}