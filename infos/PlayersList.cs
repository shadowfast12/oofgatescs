using oofgates.attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oofgates.infos
{
    public class PlayersList
    {
        private Dictionary<int, Player> players;

        public PlayersList(String file)
        {
            players = new Dictionary<int, Player>();
            ArrayList info = new ArrayList();

            int num = 0;
            foreach (String it in System.IO.File.ReadLines(file))
            {
                if (it.Contains("#"))
                {
                    players.Add(num, new Player((String)info[0],int.Parse((String)info[1]), int.Parse((String)info[2]), int.Parse((String)info[3]),
                        int.Parse((String)info[4]), int.Parse((String)info[5]), int.Parse((String)info[6]),
                        int.Parse((String)info[7]), int.Parse((String)info[8]),int.Parse((String)info[9]),
                        int.Parse((String)info[10]), int.Parse((String)info[11]),int.Parse((String)info[12]), new Item[]{
                            Main.allItems.get_item(int.Parse((String)info[13])),Main.allItems.get_item(int.Parse((String)info[14])),
                            Main.allItems.get_item(int.Parse((String)info[15])),Main.allItems.get_item(int.Parse((String)info[16]))}));
                    info.Clear();
                    num++;
                }
                else
                {
                    info.Add(it.Split(':')[1]);
                }
            }
        }
        public Player GetPlayer(int num)
        {
            return players[num];
        }
    }
}