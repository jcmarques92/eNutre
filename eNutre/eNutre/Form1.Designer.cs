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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carregar Ficheiro Excel";
            // 
            // tbCaminhoExcel
            // 
            this.tbCaminhoExcel.Location = new System.Drawing.Point(177, 40);
            this.tbCaminhoExcel.Name = "tbCaminhoExcel";
            this.tbCaminhoExcel.Size = new System.Drawing.Size(304, 22);
            this.tbCaminhoExcel.TabIndex = 1;
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(512, 40);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(114, 23);
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
            this.btGerarXml.Location = new System.Drawing.Point(259, 99);
            this.btGerarXml.Name = "btGerarXml";
            this.btGerarXml.Size = new System.Drawing.Size(114, 23);
            this.btGerarXml.TabIndex = 3;
            this.btGerarXml.Text = "Gerar XML";
            this.btGerarXml.UseVisualStyleBackColor = true;
            this.btGerarXml.Click += new System.EventHandler(this.btGerarXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 490);
            this.Controls.Add(this.btGerarXml);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.tbCaminhoExcel);
            this.Controls.Add(this.label1);
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
    }
}

