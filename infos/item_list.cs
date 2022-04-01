using oofgates.attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.infos
{
    public class item_list
    {
        private Dictionary<int,item> items;
        ArrayList info = new ArrayList();

        public item_list(String file)
        {
            items = new Dictionary<int,item>();

            int num = 0;
            foreach (String it in System.IO.File.ReadLines(file))
            {
                if (it.Equals("#"))
                {
                    items.Add(num, new item((String)info[0], int.Parse((String)info[1]), int.Parse((String)info[2]),
                        int.Parse((String)info[3]), int.Parse((String)info[4]), int.Parse((String)info[5]),
                        int.Parse((String)info[6]),Main.all_abilities.get_ability(int.Parse((String)info[7]))));
                    info.Clear();
                    num++;
                }
                else
                {
                    info.Add(it.Split(':')[1]);
                }

            }
        }

        public item get_item(int num)
        {
            return items[num];
        } 

    }
}
