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
    public partial class Istats : UserControl
    {
        public Istats()
        {
            InitializeComponent();
        }

        public void ItemInfo(Item item)
        {
            Visible = true;

            var app_pos = PointToClient(Cursor.Position);
            SetBounds(app_pos.X + 4, app_pos.Y + 4, Width,
                Height);

            Ui.SetTextbox(OverviewTextbox, new string[] {
            "Name: "+item.Name,"AD: "+item.Ad,"AP: "+item.Ap,"AD Resist: "+item.Ad,
            "AP Resist: "+item.Ap,"Speed: "+item.Speed,"Ability: "+item.Ability.Name,
                "Durability: "+item.Durability});
        }

        public void AbilityInfo(Ability ability)
        {
            Visible = true;

            var app_pos = PointToClient(Cursor.Position);
            OverviewTextbox.SetBounds(app_pos.X + 4, app_pos.Y + 4, OverviewTextbox.Width,
                OverviewTextbox.Height);
            Ui.SetTextbox(OverviewTextbox, new string[] {"Name: "+ability.Name,
            "Energy: "+ability.Energy,"Base Dmg: "+ability.BaseDamage,"AD Scale: "+ability.AdScale,
            "AP Scale: "+ability.ApScale,"Total Damage: "+ability.TotalDamage(Main.User)});
        }

    }
}
