using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace Assignment4
{
    class Data
    {
        public ArrayList getdata()
        {
                ArrayList data = new ArrayList();
                DataTable tab = new DataTable();
                XmlDocument doc = new XmlDocument();

                try
                {
                    doc.Load("temp.xml");
                    XmlElement rootxml = doc.DocumentElement;
                    XmlNodeList nl1 = rootxml.GetElementsByTagName("m:properties");
                    int i = 0;
                    foreach (XmlNode x in nl1)
                    {
                        DataRow row = tab.NewRow();
                        XmlNodeList nl2 = x.ChildNodes;
                        if (i == 0)
                        {
                            foreach (XmlNode y in nl2)
                            {
                                tab.Columns.Add(y.LocalName);
                                i = 1;
                            }
                        }
                        foreach (XmlNode z in nl2)
                        {
                            row[z.LocalName] = z.InnerText;
                        }
                        tab.Rows.Add(row);
                    };
                    data.Add("success");
                    data.Add(tab);
                    return data;
                }
                catch (XmlException e)
                {
                    data.Add("XML Exception has occured! Failed to get data!");
                    return data;
                }
                catch (FileNotFoundException e)
                {
                    data.Add("Unable to retrive data from backend system! Please contact system administrator");
                    return data;
                }
                catch
                {
                    data.Add("An unknown error has occured! Please contact administrator!");
                    return data;
                }
                
        }

    }
}
