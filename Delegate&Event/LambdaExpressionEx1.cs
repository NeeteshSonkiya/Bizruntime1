using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class LambdaExpressionEx1
    {

        delegate void Procedure(string text);
            static Procedure someProcs = null;

        private static void AddProc()
        {
            int variable = 100;

            someProcs += new Procedure((string text) => Console.WriteLine(text + ", " + variable.ToString()));
        }
       static void Main()
        {
                someProcs += new Procedure(delegate (string text) { Console.WriteLine(text); });
                AddProc();
                someProcs("testing");
                Console.ReadKey();
        }
    }
}

