using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmTimer
{
    public partial class Form1 : Form
    {
        // 各種フィールドの設定
        private bool alarmSetFlag = false;  // アラームセット中フラグ
        private int alarmHour = 0;            // アラーム 時
        private int alarmMinute = 0;         // アラーム分
        private int alarmSecond = 0;        // アラーム病

        public Form1()
        {
            InitializeComponent();
        }



        // ウィンドウの初期値(ウィンドウ起動時のイベントハンドラ)
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();  // タイマーを起動
            labelStatus.Text = "";  // 起動後、1秒後ごとにTickイベントが発生
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日 (ddd)");  // 現在の日付を西暦年月日と曜日の文字列に変換
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }


        // タイマーtickのイベントハンドラ
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;  // 現在の時刻を取得
            labelTime.Text = now.ToLongTimeString();  // 現在の時刻をlabelTimeに表示(ToLongString()形式で。)
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日 (ddd)");  // 本日の日付をlabelDateに表示(yyyy年MM月dd日 (ddd)の形式で。)
        }


        // 設定ボタンのイベントハンドラ
        private void buttonSet_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // form2インスタンスを生成
            //form2.ShowDialog();  // form2用のダイアログを表示
            
            // 設定ダイアログボックスの表示(上の1行を修正)
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                alarmSetFlag = true;
                alarmHour = form2.alarmHour;
                alarmMinute = form2.alarmMinute;
                alarmSecond = form2.alarmSecond;
                labelStatus.Text = "♪ " + alarmHour.ToString("00") + ":" + alarmMinute.ToString("00") + ":" + alarmSecond.ToString("00");
            }
            form2.Dispose();  // 不要になったform2を削除し、リソースの開放
        }
    }
}
