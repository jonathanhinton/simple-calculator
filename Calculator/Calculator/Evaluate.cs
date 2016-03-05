using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Evaluate
    {
        public Container handledIt(int LHS, int RHS)
        {
            Container answer = new Container();
            if (answer.OP == '+')
            {
                Add add_me = new Add();
                int solution = add_me.equation(answer.LHS, answer.RHS);
            }
            return answer;
        }
    }
}
