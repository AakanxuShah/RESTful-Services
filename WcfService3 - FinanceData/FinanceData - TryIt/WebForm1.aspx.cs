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
            string Date = TextBox1.Text;
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();

            string outputText = client.GetMicrosoftData(Date);
            Label4.Text = "Microsoft Data :" + outputText;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Date = TextBox2.Text;
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();

            string outputText = client.GetAppleData(Date);
            Label9.Text = "Apple Data :" + outputText;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string Date = TextBox3.Text;
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();

            string outputText = client.GetIntelData(Date);
            Label13.Text = "Intel Data :" + outputText;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string Date = TextBox4.Text;
            ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();

            string outputText = client.GetYahooData(Date);
            Label17.Text = "Yahoo Data :" + outputText;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string Date = TextBox5.Text;
            ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();

            string outputText = client.GetEbayData(Date);
            Label21.Text = "Ebay Data :" + outputText;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string Date = TextBox6.Text;
            ServiceReference3.Service1Client client = new ServiceReference3.Service1Client();

            string outputText = client.GetEbayData(Date);
            Label25.Text = "Netflix Data :" + outputText;
        }
    }
}