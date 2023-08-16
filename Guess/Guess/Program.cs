//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int ans = 72;
            //int num;

            //do
            //{
            //    Console.Write("0から100の間の数値を当ててください。> ");
            //    num = int.Parse(Console.ReadLine());

            //    if (num > ans)
            //    {
            //        Console.WriteLine("答えはもっと小さいです。");
            //        Console.WriteLine();

            //        Console.WriteLine("0から" + (num - 1) + "までの数値を当ててください。");
            //        num = int.Parse(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("答えはもっと大きいです。");
            //        Console.WriteLine();

            //        Console.WriteLine((num + 1) + "から")
            //    }


            //} while (num == ans);

            const int ans = 28;
            int high = 100, low = 0;
            int n, count = 1;

            do  // do whileを使い、最初の一度は必ず実行し、且つ条件がtrue(n!=ans)の間ループし続ける。
            {
                while (true)  // whileを使い、条件がtrueの間処理を続ける
                {
                    try  // 例外処理
                    {
                        Console.WriteLine("{0}から{1}の間の数値を当ててください。", low, high);
                        n = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto END;  // エラーの場合、ENDまで飛ばして二重ループを一気に抜ける
                    }
                    if (n >= low && n <= high)
                        break;
                    else
                        Console.WriteLine("入力値が正しくありません。再入力してください。");
                }
                if (n != ans)
                {
                    count++;
                    if (n < ans)
                    {
                        Console.WriteLine("答えはもっと大きいです。");
                        low = n + 1;
                    }
                    else
                    {
                        Console.WriteLine("答えはもっと小さいです。");
                        high = n - 1;
                    }
                }
            } while (n != ans);
            Console.WriteLine("おめでとう！{0}回目で当たりました！", count);

        END:
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.ReadLine();

        }
    }
}