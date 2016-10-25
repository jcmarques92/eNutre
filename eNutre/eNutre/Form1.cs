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
            ExcelHandler.readCells(tbCaminhoExcel.Text);
        }
    }
}
