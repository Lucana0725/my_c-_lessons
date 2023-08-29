﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCheck2
{
    internal class Subject
    {
        // ---フィールド---
        private double average;     // 平均点
        private int totalHours;       // 総時数
        private int passScore;       // 合格点



        // ---コンストラクタ---
        // ここに定義予定




        // ---プロパティ---
        // ここに定義予定




        // ---メソッド---

        // 合否判定
        // 仮引数 => score:得点, attendance:出席時数
        // 返り値 => 判定結果
        public string OverPass(int score, int attendance)
        {
            double percent = (double)attendance / totalHours * 100;
            if (percent >= 80)
            {
                if (score >= passScore)
                {
                    return "合格";
                }
                else
                {
                    return "不合格";
                }
            }
            else
            {
                return "不合格";
            }
        }

        // 平均点以上かどうかを判定
        // 仮引数 => score:得点
        // 返り値 => 判定結果
        public string OverAverage(int score)
        {
            if (score >= average)
            {
                return "平均点以上";
            }
            else
            {
                return "平均点未満";
            }
        }

    }
}
