using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Evaluate
    {
        //construct Evaluate when it is called
        public Evaluate()
        {
            //create new instance of Stack class so that it is not null when getting and setting.
            stack_record = new Stack();
        }

        //Allow the instance of stack_record to be set by methods within Evaluate class
        public Stack stack_record { get; set; }

        //The Mother Function
        public int handledIt(string input)
        {
            //declare variable to hold result from operation
            int result = 0;

            //set stack_record so that I can access the last user input
            stack_record.lastQ = input;

            //create new expression class to handle parsing user input
            Expression myExp = new Expression();

            //allow the container to be set from the parseExpression method
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

            //set stack_record result for later access
            stack_record.last = result;
            return result;
        }
    }
}
