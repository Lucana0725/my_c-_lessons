﻿using System;
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


        // Form2起動時のイベントハンドラ
        private void Form2_Load(object sender, EventArgs e)
        {
            // 現在時刻の表示
            numericUpDownAlmHour.Value = DateTime.Now.Hour;
            numericUpDownAlmMnt.Value = DateTime.Now.Minute;
        }

        // 「アラーム」のValueChangedイベントハンドラ
        private void numericUpDownAlm_ValueChanged(object sender, EventArgs e)
        {
            radioButtonAlarm.Checked = true;  // アラームの「時」の値が変更されるとラジオボタンもアラームに切り替わる
        }


        // 「タイマー」のValueChangedイベントハンドラ
        private void numericUpDownTim_ValueChanged(object sender, EventArgs e)
        {
            radioButtonTimer.Checked = true;
        }


        // OKボタンクリックのイベントハンドラ
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonAlarm.Checked == true)
            {
                // アラーム時刻の設定
                alarmHour = (int)numericUpDownAlmHour.Value;
                alarmMinute = (int)numericUpDownAlmMnt.Value;
                alarmSecond = 0;
            }
            else
            {
                // タイマー時間を現在時刻に加算してアラーム時刻に設定
                DateTime dtNow = DateTime.Now;
                TimeSpan addSpan = new TimeSpan(0, (int)numericUpDownTimMnt.Value, (int)numericUpDownTimSec.Value);
                DateTime setTime = dtNow.Add(addSpan);

                alarmHour = setTime.Hour;
                alarmMinute = setTime.Minute;
                alarmSecond = setTime.Second;

            }

        }
    }
}
