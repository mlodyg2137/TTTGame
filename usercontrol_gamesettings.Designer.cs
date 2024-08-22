namespace TTTGame
{
    partial class usercontrol_gamesettings
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_gamesettings = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel_gamesettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_gamesettings
            // 
            this.panel_gamesettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_gamesettings.BackgroundImage = global::TTTGame.Properties.Resources.gamesettings_page;
            this.panel_gamesettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_gamesettings.Controls.Add(this.btn_back);
            this.panel_gamesettings.Controls.Add(this.btn_start);
            this.panel_gamesettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_gamesettings.Location = new System.Drawing.Point(0, 0);
            this.panel_gamesettings.Name = "panel_gamesettings";
            this.panel_gamesettings.Size = new System.Drawing.Size(650, 650);
            this.panel_gamesettings.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.Image = global::TTTGame.Properties.Resources.start_btn;
            this.btn_start.Location = new System.Drawing.Point(253, 538);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(148, 59);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_start.TabIndex = 2;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.loadGame);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(51, 105);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(126, 51);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // usercontrol_gamesettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel_gamesettings);
            this.Name = "usercontrol_gamesettings";
            this.Size = new System.Drawing.Size(650, 650);
            this.panel_gamesettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_gamesettings;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.Button btn_back;
    }
}
