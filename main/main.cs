using oofgates.attributes;
using System;
using System.Windows.Forms;

namespace oofgates
{
    public partial class Main : Form
    {
        private int curr_event;
        private player user;

        public Main()
        {
            InitializeComponent();
            set(0);
            user = new player(100,10,2,1,10,5,5);
        }
        public Boolean set(int event_num)
        {
            curr_event=event_num;
            if (curr_event==0)
            {
                set_event_text("You have fallen into the world of oofgates... You find a Rock, Sword, & Dagger. Pick One");
                set_buttons("Rock", "Rusty Sword", "Dagger");
                return true;
            }
            if (curr_event == 1)
            {
                set_event_text("A Black Man has approached you with ihs sword drawn and demands that you give him all your money or die!");
                set_buttons("Attack","Give the Money");
                return true;
            }
            if (curr_event==2)
            {
                set_event_text("Welcome to Wuhan City, you can go to:");
                set_buttons("Shop","Forest","Casino","Arena");
            }
            return false;
        }
        private void set_buttons(string text1,string text2)
        {
            option1.Visible = true;
            option2.Visible = true;

            option1.Text = text1;
            option2.Text = text2;
        }
        private void set_buttons(string text1,string text2,string text3)
        {
            option1.Visible = true;
            option2.Visible = true;
            option3.Visible = true;

            option1.Text= text1;
            option2.Text= text2;
            option3.Text= text3;
            option4.Visible= false;
        }
        private void set_buttons(string text1,string text2,string text3,string text4)
        {
            option1.Visible= true;
            option2.Visible= true;
            option3.Visible= true;
            option4.Visible= true;

            option1.Text=text1;
            option2.Text= text2;
            option3.Text = text3;
            option4.Text= text4;
        }
        private void set_event_text(string text)
        {
            event_text.Text = text;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void event_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void option1_Click(object sender, EventArgs e)
        {
            if (curr_event==0)
            {
                item rock = new item("Rock", 5, -1, 15, 0);
                user.set_inventory(rock,0);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void init_stats(player uplayer)
        {
            health_label.Text = "Health: "+uplayer.get_health();
            damage_label.Text = "Damage: "+uplayer.get_damage();
            armor_label.Text = "Armor: " + uplayer.get_armor();
            speed_label.Text="Speed: "+uplayer.get_speed();
            coins_label.Text = "Coins: " + uplayer.get_coins();

            foreach(item it in uplayer.get_inventory())
            {
                inventory_info.AppendText(Environment.NewLine + it.get_name());
            }
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (curr_event == 0)
            {
                item rusty_sword = new item("Rusty Sword", 12, -5, 25, 0);
                user.set_inventory(rusty_sword,0);
            }
        }

        private void option3_Click(object sender, EventArgs e)
        {
            if (curr_event == 0)
            {
                item dagger = new item("Dagger",8,0,30,0);
                user.set_inventory(dagger,0);
            }
        }

        private void option4_Click(object sender, EventArgs e)
        {

        }

        private void stats_button_Click(object sender, EventArgs e)
        {
            main_panel.Enabled = false;
            main_panel.Visible = false;

            init_stats(user);
            info_panel.Visible = true;
            info_panel.Enabled = true;

        }

        private void armor_label_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            info_panel.Enabled = false;
            info_panel.Visible = false;

            main_panel.Enabled = true;
            main_panel.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
