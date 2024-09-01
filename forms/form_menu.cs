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
    /// Reprezentuje główne menu aplikacji "Kółko i krzyżyk".
    /// Formularz ten obsługuje nawigację po aplikacji, w tym przejście do ustawień gry, tablicy wyników oraz zamknięcie aplikacji.
    /// </summary>
    public partial class form_menu : Form
    {
        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="form_menu"/>.
        /// </summary>
        public form_menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Zamyka aplikację po zamknięciu formularza.
        /// </summary>
        private void closeApplication(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Zamyka aplikację po kliknięciu odpowiedniego przycisku w menu.
        /// </summary>
        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ładuje ustawienia gry, ukrywając główne menu i wyświetlając kontrolkę ustawień gry.
        /// </summary>
        private void loadGameSettings(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_menu.SendToBack();
            usercontrol_gamesettings1.Visible = true;
            usercontrol_gamesettings1.BringToFront();
        }

        /// <summary>
        /// Ładuje tablicę wyników, ukrywając główne menu i wyświetlając kontrolkę tablicy wyników.
        /// </summary>
        private void loadLeaderboard(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_menu.SendToBack();
            usercontrol_leaderboard1.Visible = true;
            usercontrol_leaderboard1.BringToFront();
        }

        /// <summary>
        /// Wyświetla główne menu po załadowaniu formularza.
        /// </summary>
        private void shownMenu(object sender, EventArgs e)
        {
            panel_menu.Visible = true;
            panel_menu.Show();
        }

        /// <summary>
        /// Zmienia obraz przycisku na wersję przyiemnioną, gdy kursor myszy znajdzie się nad przyciskiem.
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
        /// Zmienia obraz przycisku na wersję przyiemnioną, gdy kursor myszy porusza się po przycisku.
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
