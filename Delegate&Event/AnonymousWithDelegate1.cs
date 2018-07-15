using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class AnonymousWithDelegate1
    {
    public delegate void Procedure();
        
        static Procedure someProcs = null;

        private static void AddProc()
        {
            int variable = 100;

            someProcs += new Procedure(delegate
            {
                Console.WriteLine(variable);
            });
        }

        static void Main()
        {
            someProcs += new Procedure(delegate { Console.WriteLine("test"); });
            AddProc();
            someProcs();
            Console.ReadKey();
            Console.Read();
        }
    }
}

