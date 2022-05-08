using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oofgates.func
{
    public class Ui
    {

        public static void SetButtons(Button[] inactive_buttons, Button[] active_buttons, string[] texts)
        {
            for (int i = 0; i < active_buttons.Length; i++)
            {
                active_buttons[i].Text = texts[i];
                active_buttons[i].Visible = true;
            }
            for (int i = 0; i < inactive_buttons.Length; i++)
            {
                inactive_buttons[i].Visible = false;
            }
        }

        public static void SetTextbox(TextBox textBox, String[] contam)
        {
            textBox.Clear();
            foreach (String str in contam)
            {
                textBox.AppendText(str + Environment.NewLine);
            }
        }

        public static void UpdateBar(Panel panel, int curr_var, int tot_var)
        {
            panel.SetBounds(0, 0, (int)Math.Floor((double)curr_var / tot_var) * panel.Size.Width, panel.Bounds.Y);
        }
    }
}
