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
    }
}
