namespace OdtwarzaczMuzyki
{
    partial class glowne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glowne));
            this.nazwaProfiluLabel = new System.Windows.Forms.Label();
            this.utworyGroupBox = new System.Windows.Forms.GroupBox();
            this.playlistaUtwory = new System.Windows.Forms.DataGridView();
            this.nazwaPlaylistyLabel = new System.Windows.Forms.Label();
            this.mójProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńNazwęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńHasłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pobierzZYouTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasekMenu = new System.Windows.Forms.MenuStrip();
            this.logowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistGroupBox = new System.Windows.Forms.GroupBox();
            this.profilPlaylisty = new System.Windows.Forms.DataGridView();
            this.terazOdtwarzaneNazwa = new System.Windows.Forms.Label();
            this.czasOdtwarzania = new System.Windows.Forms.Label();
            this.wyszukajPlayliste = new System.Windows.Forms.Panel();
            this.suwakGlosnosc = new System.Windows.Forms.Label();
            this.pasekGlosnosc = new System.Windows.Forms.Panel();
            this.nastepnyButton = new System.Windows.Forms.Button();
            this.poprzedniButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauzaButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.pasekOdtwarzania = new System.Windows.Forms.Panel();
            this.suwak = new System.Windows.Forms.Label();
            this.utworyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistaUtwory)).BeginInit();
            this.pasekMenu.SuspendLayout();
            this.playlistGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilPlaylisty)).BeginInit();
            this.wyszukajPlayliste.SuspendLayout();
            this.pasekOdtwarzania.SuspendLayout();
            this.SuspendLayout();
            // 
            // nazwaProfiluLabel
            // 
            this.nazwaProfiluLabel.AutoSize = true;
            this.nazwaProfiluLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaProfiluLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nazwaProfiluLabel.Location = new System.Drawing.Point(53, -5);
            this.nazwaProfiluLabel.Name = "nazwaProfiluLabel";
            this.nazwaProfiluLabel.Size = new System.Drawing.Size(119, 21);
            this.nazwaProfiluLabel.TabIndex = 2;
            this.nazwaProfiluLabel.Text = "NAZWA PROFILU";
            // 
            // utworyGroupBox
            // 
            this.utworyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.utworyGroupBox.Controls.Add(this.playlistaUtwory);
            this.utworyGroupBox.Controls.Add(this.nazwaPlaylistyLabel);
            this.utworyGroupBox.Location = new System.Drawing.Point(363, 36);
            this.utworyGroupBox.Name = "utworyGroupBox";
            this.utworyGroupBox.Size = new System.Drawing.Size(518, 397);
            this.utworyGroupBox.TabIndex = 5;
            this.utworyGroupBox.TabStop = false;
            // 
            // playlistaUtwory
            // 
            this.playlistaUtwory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistaUtwory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playlistaUtwory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playlistaUtwory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.playlistaUtwory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistaUtwory.Location = new System.Drawing.Point(4, 18);
            this.playlistaUtwory.Name = "playlistaUtwory";
            this.playlistaUtwory.Size = new System.Drawing.Size(508, 342);
            this.playlistaUtwory.TabIndex = 1;
            // 
            // nazwaPlaylistyLabel
            // 
            this.nazwaPlaylistyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nazwaPlaylistyLabel.AutoSize = true;
            this.nazwaPlaylistyLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaPlaylistyLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nazwaPlaylistyLabel.Location = new System.Drawing.Point(106, -6);
            this.nazwaPlaylistyLabel.Name = "nazwaPlaylistyLabel";
            this.nazwaPlaylistyLabel.Size = new System.Drawing.Size(133, 21);
            this.nazwaPlaylistyLabel.TabIndex = 0;
            this.nazwaPlaylistyLabel.Text = "NAZWA PLAYLISTY";
            this.nazwaPlaylistyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mójProfilToolStripMenuItem
            // 
            this.mójProfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńNazwęToolStripMenuItem,
            this.zmieńHasłoToolStripMenuItem});
            this.mójProfilToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mójProfilToolStripMenuItem.Name = "mójProfilToolStripMenuItem";
            this.mójProfilToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.mójProfilToolStripMenuItem.Text = "Mój profil";
            // 
            // zmieńNazwęToolStripMenuItem
            // 
            this.zmieńNazwęToolStripMenuItem.Name = "zmieńNazwęToolStripMenuItem";
            this.zmieńNazwęToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zmieńNazwęToolStripMenuItem.Text = "Wyświetl profil";
            // 
            // zmieńHasłoToolStripMenuItem
            // 
            this.zmieńHasłoToolStripMenuItem.Name = "zmieńHasłoToolStripMenuItem";
            this.zmieńHasłoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zmieńHasłoToolStripMenuItem.Text = "Edytuj profil";
            // 
            // pobierzZYouTubeToolStripMenuItem
            // 
            this.pobierzZYouTubeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F);
            this.pobierzZYouTubeToolStripMenuItem.Name = "pobierzZYouTubeToolStripMenuItem";
            this.pobierzZYouTubeToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.pobierzZYouTubeToolStripMenuItem.Text = "Pobierz z youtube";
            // 
            // pasekMenu
            // 
            this.pasekMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.pasekMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pobierzZYouTubeToolStripMenuItem,
            this.mójProfilToolStripMenuItem,
            this.logowanieToolStripMenuItem});
            this.pasekMenu.Location = new System.Drawing.Point(0, 0);
            this.pasekMenu.Name = "pasekMenu";
            this.pasekMenu.Size = new System.Drawing.Size(897, 24);
            this.pasekMenu.TabIndex = 0;
            this.pasekMenu.Text = "menuStrip1";
            // 
            // logowanieToolStripMenuItem
            // 
            this.logowanieToolStripMenuItem.Name = "logowanieToolStripMenuItem";
            this.logowanieToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.logowanieToolStripMenuItem.Text = "Zaloguj";
            // 
            // playlistGroupBox
            // 
            this.playlistGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playlistGroupBox.Controls.Add(this.nazwaProfiluLabel);
            this.playlistGroupBox.Controls.Add(this.profilPlaylisty);
            this.playlistGroupBox.Location = new System.Drawing.Point(12, 35);
            this.playlistGroupBox.Name = "playlistGroupBox";
            this.playlistGroupBox.Size = new System.Drawing.Size(345, 398);
            this.playlistGroupBox.TabIndex = 6;
            this.playlistGroupBox.TabStop = false;
            // 
            // profilPlaylisty
            // 
            this.profilPlaylisty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilPlaylisty.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profilPlaylisty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profilPlaylisty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profilPlaylisty.Location = new System.Drawing.Point(6, 19);
            this.profilPlaylisty.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.profilPlaylisty.Name = "profilPlaylisty";
            this.profilPlaylisty.Size = new System.Drawing.Size(333, 342);
            this.profilPlaylisty.TabIndex = 0;
            // 
            // terazOdtwarzaneNazwa
            // 
            this.terazOdtwarzaneNazwa.AutoSize = true;
            this.terazOdtwarzaneNazwa.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.terazOdtwarzaneNazwa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.terazOdtwarzaneNazwa.Location = new System.Drawing.Point(108, 25);
            this.terazOdtwarzaneNazwa.Name = "terazOdtwarzaneNazwa";
            this.terazOdtwarzaneNazwa.Size = new System.Drawing.Size(118, 21);
            this.terazOdtwarzaneNazwa.TabIndex = 1;
            this.terazOdtwarzaneNazwa.Text = "teraz odtwarzane";
            // 
            // czasOdtwarzania
            // 
            this.czasOdtwarzania.AutoSize = true;
            this.czasOdtwarzania.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czasOdtwarzania.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.czasOdtwarzania.Location = new System.Drawing.Point(134, 46);
            this.czasOdtwarzania.Name = "czasOdtwarzania";
            this.czasOdtwarzania.Size = new System.Drawing.Size(66, 24);
            this.czasOdtwarzania.TabIndex = 2;
            this.czasOdtwarzania.Text = "00 : 00";
            // 
            // wyszukajPlayliste
            // 
            this.wyszukajPlayliste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wyszukajPlayliste.Controls.Add(this.suwakGlosnosc);
            this.wyszukajPlayliste.Controls.Add(this.pasekGlosnosc);
            this.wyszukajPlayliste.Controls.Add(this.nastepnyButton);
            this.wyszukajPlayliste.Controls.Add(this.poprzedniButton);
            this.wyszukajPlayliste.Controls.Add(this.stopButton);
            this.wyszukajPlayliste.Controls.Add(this.pauzaButton);
            this.wyszukajPlayliste.Controls.Add(this.playButton);
            this.wyszukajPlayliste.Controls.Add(this.pasekOdtwarzania);
            this.wyszukajPlayliste.Controls.Add(this.czasOdtwarzania);
            this.wyszukajPlayliste.Controls.Add(this.terazOdtwarzaneNazwa);
            this.wyszukajPlayliste.Location = new System.Drawing.Point(13, 439);
            this.wyszukajPlayliste.Name = "wyszukajPlayliste";
            this.wyszukajPlayliste.Size = new System.Drawing.Size(868, 84);
            this.wyszukajPlayliste.TabIndex = 7;
            // 
            // suwakGlosnosc
            // 
            this.suwakGlosnosc.AutoSize = true;
            this.suwakGlosnosc.BackColor = System.Drawing.Color.SlateBlue;
            this.suwakGlosnosc.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.suwakGlosnosc.ForeColor = System.Drawing.Color.SlateBlue;
            this.suwakGlosnosc.Location = new System.Drawing.Point(778, 41);
            this.suwakGlosnosc.Name = "suwakGlosnosc";
            this.suwakGlosnosc.Size = new System.Drawing.Size(9, 14);
            this.suwakGlosnosc.TabIndex = 10;
            this.suwakGlosnosc.Text = "l";
            // 
            // pasekGlosnosc
            // 
            this.pasekGlosnosc.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pasekGlosnosc.Location = new System.Drawing.Point(763, 46);
            this.pasekGlosnosc.Name = "pasekGlosnosc";
            this.pasekGlosnosc.Size = new System.Drawing.Size(99, 5);
            this.pasekGlosnosc.TabIndex = 9;
            // 
            // nastepnyButton
            // 
            this.nastepnyButton.Location = new System.Drawing.Point(661, 25);
            this.nastepnyButton.Name = "nastepnyButton";
            this.nastepnyButton.Size = new System.Drawing.Size(45, 45);
            this.nastepnyButton.TabIndex = 8;
            this.nastepnyButton.UseVisualStyleBackColor = true;
            // 
            // poprzedniButton
            // 
            this.poprzedniButton.Location = new System.Drawing.Point(544, 25);
            this.poprzedniButton.Name = "poprzedniButton";
            this.poprzedniButton.Size = new System.Drawing.Size(45, 45);
            this.poprzedniButton.TabIndex = 7;
            this.poprzedniButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(441, 25);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(45, 45);
            this.stopButton.TabIndex = 6;
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // pauzaButton
            // 
            this.pauzaButton.Location = new System.Drawing.Point(492, 25);
            this.pauzaButton.Name = "pauzaButton";
            this.pauzaButton.Size = new System.Drawing.Size(45, 45);
            this.pauzaButton.TabIndex = 5;
            this.pauzaButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(595, 25);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(60, 45);
            this.playButton.TabIndex = 4;
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // pasekOdtwarzania
            // 
            this.pasekOdtwarzania.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pasekOdtwarzania.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pasekOdtwarzania.Controls.Add(this.suwak);
            this.pasekOdtwarzania.Location = new System.Drawing.Point(3, 8);
            this.pasekOdtwarzania.Name = "pasekOdtwarzania";
            this.pasekOdtwarzania.Size = new System.Drawing.Size(859, 4);
            this.pasekOdtwarzania.TabIndex = 3;
            // 
            // suwak
            // 
            this.suwak.AutoSize = true;
            this.suwak.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.suwak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suwak.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.suwak.Location = new System.Drawing.Point(23, -8);
            this.suwak.Name = "suwak";
            this.suwak.Size = new System.Drawing.Size(37, 15);
            this.suwak.TabIndex = 4;
            this.suwak.Text = "label1";
            // 
            // glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 525);
            this.Controls.Add(this.wyszukajPlayliste);
            this.Controls.Add(this.playlistGroupBox);
            this.Controls.Add(this.utworyGroupBox);
            this.Controls.Add(this.pasekMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.pasekMenu;
            this.Name = "glowne";
            this.Text = "Music";
            this.Load += new System.EventHandler(this.main_Load);
            this.Resize += new System.EventHandler(this.main_Resize);
            this.utworyGroupBox.ResumeLayout(false);
            this.utworyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistaUtwory)).EndInit();
            this.pasekMenu.ResumeLayout(false);
            this.pasekMenu.PerformLayout();
            this.playlistGroupBox.ResumeLayout(false);
            this.playlistGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilPlaylisty)).EndInit();
            this.wyszukajPlayliste.ResumeLayout(false);
            this.wyszukajPlayliste.PerformLayout();
            this.pasekOdtwarzania.ResumeLayout(false);
            this.pasekOdtwarzania.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nazwaProfiluLabel;
        private System.Windows.Forms.GroupBox utworyGroupBox;
        private System.Windows.Forms.Label nazwaPlaylistyLabel;
        private System.Windows.Forms.ToolStripMenuItem mójProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńNazwęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńHasłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pobierzZYouTubeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip pasekMenu;
        private System.Windows.Forms.ToolStripMenuItem logowanieToolStripMenuItem;
        private System.Windows.Forms.GroupBox playlistGroupBox;
        private System.Windows.Forms.DataGridView profilPlaylisty;
        private System.Windows.Forms.DataGridView playlistaUtwory;
        private System.Windows.Forms.Label terazOdtwarzaneNazwa;
        private System.Windows.Forms.Label czasOdtwarzania;
        private System.Windows.Forms.Panel wyszukajPlayliste;
        private System.Windows.Forms.Panel pasekOdtwarzania;
        private System.Windows.Forms.Label suwak;
        private System.Windows.Forms.Button nastepnyButton;
        private System.Windows.Forms.Button poprzedniButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauzaButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label suwakGlosnosc;
        private System.Windows.Forms.Panel pasekGlosnosc;
    }
}

