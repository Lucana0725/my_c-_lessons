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


            // 各科目の総時数の表示
            labelTotalM.Text = "/ " + subjectM.TotalHours.ToString();
            labelTotalP.Text = "/ " + subjectP.TotalHours.ToString();
            labelTotalE.Text = "/ " + subjectE.TotalHours.ToString();


            // 各科目の合格点の表示
            labelPassScoreM.Text = subjectM.PassScore.ToString();
            labelPassScoreP.Text = subjectP.PassScore.ToString();
            labelPassScoreE.Text = subjectE.PassScore.ToString();


            // 各科目の平均点の表示
            labelAverageM.Text = subjectM.Average.ToString();
            labelAverageP.Text = subjectP.Average.ToString();
            labelAverageE.Text = subjectE.Average.ToString();


            labelClear();
        }



        // 結果を表示するラベルのクリア
        private void labelClear()
        {
            labelName.Text = "";
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }
    }
}
