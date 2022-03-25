using oofgates.attributes;
using oofgates.infos;
using System;
using System.Windows.Forms;

namespace oofgates
{
    public partial class Main : Form
    {
        private int curr_event;
        private player user;

        internal static ability_list all_abilities = new ability_list("res\\abilities.oof");
        static item_list all_items = new item_list("res\\items.oof");
        public Main()
        {
            InitializeComponent();
            set(0);
            user = new player(100,10,10,5,5,1d,5,5,10);

        }
        public Boolean set(int event_num)
        {
            curr_event=event_num;
            if (curr_event==0)
            {
                set_event_text("You have fallen into the world of OOFGATES... You find a Rock, Sword, & Dagger. Pick One");
                set_buttons("Rock", "Rusty Sword", "Dagger");
            }
            else if (curr_event == 1)
            {
                set_event_text("A Black Man has approached you with his sword drawn and demands that you give him all your money or die!");
                set_buttons("Attack","Give the Money");
            }
            else if (curr_event==2)
            {
                set_event_text("Welcome to Wuhan City, you can go to:");
                set_buttons("Shop","Forest","Casino","Arena");
            }
            else
            {
                return false;
            }
            return true;
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
                user.set_inventory(all_items.get_item(1),0);
            }
            if (curr_event==1)
            {
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void init_stats(player uplayer)
        {
            health_label.Text = "Health: "+uplayer.get_health();
            ad_label.Text = "AD: "+uplayer.get_ad();
            ap_label.Text = "AP: " + uplayer.get_ap();
            ad_resist_label.Text = "AD Resist: " + uplayer.get_ad_resist();
            ap_resist_label.Text = "AP Resist: " + uplayer.get_ap_resist();
            speed_label.Text="Speed: "+uplayer.get_speed();
            coins_label.Text = "Coins: " + uplayer.get_coins();

            inventory_info.Clear();
            foreach (item it in uplayer.get_inventory())
            {
                inventory_info.AppendText(Environment.NewLine + it.get_name());
            }
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (curr_event == 0)
            {
                user.set_inventory(all_items.get_item(2),0);
            }
        }

        private void option3_Click(object sender, EventArgs e)
        {
            if (curr_event == 0)
            {
                user.set_inventory(all_items.get_item(3),0);
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
        private void update_enemy_energy_bar(int energy,int tot_energy)
        {
            curr_energy_bar.SetBounds(0, 0, (int)Math.Floor((double)energy / tot_energy) * 247, 13);
        }
        private void update_enemy_health_bar(int health,int tot_health)
        {
            enemy_healthbar.SetBounds(0, 0, (int) Math.Floor((double)health / tot_health) * 247, 13);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void damage_label_Click(object sender, EventArgs e)
        {

        }

        private void fight_button_Click(object sender, EventArgs e)
        {

        }
    }
}
