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
    }
}
