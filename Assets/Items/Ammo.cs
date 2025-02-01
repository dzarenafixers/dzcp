using System.Collections.Generic;

namespace SCPSL_Framework.Items.Misc
{
    public class Ammo : MiscItem
    {
        public Ammo(string type, int amount)
            : base("Ammo", $"Type: {type}, Amount: {amount}", new Dictionary<string, int> { { "amount", amount } })
        {
        }
    }
}