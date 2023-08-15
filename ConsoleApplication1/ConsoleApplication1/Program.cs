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
            //Console.WriteLine("これがコンソールアプリケーションです。");

            //Console.WriteLine("終了するには何かキーを押してください。");
            //Console.Read();

            //int a = 10;
            //string s = "こんにちは";

            //Console.Write(a);
            //Console.WriteLine(s);
            ////Console.WriteLine(s + "、aの値は" + a + "です。");
            //Console.WriteLine("{0}、aの値は{1}です。", s, a);

            Console.WriteLine("{0:C}", 1000);
            Console.WriteLine("{0:X}", 250);
            Console.WriteLine("{0:N}", 25000000);
            Console.WriteLine("{0:F3}", 123.45678);
            Console.WriteLine("{0:P}", 2.0/3.0);



            Console.WriteLine(ending);
            Console.ReadLine();
        }
    }
}