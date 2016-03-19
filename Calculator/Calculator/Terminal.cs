using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Terminal
    {
        public int Counter { get; set; }
        public Terminal()
        {
            Counter = 0;
        }

        public string PromptFormat()
        {
            return String.Format("[{0}]>", Counter);
        }
    }
}
