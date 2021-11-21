using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateDemo
{
    public partial class MainForm : Form
    {
        double number1 = 0.0;
        double number2 = 0.0;
        string operation = "";
        double negNum;
        string value;
        public MainForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This is the event
        /// associated with number 1 button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "1";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 1;
                    result.Text = number1.ToString();
                }

            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "1";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 1;
                    result.Text = number2.ToString();
                }
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "2";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 2;
                    result.Text = number1.ToString();
                }

            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "2";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 2;
                    result.Text = number2.ToString();
                }
            }
        }

        

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "9";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 9;
                    result.Text = number1.ToString();
                }

            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "9";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 9;
                    result.Text = number2.ToString();
                }
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "0";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10;
                    result.Text = number1.ToString();
                }

            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "0";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10;
                    result.Text = number2.ToString();
                }
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "3";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 3;
                    result.Text = number1.ToString();
                }

            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "3";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 3;
                    result.Text = number2.ToString();
                }
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "6";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 6;
                    result.Text = number1.ToString();
                }

            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "6";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 6;
                    result.Text = number2.ToString();
                }
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "5";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 5;
                    result.Text = number1.ToString();
                }

            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "5";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 5;
                    result.Text = number2.ToString();
                }
            }
        }


        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "7";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 7;
                    result.Text = number1.ToString();
                }

            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "7";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 7;
                    result.Text = number2.ToString();
                }
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "8";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 8;
                    result.Text = number1.ToString();
                }
                
            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "8";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 8;
                    result.Text = number2.ToString();
                }
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "4";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 4;
                    result.Text = number1.ToString();
                }
                
            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "4";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 4;
                    result.Text = number2.ToString();
                }
            }
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            int c = result.TextLength;
            int flag = 0;
            string text = result.Text;
            for (int i=0; i<c; i++)
            {
                if(text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                result.Text = result.Text + ".";
            }
          
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            number2 = 0;
            result.Text = "0";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operation = "x";
            number2 = 0;
            result.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            number2 = 0;
            result.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            number2 = 0;
            result.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (number1 + number2).ToString();
                    number1 = number1 + number2;
                    number2 = 0;
                    break;
                case "/":
                    result.Text = (number1 / number2).ToString();
                    number1 = number1 + number2;
                    number2 = 0;
                    break;
                case "-":
                    result.Text = (number1 - number2).ToString();
                    number1 = number1 + number2;
                    number2 = 0;
                    break;
                case "x":
                    result.Text = (number1 * number2).ToString();
                    number1 = number1 + number2;
                    number2 = 0;
                    break;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            result.Text = "0";
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string value = result.Text.ToString();
            if(value.Length > 0)
            {
                value = value.Substring(0, value.Length - 1);
                if(operation == "")
                {
                    if(value == "" || value =="-")
                    {
                        number1 = 0;
                        result.Text = number1.ToString();
                    }
                    else
                    {
                        number1 = double.Parse(value);
                        result.Text = value;
                    }
                    
                }
                else
                {
                    if (value == "" || value == "-")
                    {
                        number2 = 0;
                        result.Text = number2.ToString();
                    }
                    else
                    {
                        number2 = double.Parse(value);
                        result.Text = value;
                    }
                }

            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
                result.Text = number1.ToString();

            }
            else
            {
                number2 = 0;
                result.Text = number2.ToString();
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            string value = result.Text.ToString();
            if(value.Length >0)
            {
                result.Text = value;
                negNum = double.Parse(result.Text);
                negNum *= -1;
                if (operation == "" || number2 == 0)
                {
                    number1 = negNum;
                    result.Text = negNum.ToString();
                }
                else
                {
                    number2 = negNum;
                    result.Text = negNum.ToString();
                }
                
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "9";
                    number1 = double.Parse(value);
                }
                else
                {
                    number1 = number1 * 10 + 9;
                    result.Text = number1.ToString();
                }

            }
            else
            {
                bool dot = result.Text.Contains(".");
                if (dot)
                {
                    value = result.Text += "9";
                    number2 = double.Parse(value);
                }
                else
                {
                    number2 = number2 * 10 + 9;
                    result.Text = number2.ToString();
                }
            }
        }
    }
}
