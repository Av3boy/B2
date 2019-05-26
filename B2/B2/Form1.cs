using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int equation = 0, num1, num2;
            if (int.TryParse(Tbox_num1.Text, out num1))
            {
                label1.Text = num1.ToString();
            }

            if (int.TryParse(Tbox_num2.Text, out num2))
            {
                label1.Text = num2.ToString();
            }

            switch (Tbox_operation.Text)
            {
                case "+":
                    equation = num1 + num2;
                    break;
                case "-":
                    equation = num1 - num2;
                    break;
                case "/":
                    equation = num1 / num2;
                    break;
                case "*":
                    equation = num1 * num2;
                    break;
                case "pow":
                    equation = (int)Math.Pow(num1, num2);
                    break;
                default:
                    label1.Text = "error with equation";
                    break;

            }

            label1.Text = equation.ToString();


        }
    }
}
