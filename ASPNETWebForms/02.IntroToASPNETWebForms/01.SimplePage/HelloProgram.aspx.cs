namespace HelloProgram
{
    using System;
    using System.Globalization;

    public partial class HelloProgram : System.Web.UI.Page
    {
        protected void ButtonAddHello_Click(object sender, EventArgs e)
        {
            try
            {
                var input = this.TextBoxInput.Text ;
                var result = "Hello, " + input;
                this.resultLabel.Text = result.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                this.resultLabel.Text = "Invalid.";
            }
        }
    }
}
