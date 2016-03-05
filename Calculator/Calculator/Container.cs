using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Container
    {
        public int LHS { get; set; }
        public int RHS { get; set; }
        public char OP { get; set; }

        public int add_me(int LHS, int RHS)
        {
            return LHS + RHS;
        }

        public int subtract_me(int LHS, int RHS)
        {
            return LHS - RHS;
        }

        public int multiply_me(int LHS, int RHS)
        {
            return LHS * RHS;
        }

        public int divide_me(int LHS, int RHS)
        {
            return LHS / RHS;
        }

        public int modulo_me(int LHS, int RHS)
        {
            return LHS % RHS;
        }
    }
}
