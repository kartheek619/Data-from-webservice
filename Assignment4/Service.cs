using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Assignment4
{
    class Service
    {
        public ArrayList  getServices()
        {
            ArrayList al = new ArrayList();
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load("temp.xml");
                XmlElement rootxml = doc.DocumentElement;
                XmlNodeList nl = rootxml.GetElementsByTagName("collection");

                foreach (XmlNode x in nl)
                {
                    al.Add(x.Attributes["href"].Value);
                }

                return al;
            }
            catch (XmlException e)
            {
                al.Add("ERROR");
                al.Add("XML Exception has occured! Please contact system administrator.");
                return al;
            }
            catch (FileNotFoundException e)
            {
                al.Add("ERROR");
                al.Add("Unable to get data from backend! Please contact system administrator.");
                return al;
            }
            catch
            {
                al.Add("ERROR");
                al.Add("Unknown error! Please contact system administrator");
                return al;
            }
        }

    }
}
