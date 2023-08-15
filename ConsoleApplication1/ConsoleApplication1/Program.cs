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
            string ending = "終了するには何かキーを押してください。";

            Console.Write("科目> ");
            string subject = Console.ReadLine();
            Console.Write("点数> ");
            int score = int.Parse(Console.ReadLine());
            Console.Write("平均点> ");
            double average = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}は{1}点 (平均{2}点)", subject, score, average);


            Console.WriteLine(ending);
            Console.ReadLine();
        }
    }
}