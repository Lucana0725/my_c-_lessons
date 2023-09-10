using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            CreateExample();
            //DeleteExample2();
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

    }
}
