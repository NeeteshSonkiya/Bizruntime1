using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SwitchEx5
    {
        static void Main()
        {
            string value = "turnip";
            // ... Switch on the string.
            switch (value)
            {
                case "lettuce":
                    Console.WriteLine("LETTUCE");
                    break;
                case "squash":
                    Console.WriteLine("SQUASH");
                    break;
                case "turnip":
                    Console.WriteLine("TURNIP");
                    break;
            }
            Console.Read();
        }
    }
}