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
        private void loadGame(object sender, EventArgs e)
        {
            form_game gamePage = new form_game();
            this.Hide();
            
            gamePage.ShowDialog();
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

        private void shownMenu(object sender, EventArgs e)
        {
            panel_menu.Visible = true;
            panel_menu.Show();
        }
    }
}
