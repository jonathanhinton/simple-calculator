using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Expression
    {
        public string UserInput(string equation)
        {
            string express = equation.Replace(" ", "");

            return express;
        }
       
    }
}
