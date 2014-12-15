using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
namespace CafeteriaAndRestaurant
{
   public class ReadXML
    {
       public string ReadXml(int key)
       {
           XElement xelement = XElement.Load("..\\..\\Message.xml");
           IEnumerable<XElement> message = xelement.Elements();
           string result = "";
           foreach (var l in message)
           {
               if (int.Parse(l.Element("key").Value) == key)
               {
                   result = l.Element("value").Value;
               }
           }
           return result;
       }
    }
}
