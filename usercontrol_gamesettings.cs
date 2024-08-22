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
    public partial class usercontrol_gamesettings : UserControl
    {
        public usercontrol_gamesettings()
        {
            InitializeComponent();
        }

        private void loadGame(object sender, EventArgs e)
        {
            form_game gamePage = new form_game();
            ParentForm.Hide();
            gamePage.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
            Parent.Controls["panel_menu"].Visible = true;
            Parent.Controls["panel_menu"].BringToFront();
        }

        private void handleCheckboxChange(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;

            if (index == 0) 
            { 
                label3.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBox2.Visible = false;
            }

            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
    }
}
