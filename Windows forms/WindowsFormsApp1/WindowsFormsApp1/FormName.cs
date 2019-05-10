﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormName : Form
    {
        int numPlayers;
        public FormName()
        {
            InitializeComponent();
        }

        public FormName(int players)
        {
            InitializeComponent();
            numPlayers = players;            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (numPlayers ==1 )
            {
                if ((textBoxNamePlayer1.Text).Length != 0)
                {
                    FormGame formGame = new FormGame(textBoxNamePlayer1.Text);
                    this.Close();
                    formGame.Show();
                }
                else{
                    MessageBox.Show("Ingrese nombre del jugador");
                }
            }
            if (numPlayers == 2)
            {
                if (((textBoxNamePlayer1.Text).Length != 0) && ((textBoxNamePlayer2.Text).Length != 0))
                {
                    FormGameTwoPlayers formGameTwoPlayers = new FormGameTwoPlayers(textBoxNamePlayer1.Text, textBoxNamePlayer2.Text);
                    this.Close();
                    formGameTwoPlayers.Show();
                }
                else {
                    MessageBox.Show("Ingrese nombre de ambos jugadores");
                }

            }

        }

        private void FormName_Load(object sender, EventArgs e)
        {
            if (numPlayers == 1)
            {
                label2.Visible = false;
                textBoxNamePlayer2.Visible = false;
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {

            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            this.Close();
            formMenuPrincipal.Show();
            
        }
    }
}
