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
            item.set_durability(item.get_durability()-1);
            user.set_energy(user.get_energy()-item.get_ability().get_energy());
            enemy.set_health(user.get_health()-item.get_ability().get_energy());
        }
        private void bot_action(player bot,player enemy)
        {
            item curr_item=Main.all_items.get_item(1);
            foreach (item item in bot.get_inventory())
            {
                if (bot.get_energy() >= item.get_ability().get_energy() && 
                    item.get_ability().get_total_damage(bot,enemy)>curr_item.get_ability().get_total_damage(bot,enemy))
                {
                    curr_item = item;
                }
            }
            perform(bot,enemy,curr_item);
        }
    }
}
