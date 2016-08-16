using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Web.Hosting;


namespace WcfService4_BookInfo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       

        public string GetData(string bookName, string ISDN)

        {
            //open the dataset for Books Info
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/App_Data/BX-Books.csv")))
            {
                string currentLine;

                //Ignore the First line of the dataset for Column name
                bool firstLine = true;
                while ((currentLine = sr.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }
                    else
                    {
                        string[] entry = currentLine.Split(';');
                        if (String.Equals(bookName, entry[1],StringComparison.OrdinalIgnoreCase) || String.Equals(ISDN , entry[0],StringComparison.OrdinalIgnoreCase))
                        {
                            string z = entry[0] + ',' + entry[1] + ',' + entry[2] + ',' + entry[3] +',' + entry[7];
                            return z;
                        }
                    }
                }
            }
            string[] errorMsg;
            errorMsg = new string[5];
            errorMsg[0] = "Entered"; errorMsg[1] = "Wrong"; errorMsg[2] = "Name Or"; errorMsg[3] = "ISBN";
            errorMsg[4] = "http://www.teachitza.com/delphi/io3.jpg";

            string a = errorMsg[0] + ',' + errorMsg[1] + ',' + errorMsg[2] + ',' + errorMsg[3] + ',' + errorMsg[4];
            return a;
        } // end of GetData method

        /*
        public string GetDataFromAuthor(string authorName)
        {
            //open the dataset for Books Info
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/App_Data/BX-Books.csv")))
            {
                string currentLine;
                string z;

                //Ignore the First line of the dataset for Column name
                bool firstLine = true;
                while ((currentLine = sr.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }
                    else
                    {
                        string[] entry = currentLine.Split(';');

                        if (String.Equals(authorName, entry[2], StringComparison.OrdinalIgnoreCase))
                        {
                             z = entry[1] + ',' + entry[2] + ',' + entry[7];
                             
                        }
                     
                    }//end of else
                
                }//end of while 
               
            }// end of using dataset
            return "You have entered wrong Book Name or ISDN";
        } // end of GetData method
        */
       
    } // end of service 
}// end of namespace
