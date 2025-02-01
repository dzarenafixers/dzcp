using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class COM15 : Weapon
    {
        public COM15()
            : base("COM-15", 20, 12, new Dictionary<string, int> { { "fireRate", 400 } })
        {
        }
    }
}