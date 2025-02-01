using System.Collections.Generic;

namespace SCPSL_Framework.Items.Tools
{
    public class Radio : Tool
    {
        public Radio()
            : base("Radio", "Communicate with team", new Dictionary<string, int> { { "range", 1000 } })
        {
        }
    }
}