using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    public class player
    {
        private String name;
        private double level;
        private int health, ad, ap, ad_resist, ap_resist, speed, luck, coins, energy;

        item[] inventory = new item[3];
        public player(String name,int health, int ad, int ap, int ad_resist, int ap_resist, double level,
            int speed, int luck, int coins, int energy,item[] inventory)
        {
            this.name = name;
            this.health = health;
            this.ad = ad;
            this.ap = ap;
            this.ad_resist = ad_resist;
            this.ap_resist = ap_resist;
            this.level = level;
            this.speed = speed;
            this.luck = luck;
            this.coins = coins;
            this.energy = energy;

            for(int i=0;i<=this.inventory.Length-1;i++)
            {
                set_inventory(inventory[i],i);
            }
        }
        public void set_name(String name)
        {
            this.name = name;
        }
        public void set_health(int health)
        {
            this.health = health;
        }
        public void set_ad(int ad)
        {
            this.ad = ad;
        }
        public void set_ap(int ap)
        {
            this.ap = ap;
        }
        public void set_ad_resist(int ad_resist)
        {
            this.ad_resist = ad_resist;
        }
        public void set_ap_resist(int ap_resist)
        {
            this.ap_resist = ap_resist;
        }
        public void set_level(int level)
        {
            this.level = level;
        }
        public void set_speed(int speed)
        {
            this.speed = speed;
        }
        public void set_luck(int luck)
        {
            this.luck = luck;
        }
        public void set_coins(int coins)
        {
            this.coins = coins;
        }
        public void set_energy(int energy)
        {
            this.energy = energy;
        }
        public void set_inventory(item item, int point)
        {
            inventory[point] = item;
            set_ad(get_ad() + item.get_ad());
            set_speed(get_speed() + item.get_speed());
            set_ad_resist(get_ad_resist() + item.get_ad_resist());
            set_ap_resist(get_ap_resist() + item.get_ap_resist());
        }
        public void set_inventory(item[] items)
        {
            inventory = items;
        }

        public String get_name()
        {
            return name;
        }
        public int get_health()
        {
            return health;
        }
        public int get_ad()
        {
            return ad;
        }
        public int get_ap()
        {
            return ap;
        }
        public int get_ad_resist()
        {
            return ad_resist;
        }
        public int get_ap_resist()
        {
            return ap_resist;
        }
        public double get_level()
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
        public int get_energy()
        {
            return energy;
        }
        public int get_coins()
        {
            return coins;
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
