using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    public class ability
    {
        //types: AP AD
        private String name, type;
        private int energy,base_damage;
        private double ad_scale, ap_scale;
        public ability(String name, String type,int base_damage, int energy, double ad_scale,double ap_scale)
        {
            this.name = name;
            this.type = type;
            this.energy = energy;
            this.base_damage = base_damage;
            this.ap_scale = ap_scale;
            this.ad_scale = ad_scale;
        }
        public String get_name()
        {
            return name;
        }
        public String get_type()
        {
            return type;
        }
        public int get_energy()
        {
            return energy;
        }
        public int get_base_damage()
        {
            return base_damage;
        }
        public int get_total_damage(player user,player enemy)
        {
            return (int)Math.Floor(base_damage + (user.get_ad() * ad_scale) + (user.get_ap()*ap_scale) - 
                (enemy.get_ad_resist()+enemy.get_ap_resist()));
        }
    }
}
