using System.Collections.Generic;

namespace SCPSL_Framework.Items.Tools
{
    public class Flashlight : Tool
    {
        public Flashlight()
            : base("Flashlight", "Illuminate dark areas", new Dictionary<string, int> { { "batteryLife", 100 } })
        {
        }
    }
}