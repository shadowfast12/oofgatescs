using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    public class battle
    {
        player user, enemy;

        public battle(player user,player enemy)
        {
            this.user = user;
            this.enemy = enemy;
        }
        private void perform(player user,player enemy,item item)
        {
            item.Durability--;
            user.Energy = user.Energy-item.Ability.Energy;
            enemy.Health = user.Health - item.Ability.get_total_damage(user,enemy);
        }
        private void bot_action(player bot,player enemy)
        {
            item curr_item=Main.all_items.get_item(1);
            foreach (item item in bot.get_inventory())
            {
                if (bot.Energy >= item.Ability.Energy && 
                    item.Ability.get_total_damage(bot,enemy)>curr_item.Ability.get_total_damage(bot,enemy))
                {
                    curr_item = item;
                }
            }
            perform(bot,enemy,curr_item);
        }
    }
}
