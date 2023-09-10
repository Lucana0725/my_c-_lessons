using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchedule
{
    public partial class Form1 : Form
    {
        // 本日の日付を取得する
        DateTime now = DateTime.Now;

        // フィールド
        private int year;     // 年
        private int month;  // 月




        // プロパティ
        public int Year
        {
            get { return year; }
            set { year = (int)numericUpDownYear.Value; }
        }

        public int Month
        {
            get { return month; }
            set { month = (int)numericUpDownMonth.Value; }
        }



        public Form1()
        {
            InitializeComponent();
        }


        // Form1ロード時のイベントハンドラ
        private void Form1_Load(object sender, EventArgs e)
        {
            // フォーム起動時に現在の年と月をニューメリックに表示する
            numericUpDownYear.Value = now.Year;
            numericUpDownMonth.Value = now.Month;
        }





        // 入力された年月の日数を求める
        private void CalcDaysInMonth()
        {
            int daysInMonth = DateTime.DaysInMonth(Year, Month);
        }
    }
}
