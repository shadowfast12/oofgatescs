using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    internal class item
    {
        private String name;
        private int damage, speed, durability,armor;

        public item(String name,int damage,int speed,int durability,int armor)
        {
            this.name = name;
            this.damage = damage;
            this.speed = speed;
            this.durability = durability;
            this.armor = armor;
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
        public int get_durability()
        {
            return durability;
        }
        public int get_armor()
        {
            return armor;
        }
    }
}
