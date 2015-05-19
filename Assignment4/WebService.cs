using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Assignment4
{
    class WebService
    {
        private string url;
        private string result;
        private string basicurl;

        public string callWebService(string a)
        {
            
            try
            {

                result="";
                url = a;
                HttpWebRequest req = WebRequest.Create(url)
                          as HttpWebRequest;
                
                using (HttpWebResponse resp = req.GetResponse()
                                              as HttpWebResponse)
                {
                    StreamReader reader =
                        new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();

                }
                using (StreamWriter outfile = new StreamWriter("temp.xml"))
                {
                    outfile.Write(result.ToString());
                }

                return  "success";
               
            }
            catch (WebException e)
            {
                return e.ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public string callWebService(string a, string b)
        {

            try
            {
                basicurl = "http://services.odata.org/Northwind/Northwind.svc/";
                url = basicurl + a + "?$orderby=" + b;
                HttpWebRequest req = WebRequest.Create(url)
                           as HttpWebRequest;
                result = null;
                using (HttpWebResponse resp = req.GetResponse()
                                              as HttpWebResponse)
                {
                    StreamReader reader =
                        new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();

                }
                using (StreamWriter outfile = new StreamWriter("temp.xml"))
                {
                    outfile.Write(result.ToString());
                }
                return "success";
            }
            catch (WebException e)
            {
                return e.ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

    }
}
