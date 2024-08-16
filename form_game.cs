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
    public partial class form_game : Form
    {
        public form_game()
        {
            InitializeComponent();
        }

        private void loadMenu(object sender, FormClosedEventArgs e)
        {
            this.Close();
            form_menu menu = new form_menu();
            menu.Show();
            
        }
    }
}
