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
            this.btn_back = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.PictureBox();
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
            this.panel_gamesettings.Controls.Add(this.checkedListBox2);
            this.panel_gamesettings.Controls.Add(this.label5);
            this.panel_gamesettings.Controls.Add(this.label4);
            this.panel_gamesettings.Controls.Add(this.textBox2);
            this.panel_gamesettings.Controls.Add(this.label3);
            this.panel_gamesettings.Controls.Add(this.checkedListBox1);
            this.panel_gamesettings.Controls.Add(this.label2);
            this.panel_gamesettings.Controls.Add(this.textBox1);
            this.panel_gamesettings.Controls.Add(this.label1);
            this.panel_gamesettings.Controls.Add(this.btn_start);
            this.panel_gamesettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_gamesettings.Location = new System.Drawing.Point(0, 0);
            this.panel_gamesettings.Name = "panel_gamesettings";
            this.panel_gamesettings.Size = new System.Drawing.Size(650, 650);
            this.panel_gamesettings.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(41, 95);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7"});
            this.checkedListBox2.Location = new System.Drawing.Point(222, 388);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(39, 64);
            this.checkedListBox2.TabIndex = 12;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.handleCheckbox2Change);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(138, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Best-of";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(138, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "SET NICKNAME AND CHOOSE OPPONENT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 330);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(355, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opponent\'s nickname";
            this.label3.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "2 Players",
            "Easy bot",
            "Hard bot"});
            this.checkedListBox1.Location = new System.Drawing.Point(222, 301);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(96, 49);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.handleCheckboxChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opponent";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(110, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nickname";
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
            this.btn_start.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.btn_start.MouseHover += new System.EventHandler(this.mouseOnField);
            this.btn_start.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovingOnField);
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
            this.panel_gamesettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_gamesettings;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_back;
    }
}
