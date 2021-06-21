using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibertyMinerGUI
{
    class GraphicalFunctionality
    {
        public static void ToggleTrueFalseButton(Button button, bool boolean)
        {
            if (button.Text == "True")
            {
                boolean = false;
                button.Text = "False";
            }
            else
            {
                boolean = true;
                button.Text = "True";
            }
        }
    }
}
