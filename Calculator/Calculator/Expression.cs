﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Expression
    {
        //make char array of operators available to all methods
        public char[] operationList = new char[] { '+', '-', '*', '/', '%', '='};

        //create method to prove I can remove spaces
        public string RemoveSpaces(string input)
        {
            string spaceless = input.Replace(" ", "");
            return spaceless;
        }
        
        //create method to hold results from  expression input
        public Container ParseExpression(string expression)
        {
            string equation = expression.Replace(" ", "");
            int operIndex = equation.IndexOfAny(operationList);

            //Check for valid operator
            if (operIndex == -1)
            {
                throw new InvalidOperationException("No valid operator detected");
            }

            char op = equation[operIndex];
            string[] splitExpression = equation.Split(op);

            //evaluate number of terms in array, if greater than or less than 2 or if either index of the array contains an empty string, throw error message
            if (splitExpression.Length != 2 || splitExpression[0] == "" || splitExpression[1] == "")
            {
                throw new InvalidOperationException("I can only do operations on 2 terms");
            }

            //store results from input expression into Container class
            if (op == '=')
            {
                string constant = splitExpression[0].ToLower();
                Container parsed_equation = new Container();
                parsed_equation.CONS = constant;
                parsed_equation.RHS = Convert.ToInt32(splitExpression[1]);
                parsed_equation.OP = op;
                return parsed_equation;
            } else
            {
                Container parsed_equation = new Container();
                parsed_equation.LHS = Convert.ToInt32(splitExpression[0]);
                parsed_equation.RHS = Convert.ToInt32(splitExpression[1]);
                parsed_equation.OP = op;
                return parsed_equation;
            }

        }
       
    }
}
