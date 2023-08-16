////// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("    * * * 九九の表 * * *");
//        Console.Write("    | ");
//        for (int i = 1; i <= 9; i++)
//        {
//            Console.Write(" " + i + " ");
//        }
//        //Console.WriteLine('\n');
//        Console.WriteLine();
//        Console.WriteLine("---------------------------------");
//        //for (int i = 1; i <= 9; i++)
//        //{
//        //    for (int j = 1; j <= 9; j++)
//        //    {
//        //        //Console.Write(i + "   |  " + (i * j));
//        //        Console.WriteLine(i);
//        //    }
//        //}

//        for (int i = 1; i <= 9; i++)
//        {
//            Console.WriteLine(i + "  |  ");

//            //for (int j = 1; j <= 9; j++)
//            //{

//            //}
//        }



//    }
//}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //for (int i = 1; i <= 9; i++)
        //{
        //    //Console.Write(i + " ");
        //    for (int j = 1; j <= 9; j++)
        //    {
        //        Console.WriteLine(i + "(i)行目の" + j + "(j)");
        //    }
        //}

        for (int i = 1; i <= 9; i++)
        {
            Console.Write(i + " ");
            for (int j = 1; j <= 9; j++)
            {
                Console.Write(" " + j * i);
            }
            Console.WriteLine();
        }
    }
}