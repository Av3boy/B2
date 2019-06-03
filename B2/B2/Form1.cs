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

namespace B2
{
    public partial class Form1 : Form
    {

        Calculator calculator = new Calculator();
        VoiceSynthentizer synthentizer = new VoiceSynthentizer();


        public Form1()
        {
            InitializeComponent();

            Lbl_CurrentAudioInput.Text += GetCurrentAudioInput();
            Lbl_CurrentAudioOutput.Text += GetCurrentAudioOutput();

            Lbl_Microphone.Text += "ses";

            synthentizer.Speak();
        }
        
        public string GetCurrentAudioInput()
        {

            ManagementObjectSearcher objSearcher = new ManagementObjectSearcher(
            "SELECT * FROM Win32_SoundDevice");

            ManagementObjectCollection objCollection = objSearcher.Get();

            foreach (ManagementObject obj in objCollection)
            {
                foreach (PropertyData property in obj.Properties)
                {
                    Console.Out.WriteLine(String.Format("{0}:{1}", property.Name, property.Value) + "\n");
                }
            }

            return "ses";
        }

        private string GetCurrentAudioOutput()
        {
            return "ses";

        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {

            if (int.TryParse(Tbox_num1.Text, out int num1) & int.TryParse(Tbox_num2.Text, out int num2))
                MessageBox.Show("Error with calculation");

            label1.Text = calculator.Calculate(num1, num2, Tbox_operation.Text).ToString();

        }
    }
}
