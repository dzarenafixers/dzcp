using System.Collections.Generic;

namespace SCPSL_Framework.Managers
{
    public class Tool : Item
    {
        public string Function { get; set; }

        public Tool(string name, string function, Dictionary<string, int> attributes)
            : base(name, "Tool", attributes)
        {
            Function = function;
        }
    }
}