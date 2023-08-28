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
        private bool power;                      // 電源の状態
        private int channel;                      // 現在のチャンネル
        private int volume;                       // 現在の音量
        private const int channelMin = 1;    // チャンネルの下限
        private const int channelMax = 12;  // チャンネルの上限
        private const int volumeMin = 0;     // 音量下限
        private const int volumeMax = 40;  // 音量上限



        // プロパティ
        
        // 電源のプロパティ
        public bool Power
        {
            get { return power; }
            //set { power = value; }  // 外からセットしないのでPowerは読み取り専用プロパティに。
        }

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

        // ボリュームのプロパティ
        public int Volume
        {
            get { return volume; }
            //set  // 外からセットしないのでVolumeは読み取り専用プロパティに。
            //{
            //    if (volume >= volumeMin && volume <= volumeMax)
            //    {
            //        volume = value;
            //    }
            //}
        }



        // メソッド

        // テレビの電源をON / OFFする
        public void OnOff()
        {
            if (power)
            {
                power = false;
            }
            else
            {
                power = true;
            }
        }


        // チャンネルを設定する  <= プロパティを定義したから不要に。
        //public void SetChanel(int c)
        //{
        //    if (c >= channelMin && c <= channelMax)
        //    {
        //        channel = c;
        //    }
        //}


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
            if (volume < volumeMax)
            {
                volume++;
            }
        }

        // 音量をマイナス1する
        public void VolumeDown()
        {
            if (volume > volumeMin)
            {
                volume--;
            }
        }
    }
}
