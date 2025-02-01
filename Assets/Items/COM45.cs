using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class COM45 : Weapon
    {
        public COM45()
            : base("COM-45", 30, 12, new Dictionary<string, int> { { "fireRate", 300 }, { "extraBullets", 3 } })
        {
        }
    }
}