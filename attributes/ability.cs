using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.attributes
{
    public class Ability
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
        public int BaseDamage
        {
            get;set;
        }
        public int Energy
        {
            get;set;
        }
        public double AdScale
        {
            get;set;
        }
        public double ApScale
        {
            get;set;
        }
        public Ability(String Name, String Type,int BaseDamage, int Energy, double AdScale, double ApScale)
        {
            this.Name = Name;
            this.Type = Type;
            this.Energy = Energy;
            this.BaseDamage = BaseDamage;
            this.AdScale = AdScale;
            this.ApScale = ApScale;
        }
        public int TotalDamage(Player user)
        {
            return (int)Math.Floor(BaseDamage + (user.Ad * AdScale) + (user.Ap * ApScale));
        }
        public int DamageOutput(Player user, Player enemy)
        {
            return (int)Math.Floor(BaseDamage + ((user.Ad * AdScale) - enemy.Ad_resist) +
                ((user.Ap * ApScale) - enemy.Ap_resist));
        }
    }
}
