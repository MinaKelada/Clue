using System;
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
    public partial class Form1 : Form
    {
      //  Form2 form = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                warning.Text = "Your name cannot be left blank";
                warning.Visible = true;
                textBox1.Text = "";
            }
            else
            {
                warning.Visible = false;
                Game.setInitialState(comboBox1.SelectedItem.ToString(), textBox1.Text);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
