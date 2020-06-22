using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyEditor
{
    class AiWillDo
    {
        private string factor;
        private AiModifier[] modifiers;

        public string Factor { get => factor; set => factor = value; }
        internal AiModifier[] Modifiers { get => modifiers; set => modifiers = value; }
    }
}
