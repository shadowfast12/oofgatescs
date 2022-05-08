using oofgates.attributes;
using oofgates.func;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oofgates.main
{
    public partial class Iuserinfo : UserControl
    {
        public Iuserinfo()
        {
            InitializeComponent();
        }

        private void InitStats(Player player)
        {
            Ui.SetTextbox(StatsTextbox, new string[] {
                "Health: "+player.Health,"AD: "+player.Ad,"AP: "+player.Ap,
                "AD Resist: "+player.Ad,"AP Resist:"+player.Ap_resist,
                "Speed: "+player.Speed,"Coins"+player.Coins});

            InventoryInfoTextbox.Clear();
            foreach (Item it in player.get_inventory())
            {
                InventoryInfoTextbox.AppendText(Environment.NewLine + it.Name);
            }
        }

    }

}
