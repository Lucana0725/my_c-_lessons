using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    internal class Television
    {
        // フィールド
        //private bool power;                      // 電源の状態  自動実装プロパティを定義したのでフィールドも不要に。
        private int channel;                      // 現在のチャンネル
        //private int volume;                       // 現在の音量  自動実装プロパティを定義したのでフィールドも不要に。
        private const int channelMin = 1;    // チャンネルの下限
        private const int channelMax = 12;  // チャンネルの上限
        private const int volumeMin = 0;     // 音量下限
        private const int volumeMax = 40;  // 音量上限


        // コンストラクタ
        public Television()
        {
            Console.WriteLine("引数のないコンストラクタの呼び出し");
            Power = false;
            Channel = 1;
            Volume = 20;
        }

        public Television(int channel, int volume)
        {
            Console.WriteLine("引数が2個のコンストラクタの呼び出し");
            Power = false;
            Channel = channel;
            Volume = volume;
        }

        public Television(bool power, int channel, int volume)
        {
            Console.WriteLine("引数が3つのコンストラクタの呼び出し");
            Power = power;
            Channel = channel;
            Volume = volume;
        }



        // プロパティ
        // 自動実装プロパティ
        public bool Power { get; private set; }

        public int Volume { get; private set; }

        // チャンネルのプロパティ
        public int Channel
        {
            get { return channel; }
            set
            {
                if (value >= channelMin && value <= channelMax)
                {
                    channel = value;
                }
            }
        }




        // メソッド

        // テレビの電源をON / OFFする
        public void OnOff()
        {
            if (Power)  // フィールドのpowerを削除したので、プロパティのPowerを使用する。
            {
                Power = false;
            }
            else
            {
                Power = true;
            }
        }



        // チャンネルをプラス1する
        public void ChannelUp()
        {
            if (channel < channelMax)
            {
                channel++;
            }
        }

        // チャンネルをマイナス1する
        public void ChannelDown()
        {
            if (channel > channelMin)
            {
                channel--;
            }
        }


        // 音量をプラス1する
        public void VolumeUp()
        {
            if (Volume < volumeMax)  // フィールドのvolumeを削除したので、プロパティのVolumeを使用。
            {
                Volume++;
            }
        }

        // 音量をマイナス1する
        public void VolumeDown()
        {
            if (Volume > volumeMin)
            {
                Volume--;
            }
        }
    }
}
