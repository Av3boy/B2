using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace B2.Audio
{
    public class AudioUtils
    {
        public string GetCurrentAudioInput()
        {

            //Currently we try to get all available audio devices from windows
            string inputDevice = "ses";

            ManagementObjectSearcher objSearcher = new ManagementObjectSearcher(
            "SELECT * FROM Win32_SoundDevice");
            List<string> stringlist = new List<string>();

            foreach (ManagementObject obj in objSearcher.Get())
            {

                string deviceId = obj.GetPropertyValue("DeviceId").ToString();
                string name = obj.GetPropertyValue("Name").ToString();

                //Console.WriteLine(name + "\n");

                stringlist.Add(name);

                foreach (PropertyData property in obj.Properties)
                {
                    Console.WriteLine(property.Name);

                    //Console.Out.WriteLine(String.Format("{0}:{1}", property.Name, property.Value) + "\n");
                    //Console.WriteLine(property.Value);

                }
            }
            string last = "";

            foreach (var item in stringlist)
            {
                Console.WriteLine(item + "s \n");
                last = item;
            }


            return last;
        }

        public string GetCurrentAudioOutput()
        {
            ManagementObjectSearcher objSearcher = new ManagementObjectSearcher(
            "SELECT * FROM Win32_SoundDevice");

            ManagementObjectCollection objCollection = objSearcher.Get();

            foreach (ManagementObject obj in objCollection)
            {
                foreach (PropertyData property in obj.Properties)
                {
                    //Console.Out.WriteLine(String.Format("{0}:{1}", property.Name, property.Value) + "\n");
                    //Console.WriteLine(property.Value);
                }
            }

            return "ses";
        }
    }
}
