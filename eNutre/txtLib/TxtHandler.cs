using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace txtLib
{
    public class TxtHandler
    {

        public static void readTxt(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                // Create the XML Declaration, and append it to XML document
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
                doc.AppendChild(dec);
                // Create the root element
                XmlElement eNutre = doc.CreateElement("eNutre");
                doc.AppendChild(eNutre);

                string[] lines = System.IO.File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    XmlElement calorias = doc.CreateElement("calorias");

                    calorias.InnerText = Convert.ToString(line);

                    eNutre.AppendChild(calorias);
                }
                
                doc.Save(@"calorias_vegetais.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ficheiro não encontrado: " + ex.Message);
            }
        }

    }
}
