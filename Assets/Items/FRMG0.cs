using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class FRMG0 : Weapon
    {
        public FRMG0()
            : base("FR-MG-0", 40, 100, new Dictionary<string, int> { { "fireRate", 500 } })
        {
        }
    }
}