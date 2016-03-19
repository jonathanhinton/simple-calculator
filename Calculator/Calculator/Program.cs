using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluate my_eval = new Evaluate();
            Terminal user_term = new Terminal();
            Console.WriteLine("type 2 terms you would like me to do some math on. I can add, subtract, multiply, divide, modulo and save constants...maybe");
            Console.WriteLine(user_term.PromptFormat());
            while (true)
            {
                string user_input = Console.ReadLine();
                if (user_input == "exit" || user_input == "quit")
                {
                    Console.WriteLine("bye");
                    Environment.Exit(0);
                } else if (user_input == "last")
                {
                    user_term.Counter++;
                    Console.WriteLine(user_term.PromptFormat() + " Your last answer was {0}", my_eval.LastOutput(user_input));
                } else if (user_input == "lastq")
                {
                    user_term.Counter++;
                    Console.WriteLine(user_term.PromptFormat() + " Your last question was {0}", my_eval.LastInput(user_input));
                } else
                {
                    user_term.Counter++;
                    Console.WriteLine(user_term.PromptFormat() + " the answer is {0}...I think", my_eval.handledIt(user_input));
                }

            }
        }
    }
}
