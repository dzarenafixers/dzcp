using System.Collections.Generic;

namespace SCPSL_Framework.Items.Misc
{
    public class Coin : MiscItem
    {
        public Coin()
            : base("Coin", "A simple coin", new Dictionary<string, int> { { "value", 1 } })
        {
        }
    }
}