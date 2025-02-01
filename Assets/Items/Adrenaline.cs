using System.Collections.Generic;

namespace SCPSL_Framework.Items.Meds
{
    public class Adrenaline : Med
    {
        public Adrenaline()
            : base("Adrenaline", 50, new Dictionary<string, int> { { "boost", 10 } })
        {
        }
    }
}