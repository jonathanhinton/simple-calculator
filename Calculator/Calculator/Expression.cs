using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Expression
    {
        public char[] operationList = new char[] { '+', '-', '*', '/', '%' };

        public string RemoveSpaces(string equation)
        {
            string expression = equation.Replace(" ", "");
            return expression;
        }

        public Container ParseExpression(string expression)
        {

            int operIndex = expression.IndexOfAny(operationList);
            if (operIndex == -1)
            {
                Console.WriteLine("No valid operator detected");
            }
            char op = expression[operIndex];
            string[] splitExpression = expression.Split(op);
            if (splitExpression.Length != 2)
            {
                Console.WriteLine("I can only do operations on 2 terms");
            }
            Container equation = new Calculator.Container();
            equation.LHS = Convert.ToInt32(splitExpression[0]);
            equation.RHS = Convert.ToInt32(splitExpression[1]);
            equation.OP = op;

            return equation;
        }
       
    }
}
