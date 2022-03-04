using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    internal class fight
    {
        public Boolean charge(player user,player enemy,int luck)
        {
            if (luck > 2)
            {
                enemy.set_health(enemy.get_health()-user.get_damage());
                return true;
            }
            return false;
        }
        public int block(player user,int extra)
        {
            return user.get_armor()+extra;
        }
    }
}
