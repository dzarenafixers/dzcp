using System.Collections.Generic;

namespace SCPSL_Framework.Items.Meds
{
    public class Painkillers : Med
    {
        public Painkillers()
            : base("Painkillers", 25, new Dictionary<string, int> { { "duration", 30 } })
        {
        }
    }
}