using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Evaluate
    {
        public Evaluate()
        {
            stack_record = new Stack();
        }
        public Stack stack_record { get; set; }

        public int handledIt(string input)
        {
            //declare variable to hold result from operation
            int result = 0;

            
           // Stack stack_access = new Stack();
            stack_record.lastQ = input;
            Expression myExp = new Expression();
            Container answer = myExp.ParseExpression(input);

            //shorthand the variables from Container class
            int lhs = answer.LHS;
            int rhs = answer.RHS;
            char op = answer.OP;

            //run the operator logic
            if (op == '+')
            {
                Add add_me = new Add();
                result = add_me.addIt(lhs, rhs);
            }
            else if (op == '-')
            {
                Subtract subtract_me = new Subtract();
                result = subtract_me.subtractIt(lhs, rhs);
            }
            else if (op == '*')
            {
                Multiply multiply_me = new Multiply();
                result = multiply_me.multiplyIt(lhs, rhs);
            }
            else if (op == '/')
            {
                Divide divide_me = new Divide();
                result = divide_me.divideIt(lhs, rhs);
            }
            else if (op == '%')
            {
                Modulo modulo_me = new Modulo();
                result = modulo_me.moduloIt(lhs, rhs);
            }
            else
            {
                throw new InvalidOperationException("no valid operator found");
            }
            stack_record.last = result;
            return result;
        }
    }
}
