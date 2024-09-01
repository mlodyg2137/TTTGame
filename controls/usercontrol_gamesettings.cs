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
    /// <summary>
    /// Kontrolka użytkownika odpowiadająca za ustawienia gry w "Kółko i krzyżyk". Umożliwia graczowi wybór pseudonimu, przeciwnika oraz ustawienie opcji gry.
    /// </summary>
    public partial class usercontrol_gamesettings : UserControl
    {
        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="usercontrol_gamesettings"/>.
        /// </summary>
        public usercontrol_gamesettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ładuje grę na podstawie ustawień wprowadzonych przez użytkownika.
        /// </summary>
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
            else
            {
                HandleIncorrectData(correctDataStatus);
            }
        }

        /// <summary>
        /// Sprawdza, czy dane wprowadzone przez użytkownika są poprawne.
        /// </summary>
        /// <returns>Kod statusu, który reprezentuje wynik weryfikacji danych.</returns>
        private int ifCorrectData()
        {
            // Możliwe wyniki
            // 0 - Wszystko jest poprawne
            // 1 - Pseudonim jest pusty lub null
            // 2 - Pseudonim zawiera tylko spacje
            // 3 - Długość pseudonimu jest większa niż 9
            // 4 - Nie wybrano przeciwnika
            // 5 - Nie wybrano opcji "Best-of"
            // 6 - Pseudonim nie może być "Easy/Hard Bot"

            if ((string.IsNullOrEmpty(textBox_nickname.Text)) || (string.IsNullOrEmpty(textBox_opponentNickname.Text)))
            {
                return 1;
            }
            if ((string.IsNullOrWhiteSpace(textBox_nickname.Text)) || (string.IsNullOrWhiteSpace(textBox_opponentNickname.Text)))
            {
                return 2;
            }
            if ((textBox_nickname.Text.Length > 9) || (textBox_opponentNickname.Text.Length > 9))
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
            if ((((textBox_nickname.Text == "Easy Bot") || (textBox_nickname.Text == "Hard Bot") || (textBox_opponentNickname.Text == "Easy Bot") || (textBox_opponentNickname.Text == "Hard Bot")) && (checkedListBox_opponent.SelectedIndex == 0)) ||
                    (((textBox_nickname.Text == "Easy Bot") || (textBox_nickname.Text == "Hard Bot")) && ((checkedListBox_opponent.SelectedIndex == 1) || (checkedListBox_opponent.SelectedIndex == 2))))
            {
                return 6;
            }

            return 0;
        }

        /// <summary>
        /// Obsługuje zwrócony kod błędu z metody <see cref="ifCorrectData"/> i wyświetla odpowiedni komunikat.
        /// </summary>
        /// <param name="correctDataStatus">Kod błędu zwrócony przez metodę <see cref="ifCorrectData"/>.</param>
        private void HandleIncorrectData(int correctDataStatus)
        {
            switch (correctDataStatus)
            {
                case 1:
                    label4.Text = "Set nickname!";
                    break;
                case 2:
                    label4.Text = "Nickname contains spaces only!";
                    break;
                case 3:
                    label4.Text = "Nickname's length is greater than 9!";
                    break;
                case 4:
                    label4.Text = "Not chosen opponent!";
                    break;
                case 5:
                    label4.Text = "Not chosen Best-of!";
                    break;
                case 6:
                    label4.Text = "Nickname cannot be 'Easy/Hard Bot'!";
                    break;
            }
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku "Back", powracając do głównego menu.
        /// </summary>
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
            Parent.Controls["panel_menu"].Visible = true;
            Parent.Controls["panel_menu"].BringToFront();
        }

        /// <summary>
        /// Obsługuje zmianę zaznaczenia przeciwnika w liście wyboru przeciwnika.
        /// </summary>
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
                if (index == 1) textBox_opponentNickname.Text = "Easy Bot";
                else if (index == 2) textBox_opponentNickname.Text = "Hard Bot";
            }

            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox_opponent.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        /// <summary>
        /// Obsługuje zmianę zaznaczenia opcji "Best-of" w liście wyboru.
        /// </summary>
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

        /// <summary>
        /// Zmienia obraz przycisku na wersję podświetloną, gdy kursor myszy znajdzie się nad przyciskiem.
        /// </summary>
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

        /// <summary>
        /// Zmienia obraz przycisku na wersję podświetloną, gdy kursor myszy porusza się po przycisku.
        /// </summary>
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

        /// <summary>
        /// Przywraca oryginalny obraz przycisku, gdy kursor myszy opuszcza przycisk.
        /// </summary>
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
