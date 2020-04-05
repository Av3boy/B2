using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace B2.Audio
{
    public class AudioPlayer
    {

        private WaveOutEvent player;

        AudioPlayer()
        {
            player = new WaveOutEvent();
        }

        public void PlayAudio(string audioPath)
        {
            WaveStream mainOutputStream = new Mp3FileReader(audioPath);
            WaveChannel32 volumeStream = new WaveChannel32(mainOutputStream);

            player.Init(volumeStream);

            player.Play();
        }

    }
}
