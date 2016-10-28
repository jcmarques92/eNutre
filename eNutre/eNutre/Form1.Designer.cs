namespace eNutre
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbCaminhoExcel = new System.Windows.Forms.TextBox();
            this.btExcel = new System.Windows.Forms.Button();
            this.opExcel = new System.Windows.Forms.OpenFileDialog();
            this.btGerarXml = new System.Windows.Forms.Button();
            this.btTxt = new System.Windows.Forms.Button();
            this.tbCaminhoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opTxt = new System.Windows.Forms.OpenFileDialog();
            this.btJson = new System.Windows.Forms.Button();
            this.tbCaminhoJson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.opJson = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carregar Ficheiro Excel";
            // 
            // tbCaminhoExcel
            // 
            this.tbCaminhoExcel.Location = new System.Drawing.Point(133, 32);
            this.tbCaminhoExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCaminhoExcel.Name = "tbCaminhoExcel";
            this.tbCaminhoExcel.Size = new System.Drawing.Size(229, 20);
            this.tbCaminhoExcel.TabIndex = 1;
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(384, 32);
            this.btExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(86, 19);
            this.btExcel.TabIndex = 2;
            this.btExcel.Text = "...";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // opExcel
            // 
            this.opExcel.FileName = "opEcxel";
            this.opExcel.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btGerarXml
            // 
            this.btGerarXml.Location = new System.Drawing.Point(199, 225);
            this.btGerarXml.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btGerarXml.Name = "btGerarXml";
            this.btGerarXml.Size = new System.Drawing.Size(86, 19);
            this.btGerarXml.TabIndex = 3;
            this.btGerarXml.Text = "Gerar XML";
            this.btGerarXml.UseVisualStyleBackColor = true;
            this.btGerarXml.Click += new System.EventHandler(this.btGerarXml_Click);
            // 
            // btTxt
            // 
            this.btTxt.Location = new System.Drawing.Point(384, 80);
            this.btTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTxt.Name = "btTxt";
            this.btTxt.Size = new System.Drawing.Size(86, 19);
            this.btTxt.TabIndex = 6;
            this.btTxt.Text = "...";
            this.btTxt.UseVisualStyleBackColor = true;
            this.btTxt.Click += new System.EventHandler(this.btTxt_Click);
            // 
            // tbCaminhoTxt
            // 
            this.tbCaminhoTxt.Location = new System.Drawing.Point(133, 80);
            this.tbCaminhoTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCaminhoTxt.Name = "tbCaminhoTxt";
            this.tbCaminhoTxt.Size = new System.Drawing.Size(229, 20);
            this.tbCaminhoTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carregar Ficheiro txt";
            // 
            // opTxt
            // 
            this.opTxt.FileName = "opTxt";
            // 
            // btJson
            // 
            this.btJson.Location = new System.Drawing.Point(384, 132);
            this.btJson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btJson.Name = "btJson";
            this.btJson.Size = new System.Drawing.Size(86, 19);
            this.btJson.TabIndex = 9;
            this.btJson.Text = "...";
            this.btJson.UseVisualStyleBackColor = true;
            this.btJson.Click += new System.EventHandler(this.btJson_Click);
            // 
            // tbCaminhoJson
            // 
            this.tbCaminhoJson.Location = new System.Drawing.Point(133, 132);
            this.tbCaminhoJson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCaminhoJson.Name = "tbCaminhoJson";
            this.tbCaminhoJson.Size = new System.Drawing.Size(229, 20);
            this.tbCaminhoJson.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carregar Ficheiro JSON";
            // 
            // opJson
            // 
            this.opJson.FileName = "opJson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 254);
            this.Controls.Add(this.btJson);
            this.Controls.Add(this.tbCaminhoJson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btTxt);
            this.Controls.Add(this.tbCaminhoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btGerarXml);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.tbCaminhoExcel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "eNutre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCaminhoExcel;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.OpenFileDialog opExcel;
        private System.Windows.Forms.Button btGerarXml;
        private System.Windows.Forms.Button btTxt;
        private System.Windows.Forms.TextBox tbCaminhoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog opTxt;
        private System.Windows.Forms.Button btJson;
        private System.Windows.Forms.TextBox tbCaminhoJson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog opJson;
    }
}

