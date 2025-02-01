using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class FSP9 : Weapon
    {
        public FSP9()
            : base("FSP-9", 28, 20, new Dictionary<string, int> { { "fireRate", 750 } })
        {
        }
    }
}