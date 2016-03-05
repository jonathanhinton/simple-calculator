using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Expression
    {
        //make char array of operators available to all methods
        public char[] operationList = new char[] { '+', '-', '*', '/', '%' };

        
        public string RemoveSpaces(string input)
        {
            string spaceless = input.Replace(" ", "");
            return spaceless;
        }
        

        public Container ParseExpression(string expression)
        {
            string equation = expression.Replace(" ", "");
            int operIndex = equation.IndexOfAny(operationList);
            if (operIndex == -1)
            {
                Console.WriteLine("No valid operator detected");
            }
            char op = equation[operIndex];
            string[] splitExpression = expression.Split(op);
            if (splitExpression.Length != 2)
            {
                Console.WriteLine("I can only do operations on 2 terms");
            }
            Container parsed_equation = new Calculator.Container();
            parsed_equation.LHS = Convert.ToInt32(splitExpression[0]);
            parsed_equation.RHS = Convert.ToInt32(splitExpression[1]);
            parsed_equation.OP = op;

            return parsed_equation;
        }
       
    }
}
