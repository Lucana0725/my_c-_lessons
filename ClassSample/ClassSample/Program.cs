//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ClassSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello world");
        //Console.Read();

        Television tv = new Television();

        Console.WriteLine("10チャンネルを設定します。");
        //tv.SetChanel(10);
        tv.Channel = 10;
        Console.WriteLine("TVは{0}チャンネルです。", tv.Channel);

        Console.WriteLine("チャンネルを+2します。");
        tv.ChannelUp();
        tv.ChannelUp();
        Console.WriteLine("TVは{0}チャンネルです。", tv.Channel);

        Console.WriteLine("チャンネルを-1します。");
        tv.ChannelDown();
        Console.WriteLine("TVは{0}チャンネルです。", tv.Channel);

        Console.WriteLine("終了するにはEnterキーを押して下さい。");
        Console.Read();
    }
}