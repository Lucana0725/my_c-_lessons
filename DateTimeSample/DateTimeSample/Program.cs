//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DateTimeSample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("今日の日付：" + DateTime.Today);
//            Console.WriteLine("現在の日付と時間：" + DateTime.Now);

//            // 現在の二付と日時を取得する
//            DateTime now = DateTime.Now;

//            Console.WriteLine("年 = " + now.Year);
//            Console.WriteLine("月 = " + now.Month);
//            Console.WriteLine("日 = " + now.Day);
//            Console.WriteLine("時 = " + now.Hour);
//            Console.WriteLine("分 = " + now.Minute);
//            Console.WriteLine("秒 = " + now.Second);
//            Console.WriteLine("曜日 = " + now.DayOfWeek);

//            Console.WriteLine("Enterキーで終了");
//            Console.Read();
//        }

//    }
//}



// こちらの記述でも可
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DateTimeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //dateTimePropertyExample();
            //dateTimeAddExample();
            dateTimeToXxxxXxxxStringExample();
        }

        static void ending()
        {
            Console.WriteLine("終了するには半角でEnterキーを押してください。");
            Console.Read();
        }

        static void dateTimePropertyExample()
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

            ending();
        }

        static void dateTimeAddExample()
        {
            DateTime now = DateTime.Now;                         // 現在の日付を得る
            Console.WriteLine(now);                                   // 現在日時の表示

            TimeSpan addSpan = new TimeSpan(10, 10, 10);  // TimeSpan (時、分、秒)
            DateTime answer = now.Add(addSpan);              // TimeSpanの加算
            Console.WriteLine(answer);

            addSpan = new TimeSpan(1, 1, 1, 1);                // TimeSpan(日、時、分、秒)：要は現在時刻に10時間、10分、10秒を足した日時を出力する

            answer = now.Add(addSpan);
            Console.WriteLine(answer);

            //Console.WriteLine("Enterキーで終了");
            //Console.Read();
            ending();
        }

        // 各書式での日時の出力方法
        static void dateTimeToXxxxXxxxStringExample()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());

            ending();
        }

    }
}


