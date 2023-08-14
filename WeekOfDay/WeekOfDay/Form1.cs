using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ウィンドウのデフォルト値
        private void Form1_Load(object sender, EventArgs e)
        {
            labelResult.Text = "";
            numericUpDownMonth.Value = 1;
            numericUpDownDay.Value = 1;
        }

        // 「曜日算出」ボタンをクリックしたときの処理
        private void buttonCalc_Click(object sender, EventArgs e)
        {

        }

        // 「月」のニューメリックの処理
        private void numericUpDownMonth_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownMonth.Maximum = 12;
            numericUpDownMonth.Minimum = 1;
        }

        // 「日」のニューメリックの処理
        private void numericUpDownDay_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownDay.Maximum = 31;
            numericUpDownDay.Minimum = 1;
        }
    }
}
