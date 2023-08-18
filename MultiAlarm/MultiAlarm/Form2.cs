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
    }
}
