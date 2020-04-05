using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using B2.Audio;

namespace B2
{
    public partial class Form1 : Form
    {

        Calculator calculator = new Calculator();
        VoiceSynthentizer synthentizer = new VoiceSynthentizer();
        AudioUtils audioUtils = new AudioUtils();

        public Form1()
        {
            InitializeComponent();

            Lbl_CurrentAudioInput.Text += audioUtils.GetCurrentAudioInput();
            Lbl_CurrentAudioOutput.Text += audioUtils.GetCurrentAudioOutput();

            Lbl_Microphone.Text += " active";

            synthentizer.Speak("I am active");
        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {

            if (!float.TryParse(Tbox_num1.Text, out float num1) & !float.TryParse(Tbox_num2.Text, out float num2))
            {
                MessageBox.Show("Error with calculation");
                synthentizer.Speak("Error With calculation");
            }

            float calculation = calculator.Calculate(num1, num2, Tbox_operation.Text);
            label1.Text = calculation.ToString();

        }

        private void Btn_Synthentizer_Click(object sender, EventArgs e)
        {

        }

        private void Btn_SpeechRecognition_Click(object sender, EventArgs e)
        {
            //synthentizer.
        }
    }
}
