using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Evaluate
    {
        public int handledIt(string input)
        {
            int what = 0;
            Expression myExp = new Expression();
            Container answer = myExp.ParseExpression(input);
            int lhs = answer.LHS;
            int rhs = answer.RHS;
            char op = answer.OP;
            if (op == '+')
            {
                Add add_me = new Add();
                what = add_me.addIt(lhs, rhs);
            }
            else if (op == '-')
            {
                Subtract subtract_me = new Subtract();
                what = subtract_me.subtractIt(lhs, rhs);
            }
            else if (op == '*')
            {
                Multiply multiply_me = new Multiply();
                what = multiply_me.multiplyIt(lhs, rhs);
            }
            else if (op == '/')
            {
                Divide divide_me = new Divide();
                what = divide_me.divideIt(lhs, rhs);
            }
            else if (op == '%')
            {
                Modulo modulo_me = new Modulo();
                what = modulo_me.moduloIt(lhs, rhs);
            }
            else
            {
                throw new InvalidOperationException("no valid operator found");
            }
            return what;
        }
    }
}
