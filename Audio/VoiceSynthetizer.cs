using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Globalization;

namespace B2
{
    public class VoiceRecognition
    {

        SpeechRecognizer recognizer;
        SpeechRecognitionEngine sre;
        static bool speechOn = true;

        VoiceRecognition()
        {
            CultureInfo ci = new CultureInfo("fi-FI");
            sre = new SpeechRecognitionEngine(ci);
            recognizer = new SpeechRecognizer();
        }

        public void RecognizeSpeech()
        {
            Thread thread = new Thread(() => {

                GrammarBuilder gb_StartStop = new GrammarBuilder();
                Grammar grammar = new Grammar(gb_StartStop);
                recognizer.LoadGrammar(grammar);
                sre.SpeechRecognized += sre_SpeechRecognized;

            });
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string txt = e.Result.Text;
            float confidence = e.Result.Confidence;
            Console.WriteLine("\nRecognized: " + txt);
            if (confidence < 0.60) return;
            if (txt.IndexOf("speech on") >= 0)
            {
                Console.WriteLine("Speech is now ON");
                speechOn = true;
            }
            if (txt.IndexOf("speech off") >= 0)
            {
                Console.WriteLine("Speech is now OFF");
                speechOn = false;
            }
            if (speechOn == false) return;
            if (txt.IndexOf("klatu") >= 0 && txt.IndexOf("barada") >= 0)
            {
                ((SpeechRecognitionEngine)sender).RecognizeAsyncCancel();
                Console.WriteLine("(Speaking: Farewell)");
            }
            if (txt.IndexOf("What") >= 0 && txt.IndexOf("plus") >= 0)
            {
                string[] words = txt.Split(' ');
                int num1 = int.Parse(words[2]);
                int num2 = int.Parse(words[4]);
                int sum = num1 + num2;
                Console.WriteLine("(Speaking: " + words[2] + " plus " +
                  words[4] + " equals " + sum + ")");
            }
        }
    }

    public class VoiceSynthentizer
    {
        public bool isActive;
        SpeechSynthesizer synthesizer;

        public VoiceSynthentizer()
        {
            synthesizer = new SpeechSynthesizer();
        }

        public bool IsActivateSynthentizer()
        {
            if (isActive)
                isActive = false;
            else isActive = true;

            return isActive;
        }

        public void Speak(string toSpeak)
        {
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
