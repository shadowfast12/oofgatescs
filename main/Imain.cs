using oofgates.func;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oofgates.main
{
    public partial class Imain : UserControl
    {
        public Imain()
        {
            InitializeComponent();
            Set(0);
        }

        public Boolean Set(int event_num)
        {
            //overview_panel.Visible = false;
            Main.CurrEvent = event_num;
            if (Main.CurrEvent == 0)
            {
                EventTextbox.Text = ("You have fallen into the world of OOFGATES... You find a Rock, Sword, & Dagger. Pick One");
                Ui.SetButtons(new Button[] { Option4Button }, new Button[] { Option1Button, Option2Button, Option3Button }, new string[] { "ROCK", "Rusty Sword", "Dagger" });
            }
            else if (Main.CurrEvent == 1)
            {
                EventTextbox.Text = ("A Black Man has approached you with his sword drawn and demands that you give him all your money or die!");
                Ui.SetButtons(new Button[] { Option3Button, Option4Button }, new Button[] { Option1Button, Option2Button }, new string[] { "Attack", "Give the Money" });
            }
            else if (Main.CurrEvent == 2)
            {
                EventTextbox.Text = ("Welcome to Wuhan City, you can go to:");
                Ui.SetButtons(new Button[] { }, new Button[] { Option1Button, Option2Button, Option3Button }, new string[] { "Shop", "Forest", "Casino", "Arena" });
            }
            else
            {
                return false;
            }
            return true;
        }

        private void option1_button_Click(object sender, EventArgs e)
        {
            if (Main.CurrEvent == 0)
            {
                Main.User.set_inventory(Main.allItems.get_item(1), 0);
                Set(1);
            }
            else if (Main.CurrEvent == 1)
            {
                //Ibattle.InitBattle(Main.User, Main.allPlayers.GetPlayer(2));
            }

        }

        private void option2_button_Click(object sender, EventArgs e)
        {
            if (Main.CurrEvent == 0)
            {
                Main.User.set_inventory(Main.allItems.get_item(2), 0);
                Set(1);
            }
        }

        private void option3_button_Click(object sender, EventArgs e)
        {
            if (Main.CurrEvent == 0)
            {
                Main.User.set_inventory(Main.allItems.get_item(3), 0);
                Set(1);
            }
        }

        private void option4_button_Click(object sender, EventArgs e)
        {

        }

        private void stats_button_Click(object sender, EventArgs e)
        {

        }

        private void OMouseLeave(object sender,EventArgs e)
        {
            if (Main.CurrEvent==0)
            {
                //overviewpanel.visible==false;
            }
        }

        private void Option1Button_MouseHover(object sender, EventArgs e)
        {
            if(Main.CurrEvent == 0)
            {
                //init_item_info(all_items.get_item(1));
            }
        }

        private void Option2Button_MouseHover(object sender, EventArgs e)
        {
            if (Main.CurrEvent==0)
            {
                //init_item_info(all_items.get_item(2));
            }
        }

        private void Option3Button_MouseHover(object sender, EventArgs e)
        {
            if (Main.CurrEvent == 0)
            {
                //init_item_info(all_items.get_item(3));
            }
        }
    }
}
