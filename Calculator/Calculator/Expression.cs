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
            //expression.ToArray();
            char[] operationList = new char[] { '+', '-', '*', '/', '%'};

            int operIndex = expression.IndexOfAny(operationList);
            
            


            return expression;
        
        }
       
    }
}
