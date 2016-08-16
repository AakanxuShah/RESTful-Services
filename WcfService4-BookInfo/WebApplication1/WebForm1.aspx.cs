using System;
using System.Collections.Generic;
using System.Linq;
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
            string inputText = TextBox1.Text;
            string inputText1 = TextBox1.Text;
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();

            string outputText = client.GetData(inputText,inputText1);

            string[] output = outputText.Split(',');

            Label2.Text = output[0];
            Label3.Text = output[1];
            Label4.Text = output[2];
            Label5.Text = output[3];

            Image1.ImageUrl = output[4];

        }
    }
}