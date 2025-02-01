using System.Collections.Generic;
using SCPSL_Framework.Managers;

namespace SCPSL_Framework.Items.Weapons
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public int Ammo { get; set; }

        public Weapon(string name, int damage, int ammo, Dictionary<string, int> attributes)
            : base(name, "Weapon", attributes)
        {
            Damage = damage;
            Ammo = ammo;
        }
    }
}