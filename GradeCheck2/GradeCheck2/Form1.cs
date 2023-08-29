using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck2
{
    public partial class Form1 : Form
    {
        // 数学, 物理, 英語のインスタンスはイベントハンドラをまたいで使用するので、フィールドとして宣言しておく。
        Subject subjectM;   // 数学のインスタンス
        Subject subjectP;   // 物理のインスタンス
        Subject subjectE;   // 英語のインスタンス

        public Form1()
        {
            InitializeComponent();
        }

        // フォーム1同時のイベントハンドラ
        private void Form1_Load(object sender, EventArgs e)
        {
            // フィールドとしてインスタンスを宣言していたので、ここでnewしてインスタンスを生成する。(name, average, totalHours, passScore)
            subjectM = new Subject("数学", 70, 80, 60);
            subjectP = new Subject("物理", 65, 50, 50);
            subjectE = new Subject("英語", 77, 100, 70);
        }
    }
}
