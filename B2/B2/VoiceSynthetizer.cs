using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace B2
{
    public class VoiceRecognition
    {



    }

    public class VoiceSynthentizer
    {
        public bool isActive;
        Form1 form;

        public bool IsActivateSynthentizer()
        {
            form = new Form1();
            if (isActive)
                isActive = false;
            else isActive = true;

            return isActive;
        }

        public void Speak(string toSpeak)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10

            if (isActive)
            {
                // Synchronous speech
                synthesizer.Speak(toSpeak);

            }
        }
    }
}
