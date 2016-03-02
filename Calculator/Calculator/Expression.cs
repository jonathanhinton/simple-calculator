using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Expression
    {
        public string ParseExpression(string equation)
        {
            string expression = equation.Replace(" ", "");
            expression.ToArray();
            char[] operation = { '+', '-', '*', '/', '%'};
            foreach (char element in expression)
            {
                expression.Split(element);
            }

            return expression;
        
        }
       
    }
}
