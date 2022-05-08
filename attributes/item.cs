using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    public class Item
    {
        public String Name
        {
            get; set;
        }
        public int Ad
        {
            get; set;
        }
        public int Ap
        {
            get; set;
        }
        public int Speed
        {
            get; set;
        }
        public int Durability
        {
            get; set;
        }
        public int Ad_resist
        {
            get; set;
        }
        public int Ap_resist
        {
            get; set;
        }
        public Ability Ability
        {
            get; set;
        }

        public Item(String Name, int Ad, int Ap, int Speed, int Durability, int Ad_resist, int Ap_resist, Ability Ability)
        {
            this.Name = Name;
            this.Ad = Ad;
            this.Ap = Ap;
            this.Speed = Speed;
            this.Durability = Durability;
            this.Ad_resist = Ad_resist;
            this.Ap_resist = Ap_resist;
            this.Ability = Ability;
        }

    }
}
