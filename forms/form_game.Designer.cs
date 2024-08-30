namespace TTTGame
{
    partial class form_game
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
            this.components = new System.ComponentModel.Container();
            this.panel_game = new System.Windows.Forms.Panel();
            this.panel_board = new System.Windows.Forms.Panel();
            this.field_6 = new System.Windows.Forms.PictureBox();
            this.field_2 = new System.Windows.Forms.PictureBox();
            this.field_1 = new System.Windows.Forms.PictureBox();
            this.field_0 = new System.Windows.Forms.PictureBox();
            this.field_5 = new System.Windows.Forms.PictureBox();
            this.field_4 = new System.Windows.Forms.PictureBox();
            this.field_3 = new System.Windows.Forms.PictureBox();
            this.field_8 = new System.Windows.Forms.PictureBox();
            this.field_7 = new System.Windows.Forms.PictureBox();
            this.label_endgame_descr = new System.Windows.Forms.Label();
            this.game_status = new System.Windows.Forms.Label();
            this.label_player1 = new System.Windows.Forms.Label();
            this.label_player2 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label_player1_sign = new System.Windows.Forms.Label();
            this.label_player2_sign = new System.Windows.Forms.Label();
            this.label_bestof = new System.Windows.Forms.Label();
            this.label_round = new System.Windows.Forms.Label();
            this.panel_endround = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.label_winstatus = new System.Windows.Forms.Label();
            this.timer_handlebot = new System.Windows.Forms.Timer(this.components);
            this.panel_game.SuspendLayout();
            this.panel_board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_7)).BeginInit();
            this.panel_endround.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_game
            // 
            this.panel_game.BackgroundImage = global::TTTGame.Properties.Resources.game_page;
            this.panel_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_game.Controls.Add(this.panel_board);
            this.panel_game.Controls.Add(this.game_status);
            this.panel_game.Location = new System.Drawing.Point(12, 12);
            this.panel_game.Name = "panel_game";
            this.panel_game.Size = new System.Drawing.Size(610, 626);
            this.panel_game.TabIndex = 0;
            // 
            // panel_board
            // 
            this.panel_board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_board.Controls.Add(this.field_6);
            this.panel_board.Controls.Add(this.field_2);
            this.panel_board.Controls.Add(this.field_1);
            this.panel_board.Controls.Add(this.field_0);
            this.panel_board.Controls.Add(this.field_5);
            this.panel_board.Controls.Add(this.field_4);
            this.panel_board.Controls.Add(this.field_3);
            this.panel_board.Controls.Add(this.field_8);
            this.panel_board.Controls.Add(this.field_7);
            this.panel_board.Controls.Add(this.label_endgame_descr);
            this.panel_board.Location = new System.Drawing.Point(84, 114);
            this.panel_board.Name = "panel_board";
            this.panel_board.Size = new System.Drawing.Size(450, 450);
            this.panel_board.TabIndex = 0;
            // 
            // field_6
            // 
            this.field_6.Image = global::TTTGame.Properties.Resources.field;
            this.field_6.Location = new System.Drawing.Point(0, 0);
            this.field_6.Name = "field_6";
            this.field_6.Size = new System.Drawing.Size(150, 150);
            this.field_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_6.TabIndex = 0;
            this.field_6.TabStop = false;
            this.field_6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickField);
            this.field_6.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.field_6.MouseHover += new System.EventHandler(this.mouseOnField);
            this.field_6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseOnField);
            // 
            // field_2
            // 
            this.field_2.Image = global::TTTGame.Properties.Resources.field;
            this.field_2.Location = new System.Drawing.Point(300, 300);
            this.field_2.Name = "field_2";
            this.field_2.Size = new System.Drawing.Size(150, 150);
            this.field_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_2.TabIndex = 8;
            this.field_2.TabStop = false;
            this.field_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickField);
            this.field_2.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.field_2.MouseHover += new System.EventHandler(this.mouseOnField);
            this.field_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseOnField);
            // 
            // field_1
            // 
            this.field_1.Image = global::TTTGame.Properties.Resources.field;
            this.field_1.Location = new System.Drawing.Point(150, 300);
            this.field_1.Name = "field_1";
            this.field_1.Size = new System.Drawing.Size(150, 150);
            this.field_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_1.TabIndex = 7;
            this.field_1.TabStop = false;
            this.field_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickField);
            this.field_1.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.field_1.MouseHover += new System.EventHandler(this.mouseOnField);
            this.field_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseOnField);
            // 
            // field_0
            // 
            this.field_0.Image = global::TTTGame.Properties.Resources.field;
            this.field_0.Location = new System.Drawing.Point(0, 300);
            this.field_0.Name = "field_0";
            this.field_0.Size = new System.Drawing.Size(150, 150);
            this.field_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_0.TabIndex = 6;
            this.field_0.TabStop = false;
            this.field_0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickField);
            this.field_0.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.field_0.MouseHover += new System.EventHandler(this.mouseOnField);
            this.field_0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseOnField);
            // 
            // field_5
            // 
            this.field_5.Image = global::TTTGame.Properties.Resources.field;
            this.field_5.Location = new System.Drawing.Point(300, 150);
            this.field_5.Name = "field_5";
            this.field_5.Size = new System.Drawing.Size(150, 150);
            this.field_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_5.TabIndex = 5;
            this.field_5.TabStop = false;
            this.field_5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickField);
            this.field_5.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.field_5.MouseHover += new System.EventHandler(this.mouseOnField);
            this.field_5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseOnField);
            // 
            // field_4
            // 
            this.field_4.Image = global::TTTGame.Properties.Resources.field;
            this.field_4.Location = new System.Drawing.Point(150, 150);
            this.field_4.Name = "field_4";
            this.field_4.Size = new System.Drawing.Size(150, 150);
            this.field_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_4.TabIndex = 4;
            this.field_4.TabStop = false;
            this.field_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickField);
            this.field_4.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.field_4.MouseHover += new System.EventHandler(this.mouseOnField);
            this.field_4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseOnField);
            // 
            // field_3
            // 
            this.field_3.Image = global::TTTGame.Properties.Resources.field;
            this.field_3.Location = new System.Drawing.Point(0, 150);
            this.field_3.Name = "field_3";
            this.field_3.Size = new System.Drawing.Size(150, 150);
            this.field_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_3.TabIndex = 3;
            this.field_3.TabStop = false;
            this.field_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickField);
            this.field_3.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.field_3.MouseHover += new System.EventHandler(this.mouseOnField);
            this.field_3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseOnField);
            // 
            // field_8
            // 
            this.field_8.Image = global::TTTGame.Properties.Resources.field;
            this.field_8.Location = new System.Drawing.Point(300, 0);
            this.field_8.Name = "field_8";
            this.field_8.Size = new System.Drawing.Size(150, 150);
            this.field_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_8.TabIndex = 2;
            this.field_8.TabStop = false;
            this.field_8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickField);
            this.field_8.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.field_8.MouseHover += new System.EventHandler(this.mouseOnField);
            this.field_8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseOnField);
            // 
            // field_7
            // 
            this.field_7.Image = global::TTTGame.Properties.Resources.field;
            this.field_7.Location = new System.Drawing.Point(150, 0);
            this.field_7.Name = "field_7";
            this.field_7.Size = new System.Drawing.Size(150, 150);
            this.field_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.field_7.TabIndex = 1;
            this.field_7.TabStop = false;
            this.field_7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickField);
            this.field_7.MouseLeave += new System.EventHandler(this.mouseOutField);
            this.field_7.MouseHover += new System.EventHandler(this.mouseOnField);
            this.field_7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseOnField);
            // 
            // label_endgame_descr
            // 
            this.label_endgame_descr.BackColor = System.Drawing.SystemColors.Control;
            this.label_endgame_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_endgame_descr.Location = new System.Drawing.Point(69, 65);
            this.label_endgame_descr.Name = "label_endgame_descr";
            this.label_endgame_descr.Size = new System.Drawing.Size(322, 302);
            this.label_endgame_descr.TabIndex = 10;
            this.label_endgame_descr.Text = "end_game_description";
            this.label_endgame_descr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_endgame_descr.Visible = false;
            // 
            // game_status
            // 
            this.game_status.AutoSize = true;
            this.game_status.BackColor = System.Drawing.SystemColors.Control;
            this.game_status.Location = new System.Drawing.Point(266, 586);
            this.game_status.Name = "game_status";
            this.game_status.Size = new System.Drawing.Size(93, 13);
            this.game_status.TabIndex = 1;
            this.game_status.Text = "Player on move: X";
            // 
            // label_player1
            // 
            this.label_player1.AutoEllipsis = true;
            this.label_player1.BackColor = System.Drawing.SystemColors.Control;
            this.label_player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_player1.Location = new System.Drawing.Point(652, 204);
            this.label_player1.MaximumSize = new System.Drawing.Size(100, 25);
            this.label_player1.MinimumSize = new System.Drawing.Size(100, 25);
            this.label_player1.Name = "label_player1";
            this.label_player1.Size = new System.Drawing.Size(100, 25);
            this.label_player1.TabIndex = 2;
            this.label_player1.Text = "PLAYER1";
            this.label_player1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_player2
            // 
            this.label_player2.AutoEllipsis = true;
            this.label_player2.BackColor = System.Drawing.SystemColors.Control;
            this.label_player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_player2.Location = new System.Drawing.Point(843, 204);
            this.label_player2.Name = "label_player2";
            this.label_player2.Size = new System.Drawing.Size(100, 25);
            this.label_player2.TabIndex = 3;
            this.label_player2.Text = "PLAYER2";
            this.label_player2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.SystemColors.Control;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_result.Location = new System.Drawing.Point(760, 204);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(75, 25);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "result";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_player1_sign
            // 
            this.label_player1_sign.BackColor = System.Drawing.SystemColors.Control;
            this.label_player1_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_player1_sign.Location = new System.Drawing.Point(726, 233);
            this.label_player1_sign.Name = "label_player1_sign";
            this.label_player1_sign.Size = new System.Drawing.Size(26, 25);
            this.label_player1_sign.TabIndex = 5;
            this.label_player1_sign.Text = "S";
            this.label_player1_sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_player2_sign
            // 
            this.label_player2_sign.BackColor = System.Drawing.SystemColors.Control;
            this.label_player2_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_player2_sign.Location = new System.Drawing.Point(843, 233);
            this.label_player2_sign.Name = "label_player2_sign";
            this.label_player2_sign.Size = new System.Drawing.Size(26, 25);
            this.label_player2_sign.TabIndex = 6;
            this.label_player2_sign.Text = "S";
            this.label_player2_sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_bestof
            // 
            this.label_bestof.BackColor = System.Drawing.SystemColors.Control;
            this.label_bestof.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bestof.Location = new System.Drawing.Point(741, 69);
            this.label_bestof.Name = "label_bestof";
            this.label_bestof.Size = new System.Drawing.Size(116, 35);
            this.label_bestof.TabIndex = 7;
            this.label_bestof.Text = "bestof";
            this.label_bestof.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_round
            // 
            this.label_round.BackColor = System.Drawing.SystemColors.Control;
            this.label_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_round.Location = new System.Drawing.Point(741, 142);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(116, 30);
            this.label_round.TabIndex = 8;
            this.label_round.Text = "round";
            this.label_round.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_endround
            // 
            this.panel_endround.Controls.Add(this.btn_next);
            this.panel_endround.Controls.Add(this.label_winstatus);
            this.panel_endround.Location = new System.Drawing.Point(671, 326);
            this.panel_endround.Name = "panel_endround";
            this.panel_endround.Size = new System.Drawing.Size(258, 250);
            this.panel_endround.TabIndex = 9;
            this.panel_endround.Visible = false;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_next.Location = new System.Drawing.Point(30, 179);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(188, 39);
            this.btn_next.TabIndex = 11;
            this.btn_next.Text = "next/end";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label_winstatus
            // 
            this.label_winstatus.BackColor = System.Drawing.SystemColors.Control;
            this.label_winstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_winstatus.Location = new System.Drawing.Point(26, 20);
            this.label_winstatus.Name = "label_winstatus";
            this.label_winstatus.Size = new System.Drawing.Size(203, 50);
            this.label_winstatus.TabIndex = 10;
            this.label_winstatus.Text = "win_status";
            this.label_winstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_handlebot
            // 
            this.timer_handlebot.Tick += new System.EventHandler(this.timer_handlebot_Tick);
            // 
            // form_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(969, 660);
            this.Controls.Add(this.panel_endround);
            this.Controls.Add(this.label_round);
            this.Controls.Add(this.label_bestof);
            this.Controls.Add(this.label_player2_sign);
            this.Controls.Add(this.label_player1_sign);
            this.Controls.Add(this.label_player1);
            this.Controls.Add(this.label_player2);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.panel_game);
            this.Name = "form_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loadMenu);
            this.Shown += new System.EventHandler(this.loadGameForm);
            this.panel_game.ResumeLayout(false);
            this.panel_game.PerformLayout();
            this.panel_board.ResumeLayout(false);
            this.panel_board.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_7)).EndInit();
            this.panel_endround.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_game;
        private System.Windows.Forms.Panel panel_board;
        private System.Windows.Forms.PictureBox field_6;
        private System.Windows.Forms.PictureBox field_5;
        private System.Windows.Forms.PictureBox field_4;
        private System.Windows.Forms.PictureBox field_3;
        private System.Windows.Forms.PictureBox field_8;
        private System.Windows.Forms.PictureBox field_7;
        private System.Windows.Forms.PictureBox field_2;
        private System.Windows.Forms.PictureBox field_1;
        private System.Windows.Forms.PictureBox field_0;
        private System.Windows.Forms.Label game_status;
        private System.Windows.Forms.Label label_player1;
        private System.Windows.Forms.Label label_player2;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_player1_sign;
        private System.Windows.Forms.Label label_player2_sign;
        private System.Windows.Forms.Label label_bestof;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.Panel panel_endround;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label_winstatus;
        private System.Windows.Forms.Label label_endgame_descr;
        private System.Windows.Forms.Timer timer_handlebot;
    }
}