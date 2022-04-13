using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace LatefeeCalc_c0842810
{
    public static class RentalItemDB
    {
        private const string Path = @"..\..\RentalItems.xml";

        public static List<RentalItem> GetMovies()
        {
            // create the list
            List<RentalItem> rentalItems = new List<RentalItem>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first RentalItem node
            if (xmlIn.ReadToDescendant("RentalItem"))
            {
                // create one RentalItem object for each RentalItem node
                do
                {
                    RentalItem rentalItem = new RentalItem();
                    xmlIn.ReadStartElement("RentalItem");
                    rentalItem.MovieNo =
                        xmlIn.ReadElementContentAsInt();
                    rentalItem.Description =
                        xmlIn.ReadElementContentAsString();
                    rentalItem.Rating =
                        xmlIn.ReadElementContentAsString();
                    rentalItems.Add(rentalItem);
                }
                while (xmlIn.ReadToNextSibling("RentalItem"));
            }

            // close the XmlReader object
            xmlIn.Close();

            return rentalItems;
        }

        public static void SaveRentalItems(List<RentalItem> rentalItems)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("RentalItems");

            // write each rentalItem object to the xml file
            foreach (RentalItem rentalItem in rentalItems)
            {
                xmlOut.WriteStartElement("RentalItem");
                xmlOut.WriteElementString("StockNo",
                    Convert.ToString(rentalItem.MovieNo));
                xmlOut.WriteElementString("Description",
                    rentalItem.Description);
                xmlOut.WriteElementString("Rating",
                    rentalItem.Rating);
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}
