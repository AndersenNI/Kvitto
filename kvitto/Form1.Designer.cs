namespace kvitto
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
            this.SuspendLayout();
            // 
            // txtboxNamn
            // 
            this.txtboxNamn.Location = new System.Drawing.Point(13, 13);
            this.txtboxNamn.Name = "txtboxNamn";
            this.txtboxNamn.Size = new System.Drawing.Size(185, 20);
            this.txtboxNamn.TabIndex = 0;
            this.txtboxNamn.Text = "Namn";
            this.txtboxNamn.Click += new System.EventHandler(this.txtboxNamn_Click);
            // 
            // txtboxModell
            // 
            this.txtboxModell.Location = new System.Drawing.Point(13, 39);
            this.txtboxModell.Name = "txtboxModell";
            this.txtboxModell.Size = new System.Drawing.Size(185, 20);
            this.txtboxModell.TabIndex = 1;
            this.txtboxModell.Text = "Modell";
            this.txtboxModell.Click += new System.EventHandler(this.txtboxModell_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSkrivut
            // 
            this.btnSkrivut.Location = new System.Drawing.Point(106, 289);
            this.btnSkrivut.Name = "btnSkrivut";
            this.btnSkrivut.Size = new System.Drawing.Size(92, 23);
            this.btnSkrivut.TabIndex = 7;
            this.btnSkrivut.Text = "Skriv Ut";
            this.btnSkrivut.UseVisualStyleBackColor = true;
            this.btnSkrivut.Click += new System.EventHandler(this.btnSkrivut_Click);
            // 
            // txtboxAnnat
            // 
            this.txtboxAnnat.Location = new System.Drawing.Point(67, 194);
            this.txtboxAnnat.Name = "txtboxAnnat";
            this.txtboxAnnat.Size = new System.Drawing.Size(131, 20);
            this.txtboxAnnat.TabIndex = 4;
            this.txtboxAnnat.Click += new System.EventHandler(this.txtboxAnnat_Click);
            this.txtboxAnnat.TextChanged += new System.EventHandler(this.txtboxAnnat_TextChanged);
            // 
            // chkboxFelsökning
            // 
            this.chkboxFelsökning.AutoSize = true;
            this.chkboxFelsökning.Location = new System.Drawing.Point(13, 94);
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
            this.chkboxUpplåsning.Location = new System.Drawing.Point(13, 118);
            this.chkboxUpplåsning.Name = "chkboxUpplåsning";
            this.chkboxUpplåsning.Size = new System.Drawing.Size(79, 17);
            this.chkboxUpplåsning.TabIndex = 13;
            this.chkboxUpplåsning.Text = "Upplåsning";
            this.chkboxUpplåsning.UseVisualStyleBackColor = true;
            // 
            // chkboxAnnat
            // 
            this.chkboxAnnat.AutoSize = true;
            this.chkboxAnnat.Location = new System.Drawing.Point(13, 142);
            this.chkboxAnnat.Name = "chkboxAnnat";
            this.chkboxAnnat.Size = new System.Drawing.Size(54, 17);
            this.chkboxAnnat.TabIndex = 14;
            this.chkboxAnnat.Text = "Annat";
            this.chkboxAnnat.UseVisualStyleBackColor = true;
            this.chkboxAnnat.CheckedChanged += new System.EventHandler(this.chkboxAnnat_CheckedChanged);
            // 
            // rtxtboxAnnat
            // 
            this.rtxtboxAnnat.Location = new System.Drawing.Point(98, 92);
            this.rtxtboxAnnat.Name = "rtxtboxAnnat";
            this.rtxtboxAnnat.Size = new System.Drawing.Size(100, 96);
            this.rtxtboxAnnat.TabIndex = 3;
            this.rtxtboxAnnat.Text = "vad?";
            this.rtxtboxAnnat.Visible = false;
            this.rtxtboxAnnat.Click += new System.EventHandler(this.rtxtboxAnnat_Click);
            // 
            // txtboxIMEI
            // 
            this.txtboxIMEI.Location = new System.Drawing.Point(13, 221);
            this.txtboxIMEI.Name = "txtboxIMEI";
            this.txtboxIMEI.Size = new System.Drawing.Size(185, 20);
            this.txtboxIMEI.TabIndex = 5;
            this.txtboxIMEI.Text = "IMEI Nummer";
            this.txtboxIMEI.Click += new System.EventHandler(this.txtboxIMEI_Click);
            // 
            // txtboxTlfnr
            // 
            this.txtboxTlfnr.Location = new System.Drawing.Point(13, 66);
            this.txtboxTlfnr.Name = "txtboxTlfnr";
            this.txtboxTlfnr.Size = new System.Drawing.Size(185, 20);
            this.txtboxTlfnr.TabIndex = 2;
            this.txtboxTlfnr.Text = "Telefon Nummer";
            this.txtboxTlfnr.Click += new System.EventHandler(this.txtboxTlfnr_Click);
            // 
            // txtboxPris
            // 
            this.txtboxPris.Location = new System.Drawing.Point(46, 254);
            this.txtboxPris.Name = "txtboxPris";
            this.txtboxPris.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtboxPris.Size = new System.Drawing.Size(151, 20);
            this.txtboxPris.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pris:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lösenord";
            // 
            // btnläggtill
            // 
            this.btnläggtill.Location = new System.Drawing.Point(13, 318);
            this.btnläggtill.Name = "btnläggtill";
            this.btnläggtill.Size = new System.Drawing.Size(184, 29);
            this.btnläggtill.TabIndex = 22;
            this.btnläggtill.Text = "lägg till i databas";
            this.btnläggtill.UseVisualStyleBackColor = true;
            this.btnläggtill.Click += new System.EventHandler(this.btnläggtill_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(204, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(391, 335);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 355);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnläggtill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxPris);
            this.Controls.Add(this.txtboxTlfnr);
            this.Controls.Add(this.txtboxIMEI);
            this.Controls.Add(this.rtxtboxAnnat);
            this.Controls.Add(this.chkboxAnnat);
            this.Controls.Add(this.chkboxUpplåsning);
            this.Controls.Add(this.chkboxFelsökning);
            this.Controls.Add(this.txtboxAnnat);
            this.Controls.Add(this.btnSkrivut);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtboxModell);
            this.Controls.Add(this.txtboxNamn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "b";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

