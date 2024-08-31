using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTTGame
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }
        

        private void closeApplication(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadGameSettings(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_menu.SendToBack();
            usercontrol_gamesettings1.Visible = true;
            usercontrol_gamesettings1.BringToFront();
        }

        private void loadLeaderboard(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_menu.SendToBack();
            usercontrol_leaderboard1.Visible = true;
            usercontrol_leaderboard1.BringToFront();
        }

        private void shownMenu(object sender, EventArgs e)
        {
            panel_menu.Visible = true;
            panel_menu.Show();
        }

        private void mouseOnField(object sender, EventArgs e)
        {
            var snd = sender as PictureBox;
            if (snd.Name == "btn_start")
                (sender as PictureBox).Image = Properties.Resources.start_btn_hover;
            else if (snd.Name == "btn_leaderboard")
                (sender as PictureBox).Image = Properties.Resources.leaderboard_btn_hover;
            else if (snd.Name == "btn_exit")
                (sender as PictureBox).Image = Properties.Resources.exit_btn_hover;


        }
        private void mouseMovingOnField(object sender, MouseEventArgs e)
        {
            var snd = sender as PictureBox;
            if (snd.Name == "btn_start")
                (sender as PictureBox).Image = Properties.Resources.start_btn_hover;
            else if (snd.Name == "btn_leaderboard")
                (sender as PictureBox).Image = Properties.Resources.leaderboard_btn_hover;
            else if (snd.Name == "btn_exit")
                (sender as PictureBox).Image = Properties.Resources.exit_btn_hover;
        }

        private void mouseOutField(object sender, EventArgs e)
        {
            var snd = sender as PictureBox;
            if (snd.Name == "btn_start")
                (sender as PictureBox).Image = Properties.Resources.start_btn;
            else if (snd.Name == "btn_leaderboard")
                (sender as PictureBox).Image = Properties.Resources.leaderboard_btn;
            else if (snd.Name == "btn_exit")
                (sender as PictureBox).Image = Properties.Resources.exit_btn;
        }

        
    }
}
