namespace OdtwarzaczMuzyki
{
    partial class main
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
            this.playlistsDataGridView = new System.Windows.Forms.DataGridView();
            this.nazwaProfiluLabel = new System.Windows.Forms.Label();
            this.nazwa_profilugroupBox1 = new System.Windows.Forms.GroupBox();
            this.utworyDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nazwaPlaylistyLabel = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.mójProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńNazwęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńHasłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pobierzZYouTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zalogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasekMenu = new System.Windows.Forms.MenuStrip();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsDataGridView)).BeginInit();
            this.nazwa_profilugroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utworyDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pasekMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // playlistsDataGridView
            // 
            this.playlistsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playlistsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistsDataGridView.Location = new System.Drawing.Point(15, 60);
            this.playlistsDataGridView.Name = "playlistsDataGridView";
            this.playlistsDataGridView.Size = new System.Drawing.Size(320, 336);
            this.playlistsDataGridView.TabIndex = 1;
            // 
            // nazwaProfiluLabel
            // 
            this.nazwaProfiluLabel.AutoSize = true;
            this.nazwaProfiluLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaProfiluLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nazwaProfiluLabel.Location = new System.Drawing.Point(23, 9);
            this.nazwaProfiluLabel.Name = "nazwaProfiluLabel";
            this.nazwaProfiluLabel.Size = new System.Drawing.Size(119, 21);
            this.nazwaProfiluLabel.TabIndex = 2;
            this.nazwaProfiluLabel.Text = "NAZWA PROFILU";
            this.nazwaProfiluLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nazwa_profilugroupBox1
            // 
            this.nazwa_profilugroupBox1.Controls.Add(this.nazwaProfiluLabel);
            this.nazwa_profilugroupBox1.ForeColor = System.Drawing.Color.Plum;
            this.nazwa_profilugroupBox1.Location = new System.Drawing.Point(15, 27);
            this.nazwa_profilugroupBox1.Name = "nazwa_profilugroupBox1";
            this.nazwa_profilugroupBox1.Size = new System.Drawing.Size(320, 27);
            this.nazwa_profilugroupBox1.TabIndex = 3;
            this.nazwa_profilugroupBox1.TabStop = false;
            // 
            // utworyDataGridView
            // 
            this.utworyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.utworyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utworyDataGridView.Location = new System.Drawing.Point(340, 60);
            this.utworyDataGridView.Name = "utworyDataGridView";
            this.utworyDataGridView.Size = new System.Drawing.Size(460, 336);
            this.utworyDataGridView.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nazwaPlaylistyLabel);
            this.groupBox1.Location = new System.Drawing.Point(341, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 27);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // nazwaPlaylistyLabel
            // 
            this.nazwaPlaylistyLabel.AutoSize = true;
            this.nazwaPlaylistyLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaPlaylistyLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nazwaPlaylistyLabel.Location = new System.Drawing.Point(28, 9);
            this.nazwaPlaylistyLabel.Name = "nazwaPlaylistyLabel";
            this.nazwaPlaylistyLabel.Size = new System.Drawing.Size(133, 21);
            this.nazwaPlaylistyLabel.TabIndex = 0;
            this.nazwaPlaylistyLabel.Text = "NAZWA PLAYLISTY";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
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
            this.pobierzZYouTubeToolStripMenuItem.Click += new System.EventHandler(this.pobierzZYouTubeToolStripMenuItem_Click);
            // 
            // zalogujToolStripMenuItem
            // 
            this.zalogujToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalogujToolStripMenuItem.Margin = new System.Windows.Forms.Padding(500, 0, 0, 0);
            this.zalogujToolStripMenuItem.Name = "zalogujToolStripMenuItem";
            this.zalogujToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.zalogujToolStripMenuItem.Text = "Zaloguj";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            // 
            // pasekMenu
            // 
            this.pasekMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pasekMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.pasekMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mójProfilToolStripMenuItem,
            this.pobierzZYouTubeToolStripMenuItem,
            this.zalogujToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.pasekMenu.Location = new System.Drawing.Point(0, 0);
            this.pasekMenu.Name = "pasekMenu";
            this.pasekMenu.Size = new System.Drawing.Size(565, 24);
            this.pasekMenu.TabIndex = 0;
            this.pasekMenu.Text = "menuStrip1";
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(812, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.utworyDataGridView);
            this.Controls.Add(this.nazwa_profilugroupBox1);
            this.Controls.Add(this.playlistsDataGridView);
            this.Controls.Add(this.pasekMenu);
            this.MainMenuStrip = this.pasekMenu;
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.Resize += new System.EventHandler(this.main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.playlistsDataGridView)).EndInit();
            this.nazwa_profilugroupBox1.ResumeLayout(false);
            this.nazwa_profilugroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utworyDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pasekMenu.ResumeLayout(false);
            this.pasekMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView playlistsDataGridView;
        private System.Windows.Forms.Label nazwaProfiluLabel;
        private System.Windows.Forms.GroupBox nazwa_profilugroupBox1;
        private System.Windows.Forms.DataGridView utworyDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nazwaPlaylistyLabel;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripMenuItem mójProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńNazwęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńHasłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pobierzZYouTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zalogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.MenuStrip pasekMenu;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
    }
}

