using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excelLIb;
using jsonLib;
using txtLib;

namespace eNutre
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            tbCaminhoExcel.Clear();
            tbCaminhoTxt.Clear();
            tbCaminhoJson.Clear();

            opExcel.InitialDirectory = Application.StartupPath;
            opExcel.Filter = "Excel Files|*.xls;*.xlsx";

            if (opExcel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbCaminhoExcel.Text = opExcel.FileName;
            }
            //versao2
            if (true)
            {

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btGerarXml_Click(object sender, EventArgs e)
        {
            if (!tbCaminhoTxt.Text.Equals(""))
            {
                TxtHandler.readTxt(tbCaminhoTxt.Text);
            }

            else if (!tbCaminhoJson.Text.Equals(""))
            {
                JsonHandler.readJson(tbCaminhoJson.Text);
            }

            else if (!tbCaminhoExcel.Text.Equals(""))
            {
                ExcelHandler.readCells(tbCaminhoExcel.Text);
            }            
        }

        private void btTxt_Click(object sender, EventArgs e)
        {
            tbCaminhoExcel.Clear();
            tbCaminhoTxt.Clear();
            tbCaminhoJson.Clear();

            opTxt.InitialDirectory = Application.StartupPath;
            opTxt.Filter = "Text files|*.txt";

            if (opTxt.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbCaminhoTxt.Text = opTxt.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JsonHandler.readJson(tbCaminhoJson.Text);
        }

        private void btJson_Click(object sender, EventArgs e)
        {
            tbCaminhoExcel.Clear();
            tbCaminhoTxt.Clear();
            tbCaminhoJson.Clear();

            opJson.InitialDirectory = Application.StartupPath;
            opJson.Filter = "Json files|*.js";

            if (opJson.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbCaminhoJson.Text = opJson.FileName;
            }
        }
    }
}
