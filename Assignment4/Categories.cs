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
    class Categories
    {

        public ArrayList getCategories()
        {
            ArrayList al = new ArrayList();
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("temp.xml");
                XmlElement rootxml = doc.DocumentElement;
                XmlNodeList nl = rootxml.GetElementsByTagName("m:properties");

                int i = 0;
                foreach (XmlNode x in nl)
                {
                    if (i == 0)
                    {
                        XmlNodeList childs = x.ChildNodes;

                        foreach (XmlNode c in childs)
                        {
                            al.Add(c.LocalName);
                        }
                        i = 1;
                    }
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
