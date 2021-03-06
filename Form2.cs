﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clue
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void showAll_Click(object sender, EventArgs e)
        {
            Form3 show = new Form3();
            show.ShowDialog();
        }
        private void rename_Click(object sender, EventArgs e)
        {
            RenameForm r = new RenameForm();
            r.ShowDialog();
        }
        private void assign_Click(object sender, EventArgs e)
        {
            string i = Game.assignCard(assignCard.SelectedItem.ToString(), assignPlayerName.SelectedItem.ToString());
            if(i != null)
            {
                warning.Text = i;
                warning.Visible = true;
            }
            else
            {
                warning.Visible = false;
            }
        }
    }
}
