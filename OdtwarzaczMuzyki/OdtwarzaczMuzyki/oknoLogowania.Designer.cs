﻿namespace OdtwarzaczMuzyki
{
    partial class oknoLogowania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoLogowania));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.anulujLogowaniebutton = new System.Windows.Forms.Button();
            this.zalogujButton = new System.Windows.Forms.Button();
            this.tytulOknaLog = new System.Windows.Forms.Label();
            this.hasloLogTextBox = new System.Windows.Forms.TextBox();
            this.loginLogTextBox = new System.Windows.Forms.TextBox();
            this.hasloLogowanieLabel = new System.Windows.Forms.Label();
            this.loginLogowanieLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anulujLogowaniebutton);
            this.groupBox1.Controls.Add(this.zalogujButton);
            this.groupBox1.Controls.Add(this.tytulOknaLog);
            this.groupBox1.Controls.Add(this.hasloLogTextBox);
            this.groupBox1.Controls.Add(this.loginLogTextBox);
            this.groupBox1.Controls.Add(this.hasloLogowanieLabel);
            this.groupBox1.Controls.Add(this.loginLogowanieLabel);
            this.groupBox1.Location = new System.Drawing.Point(1, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // anulujLogowaniebutton
            // 
            this.anulujLogowaniebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anulujLogowaniebutton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anulujLogowaniebutton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.anulujLogowaniebutton.Location = new System.Drawing.Point(266, 240);
            this.anulujLogowaniebutton.Name = "anulujLogowaniebutton";
            this.anulujLogowaniebutton.Size = new System.Drawing.Size(77, 27);
            this.anulujLogowaniebutton.TabIndex = 6;
            this.anulujLogowaniebutton.Text = "anuluj";
            this.anulujLogowaniebutton.UseVisualStyleBackColor = true;
            // 
            // zalogujButton
            // 
            this.zalogujButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalogujButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.zalogujButton.Location = new System.Drawing.Point(174, 240);
            this.zalogujButton.Name = "zalogujButton";
            this.zalogujButton.Size = new System.Drawing.Size(85, 28);
            this.zalogujButton.TabIndex = 5;
            this.zalogujButton.Text = "zaloguj";
            this.zalogujButton.UseVisualStyleBackColor = true;
            this.zalogujButton.Click += new System.EventHandler(this.zalogujButton_Click);
            // 
            // tytulOknaLog
            // 
            this.tytulOknaLog.AutoSize = true;
            this.tytulOknaLog.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytulOknaLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tytulOknaLog.Location = new System.Drawing.Point(170, 36);
            this.tytulOknaLog.Name = "tytulOknaLog";
            this.tytulOknaLog.Size = new System.Drawing.Size(90, 21);
            this.tytulOknaLog.TabIndex = 4;
            this.tytulOknaLog.Text = "LOGOWANIE";
            // 
            // hasloLogTextBox
            // 
            this.hasloLogTextBox.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloLogTextBox.Location = new System.Drawing.Point(174, 163);
            this.hasloLogTextBox.Name = "hasloLogTextBox";
            this.hasloLogTextBox.Size = new System.Drawing.Size(169, 27);
            this.hasloLogTextBox.TabIndex = 3;
            // 
            // loginLogTextBox
            // 
            this.loginLogTextBox.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLogTextBox.Location = new System.Drawing.Point(174, 111);
            this.loginLogTextBox.Name = "loginLogTextBox";
            this.loginLogTextBox.Size = new System.Drawing.Size(169, 29);
            this.loginLogTextBox.TabIndex = 2;
            // 
            // hasloLogowanieLabel
            // 
            this.hasloLogowanieLabel.AutoSize = true;
            this.hasloLogowanieLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloLogowanieLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hasloLogowanieLabel.Location = new System.Drawing.Point(91, 169);
            this.hasloLogowanieLabel.Name = "hasloLogowanieLabel";
            this.hasloLogowanieLabel.Size = new System.Drawing.Size(50, 21);
            this.hasloLogowanieLabel.TabIndex = 1;
            this.hasloLogowanieLabel.Text = "hasło :";
            // 
            // loginLogowanieLabel
            // 
            this.loginLogowanieLabel.AutoSize = true;
            this.loginLogowanieLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLogowanieLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginLogowanieLabel.Location = new System.Drawing.Point(91, 119);
            this.loginLogowanieLabel.Name = "loginLogowanieLabel";
            this.loginLogowanieLabel.Size = new System.Drawing.Size(47, 21);
            this.loginLogowanieLabel.TabIndex = 0;
            this.loginLogowanieLabel.Text = "login :";
            // 
            // oknoLogowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.anulujLogowaniebutton;
            this.ClientSize = new System.Drawing.Size(442, 344);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(442, 344);
            this.MinimumSize = new System.Drawing.Size(442, 344);
            this.Name = "oknoLogowania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "oknoLogowania";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label hasloLogowanieLabel;
        private System.Windows.Forms.Label loginLogowanieLabel;
        private System.Windows.Forms.TextBox hasloLogTextBox;
        private System.Windows.Forms.TextBox loginLogTextBox;
        private System.Windows.Forms.Label tytulOknaLog;
        private System.Windows.Forms.Button zalogujButton;
        private System.Windows.Forms.Button anulujLogowaniebutton;
    }
}