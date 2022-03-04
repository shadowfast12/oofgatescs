using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    internal class player
    {
        int health, damage, armor, level, speed, luck, coins, exp;

        Object[] inventory=new Object[4];
        public player(int health,int damage,int armor,int level,int speed,int luck,int coins)
        {
            this.health = health;
            this.damage = damage;
            this.armor = armor;
            this.level = level;
            this.speed = speed;
            this.luck = luck;
            this.coins = coins;
            exp = 0;
        }
        public player(int health,int damage,int armor,int coins) {
            this.health = health;
            this.damage = damage;
            this.armor = armor;
            this.coins = coins;
        }

        public void set_health(int health)
        {
            this.health = health;
        }
        public void set_damage(int damage)
        {
            this.damage = damage;
        }
        public void set_armor(int armor)
        {
            this.armor=armor;
        }
        public void set_level(int level)
        {
            this.level=level;
        }
        public void set_speed(int speed)
        {
            this.speed=speed;
        }
        public void set_luck(int luck)
        {
            this.luck=luck;
        }
        public void set_coins(int coins)
        {
            this.coins=coins;
        }
        public void set_exp(int exp)
        {
            this.exp=exp;
        }
        public void set_inventory(Object ob,int point)
        {
            inventory[point]=ob;
        }
        public void set_inventory(Object[] ob)
        {
            inventory = ob;
        }

        public int get_health()
        {
            return health;
        }
        public int get_damage()
        {
            return damage;
        }
        public int get_armor()
        {
            return armor;
        }
        public int get_level()
        {
            return level;
        }
        public int get_speed()
        {
            return speed;
        }
        public int get_luck()
        {
            return luck;
        }
        public int get_coins()
        {
            return coins;
        }
        public int get_exp()
        {
            return exp;
        }
        public object[] get_inventory()
        {
            return inventory;
        }
        public object get_inventory_item(int point)
        {
            return inventory[point];
        }
    }
}
