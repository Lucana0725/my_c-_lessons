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
    public partial class Form2 : Form
    {
        // 各種フィールド
        internal int alarmHour = 0;      // アラーム時
        internal int alarmMinute = 0;   // アラーム分
        internal int alarmSecond = 0;  // アラーム秒

        public Form2()
        {
            InitializeComponent();
        }


        // 設定ウィンドウの初期値ハンドラ
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        // 設定ウィンドウのOKボタンクリック時のイベントハンドラ
        private void buttonOK_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDownHour.Value;  // 時 のニューメリックの値をalarmHourにセット
            alarmMinute = (int)numericUpDownMinute.Value;  // 分 同上
            alarmSecond = 0;  // その時分になった瞬間にアラームを出したいので秒は0
        }
    }
}
