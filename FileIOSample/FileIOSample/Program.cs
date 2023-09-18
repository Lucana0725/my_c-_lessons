using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace FileIOSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExistsExample();
            //CreateDirectoryExample();
            //DeleteExample();
            //ExistsExample2();
            //CreateExample();
            //DeleteExample2();
            //ListExample();
            DictExample();

        }


        static void ExampleFileIO()
        {
            // 文字列を全部書き込む例
            string writeText = "文字列をファイルに書き込みました。";

            try
            {
                using (StreamWriter writer1 = new StreamWriter("test1.txt", false, Encoding.Default))
                {
                    writer1.Write(writeText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // 複数の文字列を1行ずつ書き込む
            string[] writeText2 = { "続けて文字列を", "改行しながら", "書き込みます。" };

            try
            {
                using (StreamWriter writer2 = new StreamWriter("test1.txt", true, Encoding.Default))
                {
                    foreach (string s in writeText2)
                    {
                        writer2.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }






            // ファイルを全部読み込む例
            string readText = "";

            try
            {
                using (StreamReader reader1 = new StreamReader("test1.txt", Encoding.Default))
                {
                    readText = reader1.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(readText);


            // ファイルを1行ずつ読み込む例
            try
            {
                using (StreamReader reader2 = new StreamReader("test1.txt", Encoding.Default))
                {
                    string line;
                    while ((line = reader2.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        // Existsメソッドの例
        static void ExistsExample1()
        {
            //string directory = @"C:\Program Files\Microsoft Office";
            string directory = @"C:\Program Files\BraveSoftware";
            if (Directory.Exists(directory))
                Console.WriteLine(directory + "ディレクトリは存在します。");
            else
                Console.WriteLine(directory + "ディレクトリは存在しません。");

            Console.Read();
        }


        static void CreateDirectoryExample()
        {
            try
            {
                if (Directory.Exists("test") == false)
                {
                    Console.WriteLine("testディレクトリが存在しないので、作成します。");
                    Directory.CreateDirectory("test");

                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }


        static void DeleteExample()
        {
            try
            {
                if (Directory.Exists("test") == true)
                {
                    Console.WriteLine("testディレクトリは存在するので、削除します。");
                    Directory.Delete("test", true);
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }


        static void ExistsExample2()
        {
            string fileName = @"C:Windows\explorer.exe";
            if (File.Exists(fileName) == true)
            {
                Console.WriteLine(fileName + "は存在します。");
                Console.Read();
            }
            else
            {
                Console.WriteLine(fileName + "は存在しません。");
                Console.Read();
            }
        }


        static void CreateExample()
        {
            try
            {
                if (File.Exists("test.txt") == false)
                {
                    Console.WriteLine("test.txt ファイルは存在しないので作成します。");
                    FileStream fs = File.Create("test.txt");
                    fs.Close();     // ファイルをクローズ(忘れないよう注意！)
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }


        static void DeleteExample2()
        {
            try
            {
                if (File.Exists("test.txt") == true)
                {
                    Console.WriteLine("test.txt ファイルは存在するので削除します。");
                    File.Delete("test.txt");
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }


        static void ListExample()
        {
            // リストのインスタンスの生成
            List<string> sList = new List<string>();
            // 要素の追加
            sList.Add("First");
            sList.Add("Second");
            sList.Add("Third");

            // 要素の参照
            for (int i = 0; i < sList.Count; i++)
            {
                Console.WriteLine($"sList[{i}]：{sList[i]}");
            }
            Console.WriteLine();



            // リストの初期化
            List<int> iList = new List<int> { 1, 2, 3, 4, 5 };

            // 要素の参照
            for (int i = 0; i < iList.Count; i++)
            {
                Console.WriteLine($"iList[{i}]：{iList[i]}");
            }
            Console.WriteLine();

            // 先頭に要素100を追加
            iList.Insert(0, 100);
            // 要素4の削除
            iList.Remove(4);
            // 2番目の要素の削除
            iList.RemoveAt(2);

            // 要素の参照
            for (int i = 0; i < iList.Count; i++)
            {
                Console.WriteLine($"iList[{i}]：{iList[i]}");
            }

            Console.Read();
        }


        static void DictExample()
        {
            // 連想配列の宣言と初期化
            Dictionary<string, string> color = new Dictionary<string, string> { { "黒", "Black" }, { "白", "White" }, { "黄", "Yellow" } };

            // 配列のように値を追加
            color["赤"] = "Red";
            // Addメソッドで値を追加
            color.Add("青", "Blue");

            // すべてのキーと値を参照する
            Console.WriteLine("すべてのキーと値を参照する");
            foreach (string key in color.Keys)
            {
                Console.WriteLine($"{key}は{color[key]}です。");
            }
            Console.WriteLine();

            // すべてのキーのみ参照する
            Console.WriteLine("すべてのキーのみ参照する");
            foreach (string key in color.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            // すべての値を参照する
            Console.WriteLine("すべての値を参照する");
            foreach (string val in color.Values)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();

            // 配列のように参照する
            Console.WriteLine($"黄は英語で{color["黄"]}です。");

            // TryGetValueメソッドで参照する
            if (color.TryGetValue("白", out string value))
            {
                Console.WriteLine($"白は英語で{value}です。");
            }

            // キーの存在チェック
            if (color.ContainsKey("緑"))
                Console.WriteLine("緑はキーに存在します。");
            else
                Console.WriteLine("緑はキーに存在しません。");

            // 値の存在チェック
            if (color.ContainsValue("Red"))
                Console.WriteLine("Redは値に存在します。");
            else
                Console.WriteLine("Redは値に存在しません。");

            Console.Read();
        }

    }
}
