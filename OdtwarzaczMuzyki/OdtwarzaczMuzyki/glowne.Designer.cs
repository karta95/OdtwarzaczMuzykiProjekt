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
            this.zmieńEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pobierzZYouTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasekMenu = new System.Windows.Forms.MenuStrip();
            this.logowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistGroupBox = new System.Windows.Forms.GroupBox();
            this.playlistScrollBar = new System.Windows.Forms.VScrollBar();
            this.panelWyszukajPlayliste = new System.Windows.Forms.Panel();
            this.profilPlaylisty = new System.Windows.Forms.DataGridView();
            this.pasekPostepu = new System.Windows.Forms.ProgressBar();
            this.terazOdtwarzaneNazwa = new System.Windows.Forms.Label();
            this.czasOdtwarzania = new System.Windows.Forms.Label();
            this.panelOdtwarzanie = new System.Windows.Forms.Panel();
            this.utworyScrollBar = new System.Windows.Forms.VScrollBar();
            this.panelWyszukajUtwor = new System.Windows.Forms.Panel();
            this.utworyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistaUtwory)).BeginInit();
            this.pasekMenu.SuspendLayout();
            this.playlistGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilPlaylisty)).BeginInit();
            this.panelOdtwarzanie.SuspendLayout();
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
            this.utworyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.utworyGroupBox.Controls.Add(this.panelWyszukajUtwor);
            this.utworyGroupBox.Controls.Add(this.utworyScrollBar);
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
            this.playlistaUtwory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.zmieńHasłoToolStripMenuItem,
            this.zmieńEmailToolStripMenuItem});
            this.mójProfilToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mójProfilToolStripMenuItem.Name = "mójProfilToolStripMenuItem";
            this.mójProfilToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.mójProfilToolStripMenuItem.Text = "Mój profil";
            // 
            // zmieńNazwęToolStripMenuItem
            // 
            this.zmieńNazwęToolStripMenuItem.Name = "zmieńNazwęToolStripMenuItem";
            this.zmieńNazwęToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.zmieńNazwęToolStripMenuItem.Text = "Zmień nazwę";
            // 
            // zmieńHasłoToolStripMenuItem
            // 
            this.zmieńHasłoToolStripMenuItem.Name = "zmieńHasłoToolStripMenuItem";
            this.zmieńHasłoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.zmieńHasłoToolStripMenuItem.Text = "Zmień hasło";
            // 
            // zmieńEmailToolStripMenuItem
            // 
            this.zmieńEmailToolStripMenuItem.Name = "zmieńEmailToolStripMenuItem";
            this.zmieńEmailToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.zmieńEmailToolStripMenuItem.Text = "Zmień email";
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
            this.playlistGroupBox.Controls.Add(this.playlistScrollBar);
            this.playlistGroupBox.Controls.Add(this.panelWyszukajPlayliste);
            this.playlistGroupBox.Controls.Add(this.nazwaProfiluLabel);
            this.playlistGroupBox.Controls.Add(this.profilPlaylisty);
            this.playlistGroupBox.Location = new System.Drawing.Point(12, 35);
            this.playlistGroupBox.Name = "playlistGroupBox";
            this.playlistGroupBox.Size = new System.Drawing.Size(345, 398);
            this.playlistGroupBox.TabIndex = 6;
            this.playlistGroupBox.TabStop = false;
            // 
            // playlistScrollBar
            // 
            this.playlistScrollBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.playlistScrollBar.Location = new System.Drawing.Point(329, 19);
            this.playlistScrollBar.Name = "playlistScrollBar";
            this.playlistScrollBar.Size = new System.Drawing.Size(10, 342);
            this.playlistScrollBar.TabIndex = 4;
            // 
            // panelWyszukajPlayliste
            // 
            this.panelWyszukajPlayliste.Location = new System.Drawing.Point(7, 368);
            this.panelWyszukajPlayliste.Name = "panelWyszukajPlayliste";
            this.panelWyszukajPlayliste.Size = new System.Drawing.Size(331, 24);
            this.panelWyszukajPlayliste.TabIndex = 3;
            // 
            // profilPlaylisty
            // 
            this.profilPlaylisty.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profilPlaylisty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profilPlaylisty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profilPlaylisty.Location = new System.Drawing.Point(6, 19);
            this.profilPlaylisty.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.profilPlaylisty.Name = "profilPlaylisty";
            this.profilPlaylisty.Size = new System.Drawing.Size(333, 342);
            this.profilPlaylisty.TabIndex = 0;
            // 
            // pasekPostepu
            // 
            this.pasekPostepu.BackColor = System.Drawing.Color.SlateBlue;
            this.pasekPostepu.Cursor = System.Windows.Forms.Cursors.Default;
            this.pasekPostepu.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.pasekPostepu.Location = new System.Drawing.Point(-1, 3);
            this.pasekPostepu.Name = "pasekPostepu";
            this.pasekPostepu.Size = new System.Drawing.Size(869, 10);
            this.pasekPostepu.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pasekPostepu.TabIndex = 0;
            this.pasekPostepu.Value = 40;
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
            // panelOdtwarzanie
            // 
            this.panelOdtwarzanie.Controls.Add(this.czasOdtwarzania);
            this.panelOdtwarzanie.Controls.Add(this.terazOdtwarzaneNazwa);
            this.panelOdtwarzanie.Controls.Add(this.pasekPostepu);
            this.panelOdtwarzanie.Location = new System.Drawing.Point(13, 448);
            this.panelOdtwarzanie.Name = "panelOdtwarzanie";
            this.panelOdtwarzanie.Size = new System.Drawing.Size(868, 75);
            this.panelOdtwarzanie.TabIndex = 7;
            // 
            // utworyScrollBar
            // 
            this.utworyScrollBar.Location = new System.Drawing.Point(502, 18);
            this.utworyScrollBar.Name = "utworyScrollBar";
            this.utworyScrollBar.Size = new System.Drawing.Size(10, 343);
            this.utworyScrollBar.TabIndex = 3;
            // 
            // panelWyszukajUtwor
            // 
            this.panelWyszukajUtwor.Location = new System.Drawing.Point(6, 366);
            this.panelWyszukajUtwor.Name = "panelWyszukajUtwor";
            this.panelWyszukajUtwor.Size = new System.Drawing.Size(506, 24);
            this.panelWyszukajUtwor.TabIndex = 4;
            // 
            // glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 525);
            this.Controls.Add(this.panelOdtwarzanie);
            this.Controls.Add(this.playlistGroupBox);
            this.Controls.Add(this.utworyGroupBox);
            this.Controls.Add(this.pasekMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.pasekMenu;
            this.Name = "glowne";
            this.Text = "Form1";
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
            this.panelOdtwarzanie.ResumeLayout(false);
            this.panelOdtwarzanie.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem zmieńEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pobierzZYouTubeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip pasekMenu;
        private System.Windows.Forms.ToolStripMenuItem logowanieToolStripMenuItem;
        private System.Windows.Forms.GroupBox playlistGroupBox;
        private System.Windows.Forms.DataGridView profilPlaylisty;
        private System.Windows.Forms.DataGridView playlistaUtwory;
        private System.Windows.Forms.Panel panelWyszukajPlayliste;
        private System.Windows.Forms.ProgressBar pasekPostepu;
        private System.Windows.Forms.Label terazOdtwarzaneNazwa;
        private System.Windows.Forms.Label czasOdtwarzania;
        private System.Windows.Forms.Panel panelOdtwarzanie;
        private System.Windows.Forms.VScrollBar playlistScrollBar;
        private System.Windows.Forms.Panel panelWyszukajUtwor;
        private System.Windows.Forms.VScrollBar utworyScrollBar;
    }
}

