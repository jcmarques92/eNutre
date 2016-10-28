using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace jsonLib
{
    public class JsonHandler
    {

        public static void readJson(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                string json;

                using (StreamReader r = new StreamReader(path))
                {
                    json = r.ReadToEnd();
                }

                using (var reader = JsonReaderWriterFactory.CreateJsonReader(Encoding.UTF8.GetBytes(json), XmlDictionaryReaderQuotas.Max))
                {
                    XElement xml = XElement.Load(reader);
                    doc.LoadXml(xml.ToString());
                }

                doc.Save(@"calorias_exercicios.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ficheiro não encontrado: " + ex.Message);
            }
        }
    }
}
