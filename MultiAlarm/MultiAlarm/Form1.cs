using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class Form1 : Form
    {
        // 各種フィールド
        private bool alarmSetFlag = false;  // アラームをセットしているかどうかの判定フラグ
        private int alarmHour = 0;            // アラーム時
        private int alarmMinute = 0;         // アラーム分
        private int alarmSecond = 0;        // アラーム秒

        public Form1()
        {
            InitializeComponent();
        }


        // ウィンドウ起動時のイベントハンドラ
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();  // タイマーを起動。
            labelTime.Text = DateTime.Now.ToLongTimeString();  // labelTimeに現在時刻を表示。こちらにも記述することでウィンドウを起動時即表示する
        }


        // タイマーのティックイベントハンドラ
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;  // DateTime型のnowという変数で現在日時を取得。
            labelTime.Text = now.ToLongTimeString();  // nowの時刻(長い表記バージョン)をlabelTimeのテキストに。
        }


        // ボタン1クリック時のイベントハンドラ
        private void buttonSet1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // 設定ウィンドウのインスタンス作成
            //form2.ShowDialog();

            // 設定ウィンドウがOKで閉じられた場合の処理
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                alarmSetFlag = true;  // アラームをセットしたのでフラグをtrueに。
                alarmHour = form2.alarmHour;
                alarmMinute = form2.alarmMinute;
                alarmSecond = form2.alarmSecond;
                checkBoxTimer1.Text = alarmHour.ToString("00") + ":" + alarmMinute.ToString("00");
                checkBoxTimer1.Checked = true;
            }
            form2.Dispose();
        }
    }
}
