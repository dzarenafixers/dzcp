using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class Crossvec : Weapon
    {
        public Crossvec()
            : base("Crossvec", 25, 30, new Dictionary<string, int> { { "fireRate", 800 } })
        {
        }
    }
}