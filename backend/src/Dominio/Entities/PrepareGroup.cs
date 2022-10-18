using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PrepareGroup
    {
        public PrepareGroup(string goupName)
        {
            GoupName = goupName;
        }

        public string GoupName { get; set; }
        public IList<string> Steps { get; set; }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }
    }
}
