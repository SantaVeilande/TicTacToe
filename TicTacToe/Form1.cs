﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool XPlayerTurn = true;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }
        private void InitializeGrid()
        {
            Grid.BackColor = Color.LightCoral;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
        }

        private void Player_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (XPlayerTurn)
            {
                label.Text = "X";
            }
            else
            {
                label.Text = "0";
            }
            XPlayerTurn = !XPlayerTurn;
        }
    }
}
