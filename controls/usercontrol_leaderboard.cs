using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTTGame
{
    public partial class usercontrol_leaderboard : UserControl
    {
        public usercontrol_leaderboard()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string dataSource = "Data Source=gameDB.db";

            using (var connection = new SQLiteConnection(dataSource))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT ROW_NUMBER() OVER (ORDER BY [ranking_points] DESC) AS rank, nickname, ranking_points FROM players";
                   
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgv_board.DataSource = dataTable;
                    dgv_board.Columns["rank"].HeaderText = "Rank";
                    dgv_board.Columns["nickname"].HeaderText = "Nickname";
                    dgv_board.Columns["ranking_points"].HeaderText = "Ranking ELO";



                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
                
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
            Parent.Controls["panel_menu"].Visible = true;
            Parent.Controls["panel_menu"].BringToFront();
        }

        private void handleVisibleChange(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadData();
            }
            
        }
    }
}
