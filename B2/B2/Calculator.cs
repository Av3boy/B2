using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2
{
    public class Calculator
    {
        public int Calculate(int num1, int num2, string operation)
        {
            int equation = 0;

            switch (operation)
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
                     MessageBox.Show("error with equation");
                    break;
            }
      
            return equation;
        }
    }
}
