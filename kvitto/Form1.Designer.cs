namespace kvitto
{
    partial class Kvitto
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
            this.txtboxNamn = new System.Windows.Forms.TextBox();
            this.txtboxModell = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSkrivut = new System.Windows.Forms.Button();
            this.txtboxAnnat = new System.Windows.Forms.TextBox();
            this.chkboxFelsökning = new System.Windows.Forms.CheckBox();
            this.chkboxUpplåsning = new System.Windows.Forms.CheckBox();
            this.chkboxAnnat = new System.Windows.Forms.CheckBox();
            this.rtxtboxAnnat = new System.Windows.Forms.RichTextBox();
            this.txtboxIMEI = new System.Windows.Forms.TextBox();
            this.txtboxTlfnr = new System.Windows.Forms.TextBox();
            this.txtboxPris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnläggtill = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttoncleartext = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxNamn
            // 
            this.txtboxNamn.Location = new System.Drawing.Point(6, 6);
            this.txtboxNamn.Name = "txtboxNamn";
            this.txtboxNamn.Size = new System.Drawing.Size(185, 20);
            this.txtboxNamn.TabIndex = 0;
            this.txtboxNamn.Text = "Namn";
            this.txtboxNamn.Click += new System.EventHandler(this.txtboxNamn_Click);
            // 
            // txtboxModell
            // 
            this.txtboxModell.Location = new System.Drawing.Point(6, 32);
            this.txtboxModell.Name = "txtboxModell";
            this.txtboxModell.Size = new System.Drawing.Size(185, 20);
            this.txtboxModell.TabIndex = 1;
            this.txtboxModell.Text = "Modell";
            this.txtboxModell.Click += new System.EventHandler(this.txtboxModell_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSkrivut
            // 
            this.btnSkrivut.Location = new System.Drawing.Point(99, 282);
            this.btnSkrivut.Name = "btnSkrivut";
            this.btnSkrivut.Size = new System.Drawing.Size(92, 23);
            this.btnSkrivut.TabIndex = 7;
            this.btnSkrivut.Text = "Skriv Ut";
            this.btnSkrivut.UseVisualStyleBackColor = true;
            this.btnSkrivut.Click += new System.EventHandler(this.btnSkrivut_Click);
            // 
            // txtboxAnnat
            // 
            this.txtboxAnnat.Location = new System.Drawing.Point(60, 187);
            this.txtboxAnnat.Name = "txtboxAnnat";
            this.txtboxAnnat.Size = new System.Drawing.Size(131, 20);
            this.txtboxAnnat.TabIndex = 4;
            this.txtboxAnnat.Click += new System.EventHandler(this.txtboxAnnat_Click);
            this.txtboxAnnat.TextChanged += new System.EventHandler(this.txtboxAnnat_TextChanged);
            // 
            // chkboxFelsökning
            // 
            this.chkboxFelsökning.AutoSize = true;
            this.chkboxFelsökning.Location = new System.Drawing.Point(6, 87);
            this.chkboxFelsökning.Name = "chkboxFelsökning";
            this.chkboxFelsökning.Size = new System.Drawing.Size(77, 17);
            this.chkboxFelsökning.TabIndex = 12;
            this.chkboxFelsökning.Text = "Felsökning";
            this.chkboxFelsökning.UseVisualStyleBackColor = true;
            this.chkboxFelsökning.CheckedChanged += new System.EventHandler(this.chkboxFelsökning_CheckedChanged);
            // 
            // chkboxUpplåsning
            // 
            this.chkboxUpplåsning.AutoSize = true;
            this.chkboxUpplåsning.Location = new System.Drawing.Point(6, 111);
            this.chkboxUpplåsning.Name = "chkboxUpplåsning";
            this.chkboxUpplåsning.Size = new System.Drawing.Size(79, 17);
            this.chkboxUpplåsning.TabIndex = 13;
            this.chkboxUpplåsning.Text = "Upplåsning";
            this.chkboxUpplåsning.UseVisualStyleBackColor = true;
            // 
            // chkboxAnnat
            // 
            this.chkboxAnnat.AutoSize = true;
            this.chkboxAnnat.Location = new System.Drawing.Point(6, 135);
            this.chkboxAnnat.Name = "chkboxAnnat";
            this.chkboxAnnat.Size = new System.Drawing.Size(54, 17);
            this.chkboxAnnat.TabIndex = 14;
            this.chkboxAnnat.Text = "Annat";
            this.chkboxAnnat.UseVisualStyleBackColor = true;
            this.chkboxAnnat.CheckedChanged += new System.EventHandler(this.chkboxAnnat_CheckedChanged);
            // 
            // rtxtboxAnnat
            // 
            this.rtxtboxAnnat.Location = new System.Drawing.Point(91, 85);
            this.rtxtboxAnnat.Name = "rtxtboxAnnat";
            this.rtxtboxAnnat.Size = new System.Drawing.Size(100, 96);
            this.rtxtboxAnnat.TabIndex = 3;
            this.rtxtboxAnnat.Text = "vad?";
            this.rtxtboxAnnat.Visible = false;
            this.rtxtboxAnnat.Click += new System.EventHandler(this.rtxtboxAnnat_Click);
            // 
            // txtboxIMEI
            // 
            this.txtboxIMEI.Location = new System.Drawing.Point(6, 214);
            this.txtboxIMEI.Name = "txtboxIMEI";
            this.txtboxIMEI.Size = new System.Drawing.Size(185, 20);
            this.txtboxIMEI.TabIndex = 5;
            this.txtboxIMEI.Text = "IMEI Nummer";
            this.txtboxIMEI.Click += new System.EventHandler(this.txtboxIMEI_Click);
            // 
            // txtboxTlfnr
            // 
            this.txtboxTlfnr.Location = new System.Drawing.Point(6, 59);
            this.txtboxTlfnr.Name = "txtboxTlfnr";
            this.txtboxTlfnr.Size = new System.Drawing.Size(185, 20);
            this.txtboxTlfnr.TabIndex = 2;
            this.txtboxTlfnr.Text = "Telefon Nummer";
            this.txtboxTlfnr.Click += new System.EventHandler(this.txtboxTlfnr_Click);
            // 
            // txtboxPris
            // 
            this.txtboxPris.Location = new System.Drawing.Point(39, 247);
            this.txtboxPris.Name = "txtboxPris";
            this.txtboxPris.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtboxPris.Size = new System.Drawing.Size(151, 20);
            this.txtboxPris.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pris:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lösenord";
            // 
            // btnläggtill
            // 
            this.btnläggtill.Location = new System.Drawing.Point(6, 311);
            this.btnläggtill.Name = "btnläggtill";
            this.btnläggtill.Size = new System.Drawing.Size(184, 29);
            this.btnläggtill.TabIndex = 22;
            this.btnläggtill.Text = "lägg till i databas";
            this.btnläggtill.UseVisualStyleBackColor = true;
            this.btnläggtill.Click += new System.EventHandler(this.btnläggtill_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(333, 335);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(345, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(345, 33);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "GET";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1143, 603);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtboxNamn);
            this.tabPage1.Controls.Add(this.txtboxModell);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSkrivut);
            this.tabPage1.Controls.Add(this.btnläggtill);
            this.tabPage1.Controls.Add(this.txtboxAnnat);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chkboxFelsökning);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chkboxUpplåsning);
            this.tabPage1.Controls.Add(this.txtboxPris);
            this.tabPage1.Controls.Add(this.chkboxAnnat);
            this.tabPage1.Controls.Add(this.txtboxTlfnr);
            this.tabPage1.Controls.Add(this.rtxtboxAnnat);
            this.tabPage1.Controls.Add(this.txtboxIMEI);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1135, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Print";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttoncleartext);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1135, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(345, 324);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "ON/OFF";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "The Symbols must remain for the program to work";
            // 
            // buttoncleartext
            // 
            this.buttoncleartext.Location = new System.Drawing.Point(345, 62);
            this.buttoncleartext.Name = "buttoncleartext";
            this.buttoncleartext.Size = new System.Drawing.Size(75, 23);
            this.buttoncleartext.TabIndex = 28;
            this.buttoncleartext.Text = "Clear text";
            this.buttoncleartext.UseVisualStyleBackColor = true;
            this.buttoncleartext.Click += new System.EventHandler(this.buttoncleartext_Click);
            // 
            // Kvitto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 415);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kvitto";
            this.Text = "kvitto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNamn;
        private System.Windows.Forms.TextBox txtboxModell;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSkrivut;
        private System.Windows.Forms.TextBox txtboxAnnat;
        private System.Windows.Forms.CheckBox chkboxFelsökning;
        private System.Windows.Forms.CheckBox chkboxUpplåsning;
        private System.Windows.Forms.CheckBox chkboxAnnat;
        private System.Windows.Forms.RichTextBox rtxtboxAnnat;
        private System.Windows.Forms.TextBox txtboxIMEI;
        private System.Windows.Forms.TextBox txtboxTlfnr;
        private System.Windows.Forms.TextBox txtboxPris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnläggtill;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttoncleartext;
    }
}

