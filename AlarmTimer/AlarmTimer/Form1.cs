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



        // ウィンドウの初期値
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();  // タイマーを起動
            labelStatus.Text = "";  // 起動後、1秒後ごとにTickイベントが発生
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日 (ddd)");  // 現在の日付を西暦年月日と曜日の文字列に変換
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
