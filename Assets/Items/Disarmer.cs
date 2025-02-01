using System.Collections.Generic;

namespace SCPSL_Framework.Items.Tools
{
    public class Disarmer : Tool
    {
        public Disarmer()
            : base("Disarmer", "Disarm enemies", new Dictionary<string, int> { { "effectiveness", 80 } })
        {
        }
    }
}