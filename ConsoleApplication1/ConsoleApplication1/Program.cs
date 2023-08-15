//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ending = "終了するには何かキーを押してください。";

            // break, continue句
            //int n, sum = 0;
            //Console.WriteLine("整数値を10回入力してください。");
            //Console.WriteLine("途中で負の数を入力したら終了します。");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("> ");
            //    n = int.Parse(Console.ReadLine());
            //    if (n < 0)
            //        break;

            //    sum += n;
            //}
            //Console.WriteLine("合計値は{0}です。", sum);


            //int n, div = 1000;

            //Console.WriteLine("整数値を5回入力してください。");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("> ");
            //    n = int.Parse(Console.ReadLine());
            //    if (n == 0)
            //    {
            //        Console.WriteLine("0では割れません。再入力してください。");
            //        continue;
            //    }
            //    Console.Write("{0} / {1} = ", div, n);
            //    div /= n;
            //    Console.WriteLine(div);

            //// whileにて記述
            //int n, div = 1000;

            //Console.WriteLine("整数値を5回入力してください。");

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.Write("> ");
            //    n = int.Parse(Console.ReadLine());
            //    if (n == 0)
            //    {
            //        Console.WriteLine("0では割れません。再入力してください。");
            //        continue;
            //    }
            //    Console.Write("{0} / {1} = ", div, n);
            //    div /= n;
            //    Console.WriteLine(div);
            //    i++;
            //}

            // goto文
            int i, j = 0, k = 0, no = 1;

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    for (k = 1; k <= 10; k++)
                    {
                        no += (i + j + k);
                        if (no >= 2000) goto OUT;
                    }
                }
            }
        OUT:
            Console.WriteLine("i:{0} j:{1} k:{2} no:{3}", i, j, k, no);

            
        
        }
    }
}