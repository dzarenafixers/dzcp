using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class COM18 : Weapon
    {
        public COM18()
            : base("COM-18", 25, 15, new Dictionary<string, int> { { "fireRate", 450 } })
        {
        }
    }
}