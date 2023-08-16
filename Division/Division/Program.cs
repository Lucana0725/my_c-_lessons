//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string yn;

        do
        {
            Console.WriteLine("処理を続けますか？ \'y\' / \'n\'");
            yn = Console.ReadLine();
        } while (yn == "y" || yn == "Y");

        Console.WriteLine("終了するには何かキーを押してください。");
        Console.Read();
    }
}