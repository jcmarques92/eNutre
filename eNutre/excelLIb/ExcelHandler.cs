using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;

namespace excelLIb
{
    public class ExcelHandler
    {

        public static void readCells(string path)
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
                XmlElement restaurantes = doc.CreateElement("restaurantes");
                eNutre.AppendChild(restaurantes);

                Excel.Application excelApplication = new Excel.Application();
                excelApplication.Visible = false;
                Excel.Workbook excelWorkBook = excelApplication.Workbooks.Open(path);
                Excel.Worksheet excelWorkSheet = excelWorkBook.Worksheets.get_Item(1);

                //string result;

                for (int i = 2; i < 125; i++)
                {
                    XmlElement restaurante = doc.CreateElement("restaurante");
                    XmlElement item = doc.CreateElement("item");
                    XmlElement quantidade = doc.CreateElement("quantidade");
                    XmlElement calorias = doc.CreateElement("calorias");

                    restaurante.SetAttribute("nome", Convert.ToString(excelWorkSheet.Cells[i, 1].Value));
                    item.InnerText = Convert.ToString(excelWorkSheet.Cells[i, 2].Value);
                    quantidade.InnerText = Convert.ToString(excelWorkSheet.Cells[i, 3].Value);
                    calorias.InnerText = Convert.ToString(excelWorkSheet.Cells[i, 4].Value);

                    restaurantes.AppendChild(restaurante);
                    restaurante.AppendChild(item);
                    restaurante.AppendChild(quantidade);
                    restaurante.AppendChild(calorias);
                }
                excelWorkBook.Close();
                excelApplication.Quit();
                doc.Save(@"restaurante-calorias.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ficheiro não encontrado: " + ex.Message);
            }
        }


    }
}
