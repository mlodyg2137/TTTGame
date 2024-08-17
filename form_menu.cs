﻿using System;
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
        Field[] fields = new Field[9];
        private void loadFields(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                fields[i] = new Field($"field_{i}", i, false);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
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
