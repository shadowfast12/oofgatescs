using oofgates.attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.infos
{
    public class AbilityList
    {
        private Dictionary<int, Ability> abilities;

        public AbilityList(String file)
        {
            abilities = new Dictionary<int, Ability>();
            ArrayList info = new ArrayList();

            int num = 0;
            foreach (String it in System.IO.File.ReadLines(file))
            {
                if (it.Contains("#"))
                {
                    abilities.Add(num, new Ability((String)info[0], (String)info[1], int.Parse((String)info[2]),
                        int.Parse((String)info[3]), double.Parse((String)info[4]), double.Parse((String)info[5])));
                    info.Clear();
                    num++;
                }
                else
                {
                    info.Add(it.Split(':')[1]);
                }

            }


        }
        public Ability GetAbility(int num)
        {
            return abilities[num];
        }

    }
}
