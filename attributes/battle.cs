using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    public class Battle
    {
        public Player User {
            get;set;
        }
        public Player Enemy {
            get;set;
        }

        public Battle(Player User, Player Enemy)
        {
            this.User = User;
            this.Enemy = Enemy;
        }
        public String Perform(Player user, Player enemy,Item item)
        {
            item.Durability--;
            user.Energy = user.Energy-item.Ability.Energy;
            enemy.Health = user.Health - item.Ability.DamageOutput(user,enemy);

            return user.Name + "used " + item.Ability + " and dealt " + item.Ability.DamageOutput(user, enemy);
        }
        public void BotAction(Player bot, Player enemy)
        {
            Item curr_item=Main.allItems.get_item(1);
            foreach (Item item in bot.get_inventory())
            {
                if (bot.Energy >= item.Ability.Energy && 
                    item.Ability.DamageOutput(bot,enemy)>curr_item.Ability.DamageOutput(bot,enemy))
                {
                    curr_item = item;
                }
            }
            Perform(bot,enemy,curr_item);
        }
    }
}
