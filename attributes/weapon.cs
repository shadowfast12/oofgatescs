using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    internal class weapon
    {
        private String name;
        private int damage, speed, weapon_dur;

        public weapon(String name,int damage,int speed,int weapon_dur)
        {
            this.name = name;
            this.damage = damage;
            this.speed = speed;
            this.weapon_dur = weapon_dur;
        }
        public String get_name()
        {
            return name;
        }
        public int get_damage()
        {
            return damage;
        }
        public int get_speed()
        {
            return speed;
        }
        public int get_weapon_dur()
        {
            return weapon_dur;
        }
    }
}
