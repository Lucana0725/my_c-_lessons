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


            // 繰り返し処理
            // while文
            //int n, sum = 0;

            //Console.Write("整数値> ");
            //n = int.Parse(Console.ReadLine());

            //while (n > 0)
            //{
            //    sum += n;
            //    Console.Write("整数値> ");
            //    n = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("合計値は{0}です", sum);

            // do while文
            int n, sum = 0;

            do
            {
                Console.Write("整数値> ");
                n = int.Parse(Console.ReadLine());
                sum += n;
            } while (n > 0);

            Console.WriteLine("合計値は{0}です", sum);



        }
    }
}