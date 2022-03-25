using oofgates.attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.infos
{
    public class item_list
    {
        private Dictionary<int,item> items;
        public item_list(String file)
        {
            items = new Dictionary<int,item>();

            int num = 1;
            foreach(String it in System.IO.File.ReadLines(file))
            {
                String[] arr = it.Split(':');
                items.Add(num,new item(arr[0],int.Parse(arr[1]),int.Parse(arr[2]),
                    int.Parse(arr[3]),int.Parse(arr[4]), int.Parse(arr[5]), int.Parse(arr[6]),
                    new Object[] {
                        Main.all_abilities.get_ability(int.Parse(arr[7])),
                    Main.all_abilities.get_ability(int.Parse(arr[8])),Main.all_abilities.get_ability(int.Parse(arr[9])),
                    Main.all_abilities.get_ability(int.Parse(arr[10]))}));
                num++;
            }
        }

        public item get_item(int num)
        {
            return items[num];
        }

    }
}
