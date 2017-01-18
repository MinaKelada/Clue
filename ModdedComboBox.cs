using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Clue
{
    class ModdedComboBox: ComboBox
    {
        public void OnRename(object source, EventArgs args)
        {
            this.Items.Clear();
            this.Items.AddRange(Game.getAllPlayerNames());
            this.SelectedIndex = 0;
        }
    }
}
