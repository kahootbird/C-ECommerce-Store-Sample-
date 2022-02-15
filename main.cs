using System;
using System.Xml;
//github: https://github.com/kahootbird/C-ECommerce-Store-Sample-
//This program reads booklist.xml and prints the book title and price then the sum of all prices
public class Program {

  public static void Main(string[] args) {
    //Read booklist.xml
    XmlTextReader xmltxtread = new XmlTextReader("booklist.xml");
    double price = 0;
    var str = "";

    Console.WriteLine("List of all book titles, price, and price of all books combined");
    while (xmltxtread.Read())
    {
      //Read book title then price and print each
      if (xmltxtread.NodeType == XmlNodeType.Element && xmltxtread.Name == "title")
      {
        Console.WriteLine(xmltxtread.ReadElementString());
      }
      if (xmltxtread.NodeType == XmlNodeType.Element && xmltxtread.Name == "price")
      {
        //Ideally use try catch on double, for this simplified example I'm avoiding it
        str = xmltxtread.ReadElementString();
        var price2double = Convert.ToDouble(str);
        Console.WriteLine("$" + str);
        price += price2double;
      }
    }
    Console.WriteLine("Price of all books is: " + price);
  }
}
