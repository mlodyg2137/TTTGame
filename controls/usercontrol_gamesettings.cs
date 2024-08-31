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
                dto.PlayerNickname = textBox1.Text.Trim();
                dto.Bestof = Int32.Parse(checkedListBox2.CheckedItems[0].ToString());
                if (checkedListBox1.SelectedIndex == 0)
                {
                    dto.ChosenOpponent = "player";
                    if ((string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrWhiteSpace(textBox2.Text)))
                    {
                        dto.OpponentNickname = "nameless";
                    }
                    else
                    {
                        dto.OpponentNickname = textBox2.Text.Trim();
                    }
                }
                else if (checkedListBox1.SelectedIndex == 1)
                {
                    dto.ChosenOpponent = "easy_bot";
                    dto.OpponentNickname = "Easy Bot";
                }
                else if (checkedListBox1.SelectedIndex == 2)
                {
                    dto.ChosenOpponent = "hard_bot";
                    dto.OpponentNickname = "Hard Bot";
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
                label4.Text = "Nickname contains spaces only!";
            }
            else if (correctDataStatus == 3)
            {
                label4.Text = "Nickname's length is greater than 9!";
            }
            else if (correctDataStatus == 4)
            {
                label4.Text = "Not chosen opponent!";
            }
            else if (correctDataStatus == 5)
            {
                label4.Text = "Not chosen Best-of!";
            }
            else if (correctDataStatus == 6)
            {
                label4.Text = "Nickname cannot be 'Easy/Hard Bot'!";
            }
        }

        private int ifCorrectData()
        {
            // Possible outcomes
            // 0 - Everything is correct
            // 1 - Null or empty nickname
            // 2 - Null or spaces-only in nickname
            // 3 - Length of nickname is greater than 9
            // 4 - Not chosen opponent
            // 5 - Not chosen best-of
            // 6 - 'Easy/Hard Bot' in nickname

            if ((string.IsNullOrEmpty(textBox1.Text))||(string.IsNullOrEmpty(textBox2.Text)))
            {
                return 1;
            }
            if ((string.IsNullOrWhiteSpace(textBox1.Text))||(string.IsNullOrWhiteSpace(textBox2.Text)))
            {
                return 2;
            }
            if ((textBox1.Text.Length > 9)||(textBox2.Text.Length > 9))
            {
                return 3;
            }
            if (checkedListBox1.CheckedItems.Count <= 0) 
            {
                return 4;
            }
            if (checkedListBox2.CheckedItems.Count <= 0)
            {
                return 5;
            }
            if ((((textBox1.Text == "Easy Bot") || (textBox1.Text == "Hard Bot") || (textBox2.Text == "Easy Bot") || (textBox2.Text == "Hard Bot")) && (checkedListBox1.SelectedIndex==0)) || 
                    (((textBox1.Text=="Easy Bot") || (textBox1.Text == "Hard Bot")) && ((checkedListBox1.SelectedIndex==1)||(checkedListBox1.SelectedIndex==2))))
            {
                return 6;
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
                if (index==1) textBox2.Text = "Easy Bot";
                else if (index==2) textBox2.Text = "Hard Bot";
            }

            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
        private void handleCheckbox2Change(object sender, EventArgs e)
        {
            int index = checkedListBox2.SelectedIndex;
            int count = checkedListBox2.Items.Count;

            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox2.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
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
