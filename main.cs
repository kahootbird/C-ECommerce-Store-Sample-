using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

public class Program {

  public static void Main(string[] args) {
    /*
    XmlDocument Doc = new XmlDocument();
    Doc.Load("booklist.xml");
    Doc.Save(Console.Out);
    */
    XmlTextReader xmltxtread = new XmlTextReader("booklist.xml");

      Console.WriteLine("END");
    while (xmltxtread.Read())
    {
      //Console.WriteLine(xmltxtread.Name);
      //while (xmltxtread.NodeType == XmlNodeType.Element && xmltxtread.Name == "bookstore")

      if (xmltxtread.NodeType == XmlNodeType.Element && xmltxtread.Name == "price")
      {
        Console.WriteLine(xmltxtread.ReadElementString());
      }

    }
  }
}
