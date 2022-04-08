using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    public class player
    {
        public string Name
        {
            get;set;
        }
        public double Level
        {
            get;set;
        }
        public int Health
        {
            get;set;
        }
        public int Ad
        {
            get;set;
        }
        public int Ap
        {
            get;set;
        }
        public int Ad_resist
        {
            get;set;
        }
        public int Ap_resist
        {
            get;set;
        }
        public int Speed
        {
            get;set;
        }
        public int Luck
        {
            get; set;
        }
        public int Coins
        {
            get;set;
        }
        public int Energy
        {
            get;set;
        }

        item[] inventory = new item[4];
        public player(String Name,int Health, int Ad, int Ap, int Ad_resist, int Ap_resist, double Level,
            int Speed, int Luck, int Coins, int Energy,item[] inventory)
        {
            this.Name = Name;
            this.Health = Health;
            this.Ad = Ad;
            this.Ap = Ap;
            this.Ad_resist = Ad_resist;
            this.Ap_resist = Ap_resist;
            this.Level = Level;
            this.Speed = Speed;
            this.Luck = Luck;
            this.Coins = Coins;
            this.Energy = Energy;

            for(int i=0;i<this.inventory.Length;i++)
            {
                set_inventory(inventory[i],i);
            }
        }
        public void set_inventory(item item, int point)
        {
            inventory[point] = item;
            Ad += item.Ad;
            Ap += item.Ap;
            Speed += item.Speed;
            Ad_resist+=item.Ad_resist;
            Ap_resist += item.Ap_resist;
        }
        public void set_inventory(item[] items)
        {
            inventory = items;
        }
        public item[] get_inventory()
        {
            return inventory;
        }
        public item get_inventory_item(int point)
        {
            return inventory[point];
        }
    }
}
