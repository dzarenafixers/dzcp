using System.Collections.Generic;

namespace SCPSL_Framework.Items.Weapons
{
    public class MTF_E11_SR : Weapon
    {
        public MTF_E11_SR()
            : base("MTF-E11-SR", 100, 30, new Dictionary<string, int> { { "fireRate", 600 } })
        {
        }
    }
}