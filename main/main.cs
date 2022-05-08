using oofgates.attributes;
using oofgates.infos;
using System;
using System.Windows.Forms;

namespace oofgates
{
    public partial class Main : Form
    {
        public static int CurrEvent;
        public static Player User;

        public static AbilityList allAbilities;
        public static ItemList allItems;
        public static PlayersList allPlayers;
        public Main()
        {
            InitializeComponent();

            allAbilities = new AbilityList("res\\abilities.oof");
            allItems = new ItemList("res\\items.oof");
            allPlayers = new PlayersList("res\\players.oof");

            User = allPlayers.GetPlayer(1);
        }

    }
}
