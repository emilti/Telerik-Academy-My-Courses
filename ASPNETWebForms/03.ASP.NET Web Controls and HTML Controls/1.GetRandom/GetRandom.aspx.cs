using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1.GetRandom
{
    public partial class GetRandom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void htmlButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(int.Parse(this.htmlLowBound.Value), int.Parse(this.htmlUpBound.Value));
            htmlResult.InnerText = randomNumber.ToString();
        }

        protected void webButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(int.Parse(this.webLowBound.Text), int.Parse(this.webUpBound.Text));
            webResult.Text = randomNumber.ToString();
        }
    }
}