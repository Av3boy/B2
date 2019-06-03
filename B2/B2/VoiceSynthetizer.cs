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

        Form1 form;

        public void ActivateSynthentizer()
        {
            form = new Form1();
        }

        public void DisableSynthentizer()
        {

        }

        public void Speak()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            synthesizer.Rate = -2;     // -10...10

            // Synchronous
            synthesizer.Speak("Hello World");

            // Asynchronous
            synthesizer.SpeakAsync("Hello World");
        }
    }
}
