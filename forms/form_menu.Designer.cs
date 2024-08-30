namespace TTTGame
{
    partial class form_menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_leaderboard = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.usercontrol_gamesettings1 = new TTTGame.usercontrol_gamesettings();
            this.usercontrol_leaderboard1 = new TTTGame.usercontrol_leaderboard();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_leaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackgroundImage = global::TTTGame.Properties.Resources.menu_page;
            this.panel_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_menu.Controls.Add(this.btn_exit);
            this.panel_menu.Controls.Add(this.btn_leaderboard);
            this.panel_menu.Controls.Add(this.btn_start);
            this.panel_menu.Location = new System.Drawing.Point(124, 76);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(393, 487);
            this.panel_menu.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Image = global::TTTGame.Properties.Resources.exit_btn;
            this.btn_exit.Location = new System.Drawing.Point(98, 351);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(201, 83);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 2;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.closeApplication);
            // 
            // btn_leaderboard
            // 
            this.btn_leaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_leaderboard.Image = global::TTTGame.Properties.Resources.leaderboard_btn;
            this.btn_leaderboard.Location = new System.Drawing.Point(98, 229);
            this.btn_leaderboard.Name = "btn_leaderboard";
            this.btn_leaderboard.Size = new System.Drawing.Size(201, 83);
            this.btn_leaderboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_leaderboard.TabIndex = 1;
            this.btn_leaderboard.TabStop = false;
            this.btn_leaderboard.Click += new System.EventHandler(this.loadLeaderboard);
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.Image = global::TTTGame.Properties.Resources.start_btn;
            this.btn_start.Location = new System.Drawing.Point(98, 108);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(201, 83);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_start.TabIndex = 0;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.loadGameSettings);
            // 
            // usercontrol_gamesettings1
            // 
            this.usercontrol_gamesettings1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usercontrol_gamesettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usercontrol_gamesettings1.Location = new System.Drawing.Point(0, 0);
            this.usercontrol_gamesettings1.Name = "usercontrol_gamesettings1";
            this.usercontrol_gamesettings1.Size = new System.Drawing.Size(634, 611);
            this.usercontrol_gamesettings1.TabIndex = 1;
            this.usercontrol_gamesettings1.Visible = false;
            // 
            // usercontrol_leaderboard1
            // 
            this.usercontrol_leaderboard1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usercontrol_leaderboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usercontrol_leaderboard1.Location = new System.Drawing.Point(0, 0);
            this.usercontrol_leaderboard1.Name = "usercontrol_leaderboard1";
            this.usercontrol_leaderboard1.Size = new System.Drawing.Size(634, 611);
            this.usercontrol_leaderboard1.TabIndex = 2;
            this.usercontrol_leaderboard1.Visible = false;
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.usercontrol_gamesettings1);
            this.Controls.Add(this.usercontrol_leaderboard1);
            this.Name = "form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeApplication);
            this.Shown += new System.EventHandler(this.shownMenu);
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_leaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox btn_leaderboard;
        private System.Windows.Forms.PictureBox btn_exit;
        private usercontrol_gamesettings usercontrol_gamesettings1;
        private usercontrol_leaderboard usercontrol_leaderboard1;
    }
}

