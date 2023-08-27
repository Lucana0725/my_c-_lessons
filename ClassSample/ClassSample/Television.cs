using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    internal class Television
    {
        // メンバー
        public bool power;                      // 電源の状態
        public int channel;                      // 現在のチャンネル
        public int volume;                       // 現在の音量
        public const int channelMin = 1;    // チャンネルの下限
        public const int channelMax = 12;  // チャンネルの上限
    }
}
