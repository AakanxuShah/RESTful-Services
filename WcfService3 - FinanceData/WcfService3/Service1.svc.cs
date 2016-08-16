using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Web.Hosting;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetMicrosoftData(string date)
        {
            //open the dataset for Microsoft stock values
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/App_Data/Microsoft_table.csv")))
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
                        string[] entry = currentLine.Split(',');

                        // finds the particular date to fetch and compute the average stock price of that day
                        if (String.Equals(entry[0], date))
                        {
                           // computes the average from Highest and Lowest value of the stock price 
                            float Average;
                            float HighestValue = float.Parse(entry[2]);
                            float LowestValue = float.Parse(entry[3]);
                            Average = (HighestValue + LowestValue) / 2;

                            string strAvg = Average.ToString();
                            //returns the Opening value , Highest and Lowest price that day , Closing value and Calculated Average
                            string z = entry[1] +',' + entry[2] +','+ entry[3] + ',' + entry[4] +',' +strAvg;
                            return z;
                        }

                    }//end of else 

                } // end of while
 
            }// end of using dataset

            return "Date not Found - Enter correct date";
        }//end of method GetMicrosoftData


        public string GetAppleData(string date)
        {
            //open the dataset for Apple stocks
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/App_Data/Apple_table.csv")))
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
                        string[] entry = currentLine.Split(',');
                        // finds the date to fetch and compute the average stock price of that day for APPLE
                        if (String.Equals(entry[0], date))
                        {
                            float Average;
                            float HighestValue = float.Parse(entry[2]);
                            float LowestValue = float.Parse(entry[3]);
                            Average = (HighestValue + LowestValue) / 2;

                            string strAvg = Average.ToString();
                            string z = entry[1] + ',' + entry[2] + ',' + entry[3] + ',' + entry[4] + ',' + strAvg;
                            return z;
                        }

                    }//end of else 

                } // end of while

            }// end of using dataset

            return "Date not Found - Enter correct date";
        }//end of method GetAppleData


        public string GetIntelData(string date)
        {
            //open the dataset for Intel stock values
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/App_Data/Intel_table.csv")))
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
                        string[] entry = currentLine.Split(',');

                        // finds the particular date to fetch and compute the average stock price of that day
                        if (String.Equals(entry[0], date))
                        {
                            // computes the average from Highest and Lowest value of the stock price 
                            float Average;
                            float HighestValue = float.Parse(entry[2]);
                            float LowestValue = float.Parse(entry[3]);
                            Average = (HighestValue + LowestValue) / 2;

                            string strAvg = Average.ToString();
                            //returns the Opening value , Highest and Lowest price that day , Closing value and Calculated Average
                            string z = entry[1] + ',' + entry[2] + ',' + entry[3] + ',' + entry[4] + ',' + strAvg;
                            return z;
                        }

                    }//end of else 

                } // end of while

            }// end of using dataset

            return "Date not Found - Enter correct date";
        }//end of method GetIntelData

        public string GetYahooData(string date)
        {
            //open the dataset for Microsoft stock values
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/App_Data/Yahoo_table.csv")))
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
                        string[] entry = currentLine.Split(',');

                        // finds the particular date to fetch and compute the average stock price of that day
                        if (String.Equals(entry[0], date))
                        {
                            // computes the average from Highest and Lowest value of the stock price 
                            float Average;
                            float HighestValue = float.Parse(entry[2]);
                            float LowestValue = float.Parse(entry[3]);
                            Average = (HighestValue + LowestValue) / 2;

                            string strAvg = Average.ToString();
                            //returns the Opening value , Highest and Lowest price that day , Closing value and Calculated Average
                            string z = entry[1] + ',' + entry[2] + ',' + entry[3] + ',' + entry[4] + ',' + strAvg;
                            return z;
                        }

                    }//end of else 

                } // end of while

            }// end of using dataset

            return "Date not Found - Enter correct date";
        }//end of method GetYahooData

        public string GetEbayData(string date)
        {
            //open the dataset for Ebay stock values
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/App_Data/Ebay_table.csv")))
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
                        string[] entry = currentLine.Split(',');

                        // finds the particular date to fetch and compute the average stock price of that day
                        if (String.Equals(entry[0], date))
                        {
                            // computes the average from Highest and Lowest value of the stock price 
                            float Average;
                            float HighestValue = float.Parse(entry[2]);
                            float LowestValue = float.Parse(entry[3]);
                            Average = (HighestValue + LowestValue) / 2;

                            string strAvg = Average.ToString();
                            //returns the Opening value , Highest and Lowest price that day , Closing value and Calculated Average
                            string z = entry[1] + ',' + entry[2] + ',' + entry[3] + ',' + entry[4] + ',' + strAvg;
                            return z;
                        }

                    }//end of else 

                } // end of while

            }// end of using dataset

            return "Date not Found - Enter correct date";
        }//end of method GetEbayData

        public string GetNetflixData(string date)
        {
            //open the dataset for Netflix stock values
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/App_Data/Netflix_table.csv")))
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
                        string[] entry = currentLine.Split(',');

                        // finds the particular date to fetch and compute the average stock price of that day
                        if (String.Equals(entry[0], date))
                        {
                            // computes the average from Highest and Lowest value of the stock price 
                            float Average;
                            float HighestValue = float.Parse(entry[2]);
                            float LowestValue = float.Parse(entry[3]);
                            Average = (HighestValue + LowestValue) / 2;

                            string strAvg = Average.ToString();
                            //returns the Opening value , Highest and Lowest price that day , Closing value and Calculated Average
                            string z = entry[1] + ',' + entry[2] + ',' + entry[3] + ',' + entry[4] + ',' + strAvg;
                            return z;
                        }

                    }//end of else 

                } // end of while

            }// end of using dataset

            return "Date not Found - Enter correct date";
        }//end of method GetNetflixData
    }//end of Service
} // end of Namespace
