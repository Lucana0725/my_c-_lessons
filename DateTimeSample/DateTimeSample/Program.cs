//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateTimeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Console.WriteLine("Hello world");
                Console.WriteLine("今日の日付：" + DateTime.Today);
                Console.WriteLine("現在の日付と時間：" + DateTime.Now);

                // 現在の二付と日時を取得する
                DateTime now = DateTime.Now;

                Console.WriteLine("年 = " + now.Year);
                Console.WriteLine("月 = " + now.Month);
                Console.WriteLine("日 = " + now.Day);
                Console.WriteLine("時 = " + now.Hour);
                Console.WriteLine("分 = " + now.Minute);
                Console.WriteLine("秒 = " + now.Second);
                Console.WriteLine("曜日 = " + now.DayOfWeek);

                Console.WriteLine("Enterキーで終了");
                Console.Read();
            }
        }
    }

}



////// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

////namespace DateTimeSample
////{
//    class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("今日の日付：" + DateTime.Today);
//        Console.WriteLine("現在の日付と日時：" + DateTime.Now);

//        // 現在の日付と日時を取得する
//        DateTime now = DateTime.Now;

//        Console.WriteLine("年 = " + now.Year);
//        Console.WriteLine("月 = " + now.Month);
//        Console.WriteLine("日 = " + now.Day);
//        Console.WriteLine("時 = " + now.Hour);
//        Console.WriteLine("分 = " + now.Minute);
//        Console.WriteLine("秒 = " + now.Second);
//        Console.WriteLine("曜日 = " + now.DayOfWeek);

//    }
//}
////}
