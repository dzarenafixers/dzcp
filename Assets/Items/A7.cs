using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class A7 : Weapon
    {
        public A7()
            : base("A7", 30, 20, new Dictionary<string, int> { { "fireRate", 600 } })
        {
        }
    }
}