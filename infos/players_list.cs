using oofgates.attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.infos
{
    public class players_list
    {
        private Dictionary<int, player> players;

        public players_list(String file)
        {
            players = new Dictionary<int, player>();
            ArrayList info = new ArrayList();
            //13
            int num = 0;
            foreach (String it in System.IO.File.ReadLines(file))
            {
                if (it.Contains("#"))
                {

                    players.Add(num, new player((String)info[0],int.Parse((String)info[1]), int.Parse((String)info[2]),
                        int.Parse((String)info[3]), int.Parse((String)info[4]), int.Parse((String)info[5]),
                        int.Parse((String)info[6]), int.Parse((String)info[7]),int.Parse((String)info[8]),
                        int.Parse((String)info[9]), int.Parse((String)info[10]), new item[]{
                            Main.all_items.get_item(int.Parse((String)info[11])),Main.all_items.get_item(int.Parse((String)info[12])),
                            Main.all_items.get_item(int.Parse((String)info[13])),Main.all_items.get_item(int.Parse((String)info[14]))}));
                    info.Clear();
                    num++;
                }
                else
                {
                    info.Add(it.Split(':')[1]);
                }

            }
        }
        public player get_player(int num)
        {
            return players[num];
        }
    }
}
