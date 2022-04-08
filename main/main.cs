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

        public static ability_list all_abilities = new ability_list("res\\abilities.oof");
        public static item_list all_items = new item_list("res\\items.oof");
        public static players_list all_players = new players_list("res\\players.oof");
        public Main()
        {
            InitializeComponent();
            set(0);
            user = all_players.get_player(1);

        }
        public Boolean set(int event_num)
        {
            curr_event = event_num;
            if (curr_event == 0)
            {
                event_text.Text=("You have fallen into the world of OOFGATES... You find a Rock, Sword, & Dagger. Pick One");
                set_buttons(new Button[]{ option4},new Button[] { option1,option2,option3},new string[] {"ROCK","Rusty Sword","Dagger"});
            }
            else if (curr_event == 1)
            {
                event_text.Text = ("A Black Man has approached you with his sword drawn and demands that you give him all your money or die!");
                set_buttons(new Button[] { option3,option4},new Button[] { option1,option2},new string[] {"Attack","Give the Money"});
            }
            else if (curr_event == 2)
            {
                event_text.Text = ("Welcome to Wuhan City, you can go to:");
                set_buttons(new Button[] { },new Button[] { option1,option2,option3},new string[] {"Shop","Forest","Casino","Arena"});
            }
            else
            {
                return false;
            }
            return true;
        }
        private void set_buttons(Button[] inactive_buttons,Button[] active_buttons,string[] texts)
        {
            for (int i = 0; i < active_buttons.Length; i++)
            {
                active_buttons[i].Text = texts[i]; 
                active_buttons[i].Visible=true;
            }
            for (int i=0;i<inactive_buttons.Length;i++)
            {
                inactive_buttons[i].Visible = false;
            }
        }

        private void option1_Click(object sender, EventArgs e)
        {
            if (curr_event == 0)
            {
                user.set_inventory(all_items.get_item(1), 0);
                set(1);
            }
            if (curr_event == 1)
            {
                battle bman_fight = new battle(user,all_players.get_player(0));
            }
        }

        public void set_text_box(TextBox textBox,String[] contam)
        {
            textBox.Clear();
            foreach(String str in contam){
                textBox.AppendText(str+Environment.NewLine);
            }
        }

        private void init_stats(player player)
        {
            set_text_box(stats_text_box,new string[] {
                "Health: "+player.Health,"AD: "+player.Ad,"AP: "+player.Ap,
                "AD Resist: "+player.Ad,"AP Resist:"+player.Ap_resist,
                "Speed: "+player.Speed,"Coins"+player.Coins});

            inventory_info.Clear();
            foreach (item it in player.get_inventory())
            {
                inventory_info.AppendText(Environment.NewLine + it.Name);
            }
        }
        private void init_item_info(object sender, item item)
        {
            item_overview_panel.Visible = true;
            set_text_box(item_overview_textbox,new string[] {
            "Name: "+item.Name,"AD: "+item.Ad,"AP: "+item.Ap,"AD Resist: "+item.Ad,
            "AP Resist: "+item.Ap,"Speed: "+item.Speed,"Ability: "+item.Ability.Name,
                "Durability: "+item.Durability});
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (curr_event == 0)
            {
                user.set_inventory(all_items.get_item(2), 0);
                set(1);
            }
        }

        private void option3_Click(object sender, EventArgs e)
        {
            if (curr_event == 0)
            {
                user.set_inventory(all_items.get_item(3), 0);
                set(1);
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
        private void back_button_Click(object sender, EventArgs e)
        {
            info_panel.Enabled = false;
            info_panel.Visible = false;

            main_panel.Enabled = true;
            main_panel.Visible = true;
        }
        private void update_enemy_energy_bar(int energy, int tot_energy)
        {
            curr_energy_bar.SetBounds(0, 0, (int)Math.Floor((double)energy / tot_energy) * 247, 13);
        }
        private void update_enemy_health_bar(int health, int tot_health)
        {
            enemy_healthbar.SetBounds(0, 0, (int)Math.Floor((double)health / tot_health) * 247, 13);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void damage_label_Click(object sender, EventArgs e)
        {

        }

        private void f_button1_Click(object sender, EventArgs e)
        {

        }

        private void f_button2_Click(object sender, EventArgs e)
        {

        }

        private void f_button3_Click(object sender, EventArgs e)
        {

        }

        private void option1_MouseHover(object sender, EventArgs e)
        {
            if (curr_event == 0)
            {
                init_item_info(option1, all_items.get_item(1));
            }
        }

        private void option1_MouseLeave(object sender, EventArgs e)
        {
            if (curr_event == 0)
            {
                item_overview_panel.Visible = false;
            }
        }
    }
}
