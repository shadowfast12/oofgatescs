using oofgates.attributes;
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
    public partial class Ibattle : UserControl
    {
        private Battle CurrBattle;
        public Ibattle()
        {
            InitializeComponent();
        }

        public void InitBattle(Player user, Player enemy)
        {
            CurrBattle = new Battle(user, enemy);

            Visible = true;
            //main_panel.Visible = false;
            refresh_battle(user, enemy);
        }

        private void refresh_battle(Player user, Player enemy)
        {
            UserNameLabel.Text = user.Name;
            UserLevelLabel.Text = "Lv " + Math.Floor(user.Level).ToString();

            EnemyNameLabel.Text = enemy.Name;
            EnemyLevelLabel.Text = "Lv " + Math.Floor(enemy.Level).ToString();

            AbilityButton1.Text = user.get_inventory_item(0).Ability.Name;
            AbilityButton2.Text = user.get_inventory_item(1).Ability.Name;
            AbilityButton3.Text = user.get_inventory_item(2).Ability.Name;
            AbilityButton4.Text = user.get_inventory_item(3).Ability.Name;

            Ui.UpdateBar(UserCurrHealthBar, user.Health, user.Total_health);
            Ui.UpdateBar(EnemyCurrHealthBar, enemy.Health, enemy.Total_health);

            Ui.UpdateBar(UserCurrEnergyBar, user.Energy, user.Total_energy);
            Ui.UpdateBar(EnemyCurrEnergyBar, enemy.Energy, enemy.Total_energy);
        }
        //curr_battle.bot_action(curr_battle.Enemy, curr_battle.User);
        private void AbilityButton1_Click(object sender, EventArgs e)
        {
            CurrBattle.Perform(CurrBattle.User, CurrBattle.Enemy, CurrBattle.User.get_inventory_item(0));
        }

        private void AbilityButton2_Click(object sender, EventArgs e)
        {
            CurrBattle.Perform(CurrBattle.User, CurrBattle.Enemy, CurrBattle.User.get_inventory_item(2));
        }

        private void AbilityButton3_Click(object sender, EventArgs e)
        {
            CurrBattle.Perform(CurrBattle.User, CurrBattle.Enemy, CurrBattle.User.get_inventory_item(3));
        }

        private void AbilityButton4_Click(object sender, EventArgs e)
        {
            CurrBattle.Perform(CurrBattle.User, CurrBattle.Enemy, CurrBattle.User.get_inventory_item(4));
        }

        private void AbilityButton1_MouseHover(object sender, EventArgs e)
        {
            //init_ability_info(curr_battle.User.get_inventory_item(0).Ability);
        }

        private void AbilityButton2_MouseHover(object sender, EventArgs e)
        {
            //init_ability_info(curr_battle.User.get_inventory_item(1).Ability);
        }

        private void AbilityButton3_MouseHover(object sender, EventArgs e)
        {
            //init_ability_info(curr_battle.User.get_inventory_item(2).Ability);

        }

        private void AbilityButton4_MouseHover(object sender, EventArgs e)
        {
            //init_ability_info(curr_battle.User.get_inventory_item(3).Ability);
        }

        private void BattleAbilityPanel_MouseLeave(object sender, EventArgs e)
        {
            BattleAbilityPanel.Visible = false;
        }
    }
}
