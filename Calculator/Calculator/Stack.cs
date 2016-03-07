using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Stack
    {
        public int last { get; set; }
        public string lastQ { get; set;}

        public char Constant(string userInput)
        {
            //declare acceptable constants
            string acceptableCons = "abcdefghijklmnopqrstuvwxyz";

            //Find the identity operator
            int identityIndex = userInput.IndexOf('=');

            if (identityIndex == -1)
            {
                throw new InvalidOperationException("Your input does not have the identity operator '=' ");
            }

            //convert user input to lowercase
            string variable = userInput.ToLower();

            //check that the length of the variable is 1...I will need to implement this later because the entire user input will be the string assigning the number to to constant.
            if (variable.Length != 1)
            {
                throw new InvalidOperationException("Constants can only be one character in Length");
            }
            char cons;
            return '=';
        }
    }
}
