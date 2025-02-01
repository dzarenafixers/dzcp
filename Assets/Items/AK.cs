using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class AK : Weapon
    {
        public AK()
            : base("AK", 35, 30, new Dictionary<string, int> { { "fireRate", 650 } })
        {
        }
    }
}