using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            string firstCurrencyInput = TextBox1.Text;
            string secondCurrencyInput = TextBox2.Text;

            string request_uri = "http://localhost:2228/Service1.svc/GetDollarValue?fromCurrency=" + firstCurrencyInput + "&toCurrency=" + secondCurrencyInput;

            string outputText = client.DownloadString(request_uri);
            Label4.Text = outputText;

        }
    }
}