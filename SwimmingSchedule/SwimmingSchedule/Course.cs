using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    internal class Course
    {
        // -----フィールド-----
        private string name;           // コース名
        private string dayOfWeek;   // 曜日
        private int startHour;         // 開始時間
        private int fee;                 // 一回分の料金





        // -----コンストラクタ-----
        // ここに定義予定
        //public Course(string name, string dayOfWeek, int startHour, int fee)
        //{
        //    Name = name;
        //    DayOfWeek = dayOfWeek;
        //    StartHour = startHour;
        //    TotalFee = fee;
        //}





        // -----プロパティ-----
        // ここに定義予定
        //public string Name { get; set; }           // コース名を返すプロパティ
        //public string DayOfWeek { get; set; }   // 曜日を返すプロパティ
        //public int StartHour { get; set; }         // 開始時間を返すプロパティ
        //public int TotalFee                            // 合計金額を算出
        //{
        //    get { return ; }
        //}




        // -----メソッド-----
        // ここに定義予定
        // 授業が休講(毎月月末三日間は休講)かどうかを判定する
        /*
         * ここでやりたいこと
         * 
         * 入力された日にち(年月日, 曜日)を取得し、それらが月末3日間に該当するかどうかを調べる。
         * 該当したらtrueを返して、当該コース曜日だったとしても「休講」とかなにも表示しないみたいなことをしたい。
         * 該当しなければfalseを返して、普通にその曜日のコースを取得する。
         * => もしかして「表示」ボタンクリック時の処理？だとしたらForm1.csの処理か？
         */

        //DateTime dt = new DateTime()
        //public bool isCancelling()
        //{
        //    int daysInMonth = DateTime.DaysInMonth
        //}

    }
}
