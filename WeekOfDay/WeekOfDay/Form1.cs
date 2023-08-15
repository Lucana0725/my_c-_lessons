using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ウィンドウのデフォルト値
        private void Form1_Load(object sender, EventArgs e)
        {
            labelResult.Text = "";
            numericUpDownMonth.Value = 1;
            numericUpDownDay.Value = 1;
        }

        // 「曜日算出」ボタンをクリックしたときの処理
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(textBoxAD.Text, out year) == false || year < 0)  // 西暦年に入力された値が数字に変換できないor0未満の場合
            {
                labelResult.Text = "西暦年エラー";
                return;
            }

            // 月日をdecimal型からint型へ変換
            int month = (int)numericUpDownMonth.Value;
            int day = (int)numericUpDownDay.Value;

            // 年月日が妥当でなければ「ありえない日付です」と表示させる
            if (checkDate(year, month, day) == false)
            {
                labelResult.Text = "ありえない日付です";
                return;
            }
            
            int week = weekOfDay(year, month, day);
            switch (week)
            {
                case 0:
                    labelResult.Text = "日曜日です";
                    break;
                case 1:
                    labelResult.Text = "月曜日です";
                    break;
                case 2:
                    labelResult.Text = "火曜日です";
                    break;
                case 3:
                    labelResult.Text = "水曜日です";
                    break;
                case 4:
                    labelResult.Text = "木曜日です";
                    break;
                case 5:
                    labelResult.Text = "金曜日です";
                    break;
                case 6:
                    labelResult.Text = "土曜日です";
                    break;
                default:
                    labelResult.Text = "算出エラーです";
                    break;
            }

        }



        // 「月」のニューメリックの処理
        private void numericUpDownMonth_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownMonth.Maximum = 12;
            numericUpDownMonth.Minimum = 1;
        }


        // 「日」のニューメリックの処理
        private void numericUpDownDay_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownDay.Maximum = 31;
            numericUpDownDay.Minimum = 1;
        }



        // 閏年かどうかを判定するメソッド
        // 引数：int型のy(西暦)
        private bool isLeapYear(int y)
        {
            bool leapYear = false;  // 閏年かどうかの真偽値をfalseで初期化しておく。

            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                return leapYear = true;
            }

            return leapYear;
        }



        // 年月日の妥当性をチェックするメソッド
        private bool checkDate(int y, int m, int d)
        {
            bool judge = true;  // 判定をtrueで初期化しておく

            // 月が1未満、12以上、日が1未満 であったり、31日月で日が31を超えたり、30日月で日が30を超えたりといった存在しない条件をすべてfalseにする
            if (m < 1 || m > 12 || d < 1)
                judge = false;
            else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                if (d > 31)
                    judge = false;
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                if (d > 30)
                    judge = false;
            }
            else
            {
                if (isLeapYear(y) == true)  // 仮引数yが閏年であるならば(yをisLeapYearにかけ、結果がtrueならば)
                {
                    if (d > 29)
                        judge = false;
                }
                else
                {
                    if (d > 28)
                        judge = false;
                }
            }

            return judge;  // 年月日が妥当かどうかの判定judgeを返す
        }



        // 曜日を求めるメソッド
        
        private int weekOfDay(int y, int m, int d)
        {
            //int w = (5 * y / (4 - y) / (100 + y) / 400 + (26 * m + 16) / 10 + d) % 7;
            //switch (w)
            //{
            //    case 0:

            //}

            // 1月or2月だったら、前年の13, 14月として扱う
            if (m == 1 || m == 2)
            {
                y--;
                m += 12;
            }

            //return (5 * y / (4 - y) / (100 + y) / 400 + (26 * m + 16) / 10 + d) % 7;
            return (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;
        }





        //// 西暦を整数値に変換するメソッド
        //private void yearConvertInt(string text, out int val)
        //{
        //    if (int.TryParse(text, out val) == false)
        //        val = 0;
        //}

        //// 西暦が閏年かどうかを判定するメソッド

        ////private void checkLeapYear()
        //private bool isLeapYear()

        //{
        //    string inputYear = textBoxAD.Text;
        //    //int year = yearConvertInt(inputYear);
        //    //int year = yearConvertInt(textBoxAD.Text);
        //    int year;
        //    yearConvertInt(inputYear, out year);
        //    bool leapYear;  // 閏年を変数で保持

        //    // 閏年かどうかの判定
        //    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        //    {
        //        //return leapYear = true;
        //        leapYear = true;
        //    }
        //    else
        //    {
        //        leapYear = false;
        //    }

        //    return leapYear;  // leapYearの判定結果をここで返す
        //}


        //// 年月日が妥当かどうかをチェックするメソッド
        //private void checkDate()
        //{
        //    int month = (int)numericUpDownMonth.Value;
        //    int day = (int)numericUpDownDay.Value;

        //    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month ==  12)
        //    {
        //        bool v = day > 0 && day < 31;
        //    }
        //    else if (month == 4 || month == 6 || month == 9 || month == 11)
        //    {
        //        bool v = day > 0 && day > 30;
        //    }
        //    else if (month == 2)
        //    {
                
        //    }
        //}


    }
}
