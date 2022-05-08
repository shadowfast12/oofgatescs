using oofgates.attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.infos
{
    public class ItemList
    {
        private Dictionary<int,Item> items;
        ArrayList info = new ArrayList();

        public ItemList(String file)
        {
            items = new Dictionary<int,Item>();

            int num = 0;
            foreach (String it in System.IO.File.ReadLines(file))
            {
                if (it.Contains("#"))
                {
                    items.Add(num, new Item((String)info[0], int.Parse((String)info[1]), int.Parse((String)info[2]),
                        int.Parse((String)info[3]), int.Parse((String)info[4]), int.Parse((String)info[5]),
                        int.Parse((String)info[6]),Main.allAbilities.GetAbility(int.Parse((String)info[7]))));
                    info.Clear();
                    num++;
                }
                else
                {
                    info.Add(it.Split(':')[1]);
                }

            }
        }

        public Item get_item(int num)
        {
            return items[num];
        } 

    }
}
