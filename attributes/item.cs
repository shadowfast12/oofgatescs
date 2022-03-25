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
        private Object[] abilities;

        public item(String name,int ad,int ap, int speed,int durability,int ad_resist,int ap_resist,Object[] abilities)
        {
            this.name = name;
            this.ad = ap;
            this.speed = speed;
            this.durability = durability;
            this.ad_resist = ad_resist;
            this.ap_resist = ap_resist;
            this.abilities = abilities;
        }
        public item(String name, int ad,int ap, int speed, int durability, int ad_resist, int ap_resist)
        {
            this.name = name;
            this.ad = ad;
            this.ap=ap;
            this.speed = speed;
            this.durability = durability;
            this.ad_resist = ad_resist;
            this.ap_resist = ap_resist;
        }
        public void set_ad(int ad)
        {
            this.ad=ad;
        }
        public void set_ap(int ap)
        {
            this.ap= ap;
        }
        public void set_ability(ability ability,int num)
        {
            this.abilities[num] = ability;
        }
        
        public ability get_ability(int num)
        {
            return (ability)abilities[num];
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
