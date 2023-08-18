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
            form2.ShowDialog();
            form2.Dispose();
        }
    }
}
