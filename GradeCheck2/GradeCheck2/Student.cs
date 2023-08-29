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
        // ここに定義予定



        // プロパティ
        // ここに定義予定




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
