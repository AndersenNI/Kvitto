using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

 
namespace kvitto
{
    /*
    .____          .____     
    |    |    ____ |    |    
    |    |   /  _ \|    |    
    |    |__(  <_> )    |___ 
    |_______ \____/|_______ \
            \/             \/
    */


   /// <main>
   /// main class
   /// </main>
    public partial class Form1 : Form
    {
        #region klass globala variabler
        StringBuilder sb = new StringBuilder();
        string siffra;
        int count;
        string SlutText = null;
        #endregion 
        public Form1()
        {   
            InitializeComponent();
            slumpa();
        }
        #region textboxar
        private void txtboxNamn_Click(object sender, EventArgs e)
        {
            txtboxNamn.Text = ""; 
          
        }

        private void txtboxModell_Click(object sender, EventArgs e)
        {
            txtboxModell.Text = "";
        }

        private void txtboxAnnat_Click(object sender, EventArgs e)
        {
           txtboxAnnat.Text = "";
        }
        #endregion

        private void btnSkrivut_Click(object sender, EventArgs e)
        {
           // aktivera detta innan Release;:;
           //  textfil();
             read();
             Write();
        }

        #region kontroller

        private void btnClear_Click(object sender, EventArgs e)
        {
            //denna knapp rensar allt, ställer allt till default
            txtboxNamn.Text = "Namn";
            txtboxModell.Text = "Modell";
            txtboxAnnat.Text = "";
            txtboxTlfnr.Text = "Telefon Nummer";
            txtboxIMEI.Text = "IMEI Nummer";
            chkboxAnnat.Checked = false;
            chkboxFelsökning.Checked = false;
            chkboxUpplåsning.Checked = false;
            rtxtboxAnnat.Text = "Vad?";
            txtboxPris.Text = "";
            slumpa();
            sb.Clear();

            
        }

        private void chkboxAnnat_CheckedChanged(object sender, EventArgs e)
        {
            //kollar om textbox annat visas
            if (rtxtboxAnnat.Visible == false)
            {
                rtxtboxAnnat.Visible = true;
            }
            else
            {
                rtxtboxAnnat.Visible = false;
            }
        }

        private void chkboxFelsökning_CheckedChanged(object sender, EventArgs e)
        {
            //samma som uppe
            if (rtxtboxAnnat.Visible == false)
            {
                rtxtboxAnnat.Visible = true;
            }
            else
            {
                rtxtboxAnnat.Visible = false;
            }
        }

        private void txtboxAnnat_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtboxIMEI_Click(object sender, EventArgs e)
        {
            txtboxIMEI.Text = "";
        }

        private void txtboxTlfnr_Click(object sender, EventArgs e)
        {
            txtboxTlfnr.Text = "";
        }

        private void rtxtboxAnnat_Click(object sender, EventArgs e)
        {
            rtxtboxAnnat.Text = "";
        }
        #endregion
        #region skrivut och databas
        
        public void printdocument()
        {
            //slumpa();//slumpa siffra

            string extra=" ";
            string tjänst=" ";
            if (chkboxFelsökning.Checked == true)
            { tjänst = "Felsökning";
            extra = rtxtboxAnnat.Text;
            }
            else if (chkboxUpplåsning.Checked == true)
            { tjänst = "Upplåsning"; }
            else
            {
                tjänst = "Annat";
                extra = rtxtboxAnnat.Text;
            }

            PCPrint p=new PCPrint();

            p.PrinterFont = new Font("Verdana", 10);
            string text = " @@@@---inlämningskvitto---@@ Namn:" + txtboxNamn.Text + "@ modell: " + txtboxModell.Text + "@ Tjänst:" + tjänst + "@ Instruktion: " + extra + "@ Lösenord: " + txtboxAnnat.Text + "@ IMEI/Snr: " + txtboxIMEI.Text + "@- - - - - - - - - - - - - @" + " Telefon:" + txtboxTlfnr.Text + "@- - - - - - - - - - - - - " + "@ Pris: " + txtboxPris.Text + "kr" + "@- - - - - - - - - - - - - @ Detta kvitto måste uppvisas vid  upphämtning@" +" kvittonummer: "+ siffra + "@- - - - - - - - - - - - - @ "+" ";
            text = text.Replace("@", Environment.NewLine);
            
            p.PrinterFont2 = new Font("verdana", 35);
            p.TextToPrint = sb.ToString();
            p.TextToPrint2 = siffra;
           
           p.Print();
        }

       
        public void slumpa()
        {
            DateTime today=DateTime.Today;
            string datum;
            string dag;
            datum = today.Month.ToString();
            dag = today.Day.ToString();
            siffra = datum + dag+count.ToString();
            Random r=new Random();
            siffra+=r.Next(0,999).ToString();
            count++;         
        }
        public void textfil()
        {

            string extra = " ";
            string tjänst = " ";
            if (chkboxFelsökning.Checked == true)
            {
                tjänst = "Felsökning";
                extra = rtxtboxAnnat.Text;
            }
            else if (chkboxUpplåsning.Checked == true)
            { tjänst = "Upplåsning"; }
            else
            {
                tjänst = "Annat";
                extra = rtxtboxAnnat.Text;
            }

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("---inlämningskvitto---");
            sb.AppendLine("Namn: " + txtboxNamn.Text);
            sb.AppendLine("Modell:" + txtboxModell.Text);
            sb.AppendLine("Tjänst: " + tjänst);
            sb.AppendLine("Instruktion: " + extra);
            sb.AppendLine("Lösenord: "+txtboxAnnat.Text);
            sb.AppendLine("IMEI/Snr: " + txtboxIMEI.Text);
            sb.AppendLine("-----------");
            sb.AppendLine("Telefon:" + txtboxTlfnr.Text);
            sb.AppendLine("Pris: "+txtboxPris.Text);
            sb.AppendLine("Detta kvitto måste uppvisas vid  upphämtning");
            sb.AppendLine("kvittonummer:" + siffra);

          //  richTextBox1.Text = sb.ToString();
           // printdocument();
            read();
            Write();
        }
        SqlConnection conn;

        public void läggtill()
        {
            conn = new SqlConnection();

            
            string sql = "INSERT INTO dbo.Kunder VALUES (@ID,@Kundnamn,@Kundtelefon,@Modell,@Lösenord,@IMEInummer,@Pris,@instruktion)";
          
            

            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.Add("@ID",SqlDbType.Int);
            cmd.Parameters["@ID"].Value = int.Parse(siffra);
            cmd.Parameters.Add("@Kundnamn", SqlDbType.NVarChar);
            cmd.Parameters["@Kundnamn"].Value = txtboxNamn.Text;
            cmd.Parameters.Add("@Kundtelefon", SqlDbType.NVarChar);
            cmd.Parameters["@Kundtelefon"].Value = txtboxTlfnr.Text;
            cmd.Parameters.Add("@Modell", SqlDbType.NVarChar);
            cmd.Parameters["@Modell"].Value = txtboxModell.Text;
            cmd.Parameters.Add("@Lösenord", SqlDbType.NVarChar);
            cmd.Parameters["@Lösenord"].Value = txtboxAnnat.Text;
            cmd.Parameters.Add("@IMEInummer", SqlDbType.NVarChar);
            cmd.Parameters["@IMEInummer"].Value = txtboxIMEI.Text;
            cmd.Parameters.Add("@Pris", SqlDbType.NVarChar);
            cmd.Parameters["@Pris"].Value = txtboxPris.Text;
            cmd.Parameters.Add("@instruktion", SqlDbType.NVarChar);
            cmd.Parameters["@instruktion"].Value = rtxtboxAnnat.Text;

            conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dell\documents\visual studio 2013\Projects\kvitto\kvitto\Database1.mdf;Integrated Security=True";                              
                      // öppnar connection till databas :)
              conn.Open(); 
                
                //jippi det funkar
                cmd.ExecuteNonQuery();
                   
            conn.Close();
            

        }

        private void btnläggtill_Click(object sender, EventArgs e)
        {
            upload();
           // läggtill(); 
            
            
        }
        #endregion

        #region upp
        //funktion för att uppa grejerna till db, menat att använad efter Läggtill()..
        public void upload()
        {
            string connestring=null;
            connestring = "Server = 83.168.226.23;Database =db1217944_kundkvitto; Uid =u1217944_alex; Pwd =Nallen784;";
            // connestring = "SERVER=83.168.226.23;DATABASE=db1217944_kundkvitto;UID=;Pwd=;";   *old*
            
            //"Data Source=;Initial Catalog=db1217944_kundkvitto;User ID=u1217944_alex;Password=Nallen784";*old*
            string komando = "INSERT INTO `test` (`name`, `phone`, `model`, `service`, `instruction`, `finnish`, `price`, `message`, `imei`, `date`) VALUES(@namn,@phone,@model,@service,@instruction,@finnish,@price,@message,@imei,@date)";
            SqlConnection cnn;
            cnn = new SqlConnection();
            cnn.ConnectionString = connestring;
            SqlCommand cmd = new SqlCommand(komando, cnn);
            #region check hantering
            string tjänst=" ";
            if (chkboxFelsökning.Checked == true)
            { 
                tjänst = "Felsökning";
            }
            else if (chkboxUpplåsning.Checked == true)
            { 
                tjänst = "Upplåsning";
            }
            else
            {
                tjänst = "Annat";

            }
            #endregion 
            #region parameters
            // parametrar till uppload()
            cmd.Parameters.Add("@namn", SqlDbType.VarChar);
            cmd.Parameters["@namn"].Value = txtboxNamn.Text;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar);
            cmd.Parameters["@phone"].Value = txtboxTlfnr.Text;
            cmd.Parameters.Add("@model", SqlDbType.VarChar);
            cmd.Parameters["@model"].Value = txtboxModell.Text;
            cmd.Parameters.Add("@service", SqlDbType.VarChar);
            cmd.Parameters["@service"].Value = tjänst;
            cmd.Parameters.Add("@instruction", SqlDbType.VarChar);
            cmd.Parameters["@instruction"].Value = txtboxAnnat.Text;
            cmd.Parameters.Add("@finnish", SqlDbType.VarChar);
            cmd.Parameters["@finnish"].Value = " ";
            cmd.Parameters.Add("@price", SqlDbType.VarChar);
            cmd.Parameters["@price"].Value = txtboxPris.Text;
            cmd.Parameters.Add("@message", SqlDbType.VarChar);
            cmd.Parameters["@message"].Value = rtxtboxAnnat.Text;
            cmd.Parameters.Add("@imei", SqlDbType.VarChar);
            cmd.Parameters["@imei"].Value = txtboxIMEI.Text;
            cmd.Parameters.Add("@date", SqlDbType.VarChar);
            cmd.Parameters["@date"].Value = DateTime.Now;
            #endregion
            StringBuilder errorMessages = new StringBuilder();
            #region tryConn
            // ett try block-säkerhetsskull, öppnar conn, öppnar messagebox
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery(); 
                MessageBox.Show("ConnOpen!");
                cnn.Close();
            }
#endregion
        #region catchConn
            catch (SqlException ex )
            {
                //felrapportering, ifall det inte funkar som det ska
                 MessageBox.Show("DoesNotWork");
                 for (int i = 0; i < ex.Errors.Count; i++)
                 {
                     errorMessages.Append("Index #" + i + "\n" +
                         "Message: " + ex.Errors[i].Message + "\n" +
                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                         "Source: " + ex.Errors[i].Source + "\n" +
                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                   
                 }
                //
                 MessageBox.Show(errorMessages.ToString());
              // ehh
               Application.Exit();
            }
#endregion
        }
        #endregion


        #region txt
        #region read()
        public void read()
                {
                    StringBuilder sbb = new StringBuilder();
                    
                    using (StreamReader sr = new StreamReader("mall.txt",Encoding.Default))
                    {
                        while (sr.Peek() >= 0)
                        {
                            sbb.AppendLine(sr.ReadLine());

                        }

                    }
                    SlutText = sbb.ToString();
                    
                }
        #endregion
        #region Write
        public void Write()
        {
            string text = SlutText;
            text.Replace("@@@","");
           /* text.Replace("£££", txtboxModell.Text);
            text.Replace("$$$", "temp");
            text.Replace("&&&", txtboxAnnat.Text);
            text.Replace("¤¤¤", txtboxIMEI.Text);
            text.Replace("###", txtboxTlfnr.Text);
            text.Replace("@£@", txtboxPris.Text);
            text.Replace("@$$", siffra);
            */
            SlutText = text;
            richTextBox1.Text = text;


        }
        #endregion

        #endregion
    }
    ///
    ///det som ska göras är att få kontakt med databasen på crystone, sen mata data dit, sen bör det vara klart
    ///
//Nichlas Andersen 2015
    
    /// <summary>
    ///             Skrivarklass som tar hand om skrivaren.
    /// </summary>
    public class PCPrint : System.Drawing.Printing.PrintDocument
    {
        #region  Property Variables
        /// <summary>
        /// Property variable for the Font the user wishes to use
        /// </summary>
        /// <remarks></remarks>
        private Font _font;
        private Font _font2;

        /// <summary>
        /// Property variable for the text to be printed
        /// </summary>
        /// <remarks></remarks>
        private string _text;
        private string _text2;
        #endregion

        #region Static Local Variables
        /// <summary>
        /// Static variable to hold the current character
        /// we're currently dealing with.
        /// </summary>
        static int curChar;
        #endregion

        #region  Class Properties
        /// <summary>
        /// Property to hold the text that is to be printed
        /// </summary>
        /// <value></value>
        /// <returns>A string</returns>
        /// <remarks></remarks>
        public string TextToPrint
        {
            get { return _text; }
            set { _text = value; }
        }
        public string TextToPrint2
        {
            get { return _text2; }
            set { _text2 = value; }
        }

        /// <summary>
        /// Property to hold the font the users wishes to use
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Font PrinterFont
        {
            // Allows the user to override the default font
            get { return _font; }
            set { _font = value; }
        }
        public Font PrinterFont2
        {
            get { return _font2; }
            set { _font2 = value; }
        }
        #endregion

        #region  Class Constructors
        /// <summary>
        /// Empty constructor
        /// </summary>
        /// <remarks></remarks>
        public PCPrint()
            : base()
        {
            //Set the file stream
            //Instantiate out Text property to an empty string
            _text = string.Empty;
        }

        /// <summary>
        /// Constructor to initialize our printing object
        /// and the text it's supposed to be printing
        /// </summary>
        /// <param name=str>Text that will be printed</param>
        /// <remarks></remarks>
        public PCPrint(string str)
            : base()
        {
            //Set the file stream
            //Set our Text property value
            _text = str;
        }
        #endregion

        #region  OnBeginPrint
        /// <summary>
        /// Override the default OnBeginPrint method of the PrintDocument Object
        /// </summary>
        /// <param name=e></param>
        /// <remarks></remarks>
        protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e)
        {
            // Run base code
            base.OnBeginPrint(e);

            //Check to see if the user provided a font
            //if they didnt then we default to Times New Roman
            if (_font == null)
            {
                //Create the font we need
                _font = new Font("Times New Roman", 10);
            }
        }
        #endregion

        #region  OnPrintPage
        /// <summary>
        /// Override the default OnPrintPage method of the PrintDocument
        /// </summary>
        /// <param name=e></param>
        /// <remarks>This provides the print logic for our document</remarks>
        protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Run base code
            base.OnPrintPage(e);

            //Declare local variables needed

            int printHeight;
            int printWidth;
            int leftMargin;
            int rightMargin;
            Int32 lines;
            Int32 chars;

            //Set print area size and margins
            {
                printHeight = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top - base.DefaultPageSettings.Margins.Bottom;
                printWidth = base.DefaultPageSettings.PaperSize.Width;// -base.DefaultPageSettings.Margins.Left - base.DefaultPageSettings.Margins.Right;
                leftMargin = 5;//base.DefaultPageSettings.Margins.Left;
                //X
                rightMargin = 10;//base.DefaultPageSettings.Margins.Top;
                //Y
            }

            //Check if the user selected to print in Landscape mode
            //if they did then we need to swap height/width parameters
            if (base.DefaultPageSettings.Landscape)
            {
                
                int tmp;
                tmp = printHeight;
                printHeight = printWidth;
                printWidth = tmp;
            }

            //Now we need to determine the total number of lines
            //we're going to be printing
            Int32 numLines = (int)printHeight / PrinterFont.Height;

            //Create a rectangle printing are for our document
            RectangleF printArea = new RectangleF(leftMargin, rightMargin, printWidth, printHeight);

            //Use the StringFormat class for the text layout of our document
            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);

            //Fit as many characters as we can into the print area      

            e.Graphics.MeasureString(_text.Substring(RemoveZeros(curChar)), PrinterFont, new SizeF(printWidth, printHeight), format, out chars, out lines);

            //Print the page
            
            e.Graphics.DrawString(_text2, _font2, Brushes.Black, printArea, format);
            e.Graphics.DrawString(_text.Substring(RemoveZeros(curChar)), PrinterFont, Brushes.Black, printArea, format);
            //e.Graphics.DrawString(_text2.Substring(RemoveZeros(curChar)), PrinterFont2, Brushes.Black, printArea, format);
            
           //e.Graphics.DrawString()





            //Increase current char count
            curChar += chars;

            //Detemine if there is more text to print, if
            //there is the tell the printer there is more coming

           
            if (curChar < _text .Length)
            {
                e.HasMorePages = false;
            }
            else
            {
               
                e.HasMorePages = false;
                curChar = 0;
            }
        }

        #endregion

        #region  RemoveZeros
        /// <summary>
        /// Function to replace any zeros in the size to a 1
        /// Zero's will mess up the printing area
        /// </summary>
        /// <param name=value>Value to check</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int RemoveZeros(int value)
        {
            //Check the value passed into the function,
            //if the value is a 0 (zero) then return a 1,
            //otherwise return the value passed in
            switch (value)
            {
                case 0:
                    return 1;
                default:
                    return value;
            }
        }
        #endregion
   
    }
   



    
}


