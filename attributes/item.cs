using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    public class item
    {
        private String name;
        private int ap,ad, speed,durability,ad_resist,ap_resist;
        private ability ability;

        public item(String name,int ad,int ap, int speed,int durability,int ad_resist,int ap_resist,ability ability)
        {
            this.name = name;
            this.ad = ad;
            this.ap = ap;
            this.speed = speed;
            this.durability = durability;
            this.ad_resist = ad_resist;
            this.ap_resist = ap_resist;
            this.ability = ability;
        }
        public void set_ad(int ad)
        {
            this.ad=ad;
        }
        public void set_ap(int ap)
        {
            this.ap= ap;
        }
        public void set_durability(int durability)
        {
            this.durability=durability;
        }
        public void set_ability(ability ability)
        {
            this.ability = ability;
        }
        
        public ability get_ability()
        {
            return ability;
        }
        public String get_name()
        {
            return name;
        }
        public int get_ad()
        {
            return ad;
        }
        public int get_ap()
        {
            return ap;
        }
        public int get_speed()
        {
            return speed;
        }
        public int get_durability()
        {
            return durability;
        }
        public int get_ad_resist()
        {
            return ad_resist;
        }
        public int get_ap_resist()
        {
            return ap_resist;
        }
    }
}
