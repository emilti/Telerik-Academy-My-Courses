using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4.ticTacToe
{
    public partial class TicTacToe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if(clickedButton.Text == " ")
            {
                clickedButton.Text = "x";
            }

            if(Button1.Text == " ")
            {
                Button1.Text = "o";
            }
            else if (Button2.Text == " ")
            {
                Button2.Text = "o";
            }
            else if (Button3.Text == " ")
            {
                Button3.Text = "o";
            }
            else if (Button4.Text == " ")
            {
                Button4.Text = "o";
            }
            else if (Button5.Text == " ")
            {
                Button5.Text = "o";
            }
            else if (Button6.Text == " ")
            {
                Button6.Text = "o";
            }
            else if (Button7.Text == " ")
            {
                Button7.Text = "o";
            }
            else if (Button8.Text == " ")
            {
                Button8.Text = "o";
            }
            else if (Button9.Text == " ")
            {
                Button9.Text = "o";
            }
        }
    }
}