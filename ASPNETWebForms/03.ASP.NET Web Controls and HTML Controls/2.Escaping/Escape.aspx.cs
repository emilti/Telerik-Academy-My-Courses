using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.Escaping
{
    public partial class Escape : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxInput.Text;
            labelresult.Text = Server.HtmlEncode(textBoxInput.Text);
        }
    }
}