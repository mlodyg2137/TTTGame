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
    }
}
