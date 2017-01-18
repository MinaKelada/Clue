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
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }
        private void ok_click(Object sender, EventArgs e)
        {
            List<string>current = new List<string>();
            List<string> n = new List<string>();
            for (int i = 0; i < Game.playerNumber; i++)
            {
                current.Add(currentNames[i].Text);
                if (newNames[i].Text != "" && !string.IsNullOrWhiteSpace(newNames[i].Text))
                {
                    n.Add(newNames[i].Text);
                }
            }
            bool ident = identCheck(current, n);
            if (ident)
            {
                warning.Visible = true;
            }
            else
            {
                warning.Visible = false;
                for (int i = 0; i < Game.playerNumber; i++)
                {
                    if (newNames[i].Text != "" && !string.IsNullOrWhiteSpace(newNames[i].Text))
                    {
                        Game.players[i].name = newNames[i].Text;
                        Game.raiseRename();
                    }
                }
                this.Close();
            }
        }
        private bool identCheck(List<string> current, List<string> newName)
        {
            bool found = false;
            foreach (string name in newName)
            {
                foreach (string c in current)
                {
                    if (name == c)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
                int foundNum = 0;
                foreach (string n in newName)
                {
                    if (name == n)
                    {
                        foundNum++;
                        if (foundNum > 1)
                        {
                            found = true;
                            break;
                        }
                    }
                }
            }
            return found;
        }
    }
}
