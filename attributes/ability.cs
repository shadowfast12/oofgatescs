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
        public string Name
        {
            get;set;
        }
        public string Type
        {
            get;set;
        }
        public int Base_damage
        {
            get;set;
        }
        public int Energy
        {
            get;set;
        }
        public double Ad_scale
        {
            get;set;
        }
        public double Ap_scale
        {
            get;set;
        }
        public ability(String Name, String Type,int Base_damage, int Energy, double Ad_scale,double Ap_scale)
        {
            this.Name = Name;
            this.Type = Type;
            this.Energy = Energy;
            this.Base_damage = Base_damage;
            this.Ap_scale = Ap_scale;
            this.Ad_scale = Ad_scale;
        }
        public int get_total_damage(player user,player enemy)
        {
            return (int)Math.Floor(Base_damage + (user.Ad * Ad_scale) + (user.Ap*Ap_scale) - 
                (enemy.Ad_resist+enemy.Ap_resist));
        }
    }
}
