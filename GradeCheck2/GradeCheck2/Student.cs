using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCheck2
{
    // 学生クラス
    internal class Student
    {
        // フィールド
        private int scoreM;                 // 数学の点数
        private int scoreP;                 // 物理の点数
        private int scoreE;                 // 英語の点数
        private int attendanceM;        // 数学の出席時数
        private int attendanceP;        // 物理の出席時数
        private int attendanceE;        // 英語の出席時数



        // コンストラクタ
        public Student(string name, int scoreM, int scoreP, int scoreE, int attendanceM, int attendanceP, int attendanceE)
        {
            Name = name;
            ScoreM = scoreM;
            ScoreP = scoreP;
            ScoreE = scoreE;
            AttendanceM = attendanceM;
            AttendanceP = attendanceP;
            AttendanceE = attendanceE;
        }




        // プロパティ
        
        // 学生名
         public string Name { get; set; }

        // 数学の得点
        public int ScoreM
        {
            get { return scoreM; }
            set { scoreM = scoreCheck(value); }
        }

        // 物理の得点
        public int ScoreP
        {
            get { return scoreP; }
            set { scoreP = scoreCheck(value); }
        }

        // 英語の得点
        public int ScoreE
        {
            get { return scoreE; }
            set { scoreE = scoreCheck(value); }
        }

        // 数学の出席時数
        public int AttendanceM
        {
            get { return attendanceM; }
            set { attendanceM = attendanceCheck(value); }
        }

        // 物理の出席時数
        public int AttendanceP
        {
            get { return attendanceP; }
            set { attendanceP = attendanceCheck(value); }
        }

        // 英語の出席時数
        public int AttendanceE
        {
            get { return attendanceE; }
            set { attendanceE = attendanceCheck(value); }
        }





        // 各種メソッド

        // 得点の値が正しいかチェックする
        private int scoreCheck(int val)
        {
            if (val >= 0 && val <= 100)
            {
                return val;
            }
            else  // 得点値が0より小さかったり100より大きかったら、メッセージボックスにて警告し、0を返す(入力値を反映しない)。
            {
                System.Windows.Forms.MessageBox.Show("得点の入力が正しくありません。", "確認");
                return 0;
            }
        }

        // 出席時数の値が正しいかチェックする
        private int attendanceCheck(int val)
        {
            if (val >= 0)
            {
                return val;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("出席時数の入力が正しくありません。", "確認");
                return 0;
            }
        }

    }
}
