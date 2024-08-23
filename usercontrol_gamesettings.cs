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
            int correctDataStatus = ifCorrectData();
            if (correctDataStatus == 0)
            {
                DataTransferObject dto = new DataTransferObject();
                dto.PlayerNickname = textBox1.Text;
                if (checkedListBox1.SelectedIndex == 0)
                {
                    dto.ChosenOpponent = "player";
                    if ((string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrWhiteSpace(textBox2.Text)))
                    {
                        dto.OpponentNickname = "Opponent";
                    }
                    else
                    {
                        dto.OpponentNickname = textBox2.Text;
                    }
                }
                else if (checkedListBox1.SelectedIndex == 1)
                {
                    dto.ChosenOpponent = "easy_bot";
                }
                else if (checkedListBox1.SelectedIndex == 2)
                {
                    dto.ChosenOpponent = "hard_bot";
                }


                form_game gamePage = new form_game(dto);
                ParentForm.Hide();
                gamePage.ShowDialog();
            }
            else if (correctDataStatus == 1)
            {
                label4.Text = "Set nickname!";
            }
            else if (correctDataStatus == 2)
            {
                label4.Text = "Your nickname contains spaces only!";
            }
            else if (correctDataStatus == 3)
            {
                label4.Text = "Your nickname's length is greater than 12!";
            }
            else if (correctDataStatus == 4)
            {
                label4.Text = "Not chosen opponent!";
            }
        }

        private int ifCorrectData()
        {
            // Possible outcomes
            // 0 - Everything is correct
            // 1 - Null or empty nickname
            // 2 - Null or spaces-only in nickname
            // 3 - Length of nickname is greater than 12
            // 4 - Not chosen opponent

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return 1;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                return 2;
            }
            if (textBox1.Text.Length > 12)
            {
                return 3;
            }
            if (checkedListBox1.CheckedItems.Count <= 0) 
            {
                return 4;
            }

            return 0;
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
