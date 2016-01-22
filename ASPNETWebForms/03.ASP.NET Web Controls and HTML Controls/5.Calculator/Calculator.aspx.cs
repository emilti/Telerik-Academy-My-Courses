using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5.Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        static double firstNumber;
        static double secondNumber;
        static string sign;
        static double result;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            input.Text = input.Text + clickedButton.Text;
        }
        protected void ButtonPlus_click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(input.Text);
            input.Text = "";
            sign = "+";
        }

        protected void ButtonMinus_click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(input.Text);
            input.Text = "";
            sign = "-";
        }

        protected void ButtonClear_click(object sender, EventArgs e)
        {

            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            input.Text = "";
        }

        protected void ButtonMulti_click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(input.Text);
            input.Text = "";
            sign = "*";
        }

        protected void ButtonDivide_click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(input.Text);
            input.Text = "";
            sign = "/";
        }

        protected void ButtonSqrt_click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(input.Text);
            input.Text = Math.Sqrt(firstNumber).ToString();
            firstNumber = 0;
            secondNumber = 0;
            result = 0;            
        }

        protected void ButtonEqual_click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(input.Text);
            if(sign == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (sign == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (sign == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (sign == "/")
            {
                result = firstNumber / secondNumber;
            }            

            firstNumber = 0;
            secondNumber = 0;

            input.Text = result.ToString();
            result = 0;
        }
    }
}