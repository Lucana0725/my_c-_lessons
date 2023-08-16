﻿//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2;  // 割られる数n1, 割る数n2
        string yn;

        do
        {
            try
            {
                Console.Write("割られる数> ");
                n1 = int.Parse(Console.ReadLine());
                do
                {
                    Console.Write("割る数> ");
                    n2 = int.Parse(Console.ReadLine());
                    if (n2 == 0)
                    {
                        Console.WriteLine("0では割れません。再入力してください。");
                        continue;
                    }
                    Console.Write("{0} / {1} = ", n1, n2);
                    if (n1 < 0 && n2 > 0)
                    {
                        Console.Write("-");
                        n1 = -n1;
                    }
                    else if (n1 > 0 && n2 < 0)
                    {
                        Console.Write("-");
                        n2 = -n2;
                    }
                    Console.Write(n1 / n2);
                } while (n2 == 0);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                break;
            }

            int remainder;
            for (int i = 1; i <= 50; i++)
            {
                remainder = n1 % n2;
                if (remainder == 0)
                    break;
                n1 = remainder * 10;
                if (i == 1)
                    Console.Write('.');
                Console.Write(n1 / n2);
            }
            Console.Write('\n');


            Console.WriteLine("処理を続けますか？ \'y\' / \'n\'");
            yn = Console.ReadLine();
        } while (yn == "y" || yn == "Y");

        Console.WriteLine("終了するには何かキーを押してください。");
        Console.Read();
    }
}