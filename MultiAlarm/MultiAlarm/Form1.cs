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
        //private bool alarmSetFlag = false;  // アラームをセットしているかどうかの判定フラグ
        private int alarm1Hour = 0;            // アラーム1 時
        private int alarm1Minute = 0;         // アラーム1 分
        private int alarm1Second = 0;        // アラーム1 秒
        
        private int alarm2Hour = 0;            // アラーム2 時
        private int alarm2Minute = 0;         // アラーム2 分
        private int alarm2Second = 0;        // アラーム2 秒

        private int alarm3Hour = 0;            // アラーム3 時
        private int alarm3Minute = 0;         // アラーム3 分
        private int alarm3Second = 0;        // アラーム3 秒

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

            //// アラームがセットされているときの処理
            //if (alarmSetFlag == true)
            //{
            //    // 設定時刻になった場合
            //    if (alarmHour == now.Hour && alarmMinute == now.Minute && alarmSecond == now.Second)
            //    {
            //        alarmSetFlag = false;
            //        MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            // アラーム1がセットされているときの処理
            if (checkBoxTimer1.Checked == true)
            {
                if (alarm1Hour == now.Hour && alarm1Minute == now.Minute && alarm1Second == now.Second)
                {
                    checkBoxTimer1.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // アラーム2がセットされているときの処理
            if (checkBoxTimer2.Checked == true)
            {
                if (alarm2Hour == now.Hour && alarm2Minute == now.Minute && alarm2Second == now.Second)
                {
                    checkBoxTimer2.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // アラーム3がセットされているときの処理
            if (checkBoxTimer3.Checked == true)
            {
                if (alarm3Hour == now.Hour && alarm3Minute == now.Minute && alarm3Second == now.Second)
                {
                    checkBoxTimer3.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }


        // 設定ボタン1クリック時のイベントハンドラ
        private void buttonSet1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // 設定ウィンドウのインスタンス作成
            //form2.ShowDialog();

            // 設定ウィンドウがOKで閉じられた場合の処理
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                //alarmSetFlag = true;  // アラームをセットしたのでフラグをtrueに。
                alarm1Hour = form2.alarmHour;
                alarm1Minute = form2.alarmMinute;
                alarm1Second = form2.alarmSecond;
                checkBoxTimer1.Text = alarm1Hour.ToString("00") + ":" + alarm1Minute.ToString("00");
                checkBoxTimer1.Checked = true;
            }
            form2.Dispose();
        }

        // 設定ボタン2クリック時のイベントハンドラ
        private void buttonSet2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // 設定ウィンドウのインスタンス作成

            // 設定ウィンドウがOKで閉じられた場合の処理
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                //alarmSetFlag = true;  // アラームをセットしたのでフラグをtrueに。
                alarm2Hour = form2.alarmHour;
                alarm2Minute = form2.alarmMinute;
                alarm2Second = form2.alarmSecond;
                checkBoxTimer2.Text = alarm2Hour.ToString("00") + ":" + alarm2Minute.ToString("00");
                checkBoxTimer2.Checked = true;
            }
            form2.Dispose();
        }

        // 設定ボタン2クリック時のイベントハンドラ
        private void buttonSet3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // 設定ウィンドウのインスタンス作成

            // 設定ウィンドウがOKで閉じられた場合の処理
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                //alarmSetFlag = true;  // アラームをセットしたのでフラグをtrueに。
                alarm3Hour = form2.alarmHour;
                alarm3Minute = form2.alarmMinute;
                alarm3Second = form2.alarmSecond;
                checkBoxTimer3.Text = alarm3Hour.ToString("00") + ":" + alarm3Minute.ToString("00");
                checkBoxTimer3.Checked = true;
            }
            form2.Dispose();
        }
    }
}
