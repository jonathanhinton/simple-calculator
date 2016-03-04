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

        public string[] ParseExpression(string expression)
        {

            int operIndex = expression.IndexOfAny(operationList);
            char op = expression[operIndex];
            string[] splitExpression = expression.Split(op);

            string lhs = splitExpression[0];
            string rhs = splitExpression[1];


            return new string[] { lhs, rhs };
        }
       
    }
}
