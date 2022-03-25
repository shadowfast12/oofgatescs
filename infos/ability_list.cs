using oofgates.attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.infos
{
    public class ability_list
    {
        private Dictionary<int, ability> abilities;

        public ability_list(String file)
        {
            abilities = new Dictionary<int, ability>();

            int num = 1;
            foreach (String it in System.IO.File.ReadLines(file))
            {
                String[] arr = it.Split(':');
                abilities.Add(num, new ability(arr[0],arr[1],int.Parse(arr[2]),int.Parse(arr[3]),double.Parse(arr[4]),double.Parse(arr[5])));
                num++;
            }

        }
        public ability get_ability(int num)
        {
            return abilities[num];
        }

    }
}
