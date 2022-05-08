using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    public class Player
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
        public int Total_health
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
        public int Total_energy
        {
            get;set;
        }

        Item[] inventory = new Item[4];
        public Player(String Name,int Health,int Total_health, int Ad, int Ap, int Ad_resist, int Ap_resist, double Level,
            int Speed, int Luck, int Coins, int Energy, int Total_energy, Item[] inventory)
        {
            this.Name = Name;
            this.Health = Health;
            this.Total_health = Total_health;
            this.Ad = Ad;
            this.Ap = Ap;
            this.Ad_resist = Ad_resist;
            this.Ap_resist = Ap_resist;
            this.Level = Level;
            this.Speed = Speed;
            this.Luck = Luck;
            this.Coins = Coins;
            this.Energy = Energy;
            this.Total_energy = Total_energy;

            for(int i=0;i<this.inventory.Length;i++)
            {
                set_inventory(inventory[i],i);
            }
        }
        public void set_inventory(Item item, int point)
        {
            inventory[point] = item;
            Ad += item.Ad;
            Ap += item.Ap;
            Speed += item.Speed;
            Ad_resist+=item.Ad_resist;
            Ap_resist += item.Ap_resist;
        }
        public void set_inventory(Item[] items)
        {
            inventory = items;
        }
        public Item[] get_inventory()
        {
            return inventory;
        }
        public Item get_inventory_item(int point)
        {
            return inventory[point];
        }
    }
}
