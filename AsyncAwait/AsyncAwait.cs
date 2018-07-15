﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
     class AsyncAwait
        {
            static void Main(string[] args)
            {
                Method1();
                Method2();
                Console.ReadKey();
            }

            public static async Task Method1()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(" Method 1");
                    }
                });
            }

            public static void Method2()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 2");
                }
            }
        }
    }
