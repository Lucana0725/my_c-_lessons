using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // 本日の日付を取得する
        //DateTime now = new DateTime();
        DateTime now = DateTime.Now;





        // Form1ロード時のイベントハンドラ

        private void Form1_Load(object sender, EventArgs e)
        {
            // フォーム起動時に現在の年と月をニューメリックに表示する
            numericUpDownYear.Value = now.Year;
            numericUpDownMonth.Value = now.Month;
        }
    }
}
