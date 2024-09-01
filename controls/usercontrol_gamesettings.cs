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
                dto.PlayerNickname = textBox_nickname.Text.Trim();
                dto.Bestof = Int32.Parse(checkedListBox_bestof.CheckedItems[0].ToString());
                if (checkedListBox_opponent.SelectedIndex == 0)
                {
                    dto.ChosenOpponent = "player";
                    if ((string.IsNullOrEmpty(textBox_opponentNickname.Text)) || (string.IsNullOrWhiteSpace(textBox_opponentNickname.Text)))
                    {
                        dto.OpponentNickname = "nameless";
                    }
                    else
                    {
                        dto.OpponentNickname = textBox_opponentNickname.Text.Trim();
                    }
                }
                else if (checkedListBox_opponent.SelectedIndex == 1)
                {
                    dto.ChosenOpponent = "easy_bot";
                    dto.OpponentNickname = "Easy Bot";
                }
                else if (checkedListBox_opponent.SelectedIndex == 2)
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

            if ((string.IsNullOrEmpty(textBox_nickname.Text))||(string.IsNullOrEmpty(textBox_opponentNickname.Text)))
            {
                return 1;
            }
            if ((string.IsNullOrWhiteSpace(textBox_nickname.Text))||(string.IsNullOrWhiteSpace(textBox_opponentNickname.Text)))
            {
                return 2;
            }
            if ((textBox_nickname.Text.Length > 9)||(textBox_opponentNickname.Text.Length > 9))
            {
                return 3;
            }
            if (checkedListBox_opponent.CheckedItems.Count <= 0) 
            {
                return 4;
            }
            if (checkedListBox_bestof.CheckedItems.Count <= 0)
            {
                return 5;
            }
            if ((((textBox_nickname.Text == "Easy Bot") || (textBox_nickname.Text == "Hard Bot") || (textBox_opponentNickname.Text == "Easy Bot") || (textBox_opponentNickname.Text == "Hard Bot")) && (checkedListBox_opponent.SelectedIndex==0)) || 
                    (((textBox_nickname.Text=="Easy Bot") || (textBox_nickname.Text == "Hard Bot")) && ((checkedListBox_opponent.SelectedIndex==1)||(checkedListBox_opponent.SelectedIndex==2))))
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
            int index = checkedListBox_opponent.SelectedIndex;
            int count = checkedListBox_opponent.Items.Count;

            if (index == 0) 
            { 
                label3.Visible = true;
                textBox_opponentNickname.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBox_opponentNickname.Visible = false;
                if (index==1) textBox_opponentNickname.Text = "Easy Bot";
                else if (index==2) textBox_opponentNickname.Text = "Hard Bot";
            }

            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox_opponent.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
        private void handleCheckbox2Change(object sender, EventArgs e)
        {
            int index = checkedListBox_bestof.SelectedIndex;
            int count = checkedListBox_bestof.Items.Count;

            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox_bestof.SetItemCheckState(i, CheckState.Unchecked);
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
