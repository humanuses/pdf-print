using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Spire.Pdf.Annotations;
using Spire.Pdf.Widget;
using Spire.Pdf;


namespace pdf_print
{
	/// <summary>
	
	/// </summary>
	public partial class MainForm : Form
		
	{	public string drukarka;
		public string fn;
		public string fn1,fn2;
		public string wd;
		public string finalText5;
	
			
		public void proceduradruku(string fn, string drukarka )
	
		{        PdfDocument doc = new PdfDocument(); 
		fn1= Path.GetFullPath(@fn);
		fn2= doc.FileInfo.ToString();

			doc.LoadFromFile(@fn);

			PdfPageBase page= doc.Pages[0];
			
			string extractText=page.ExtractText();
			string []zapis =extractText.Split('\n');
			
			string finalText=Array.Find(zapis, ele=> ele.Contains("SO.II."));
			string finalText1=Array.Find(zapis, ele=> ele.Contains("SOII."));
			string finalText2=Array.Find(zapis, ele=> ele.Contains("SOV."));
			string finalText3=Array.Find(zapis, ele=> ele.Contains("SOVI."));
			string finalText9=Array.Find(zapis, ele=> ele.Contains("SOIa."));
			string finalText4=Array.Find(zapis, ele=> ele.Contains("wywiad"));
			string finalText6=Array.Find(zapis, ele=> ele.Contains("kierowc"));
			string finalText7=Array.Find(zapis, ele=> ele.Contains("WYWIAD"));
			string finalText8=Array.Find(zapis, ele=> ele.Contains("KIEROWC"));
			string finalText10=Array.Find(zapis, ele=> ele.Contains("7 dni"));
			string finalText11=Array.Find(zapis, ele=> ele.Contains(".6121."));
			string finalText12=Array.Find(zapis, ele=> ele.Contains("sezon"));
			if(finalText6!=null || finalText8!=null  ){finalText6=";kierowca";}
			if(finalText4!=null || finalText7!=null){finalText4=";wywiad";}
			if(finalText10!=null|| finalText12!=null){finalText10=";7 dni";}
			if(finalText11!=null){finalText11=";RP";}

			string ftr=finalText+finalText1+finalText2+finalText3+finalText4+finalText6+finalText9+finalText10+finalText11;
			ramka.Text=ramka.Text+String.Concat(ftr.Where(c=> !Char.IsWhiteSpace(c)))+'\n';


			             doc.PrintSettings.SelectPageRange(1,1);
			           
			             // ODZNACZYĆ ŻEBY DRUKOWAŁO
			             //
			                  doc.Print();

			}

		
		public MainForm()
		{

			InitializeComponent();
			

			PrinterSettings printerName = new PrinterSettings(){

				PrintRange=PrintRange.CurrentPage
			
					
				
			}; 
			drukarka= printerName.PrinterName;
			printerName.ToPage=1;

		}
		void DrukujClick(object sender,EventArgs e)
		{
			proceduradruku(fn,drukarka);
		
		}
	 void WyszukajClick(object sender, EventArgs e)
	 	
		{
	        OpenFileDialog dlg = new OpenFileDialog();
           dlg.DefaultExt = ".pdf";
           dlg.Filter = "Pliki pdf|*.pdf";
            dlg.Multiselect = true;
                     
           if(dlg.ShowDialog()==DialogResult.OK){
           	 string[] filen=  dlg.FileNames;
           
      
            	wd=Path.GetDirectoryName(dlg.FileName);
           foreach( string filenam in filen){
            		fn = wd+@"\"+Path.GetFileName(filenam);

            
        	proceduradruku(fn,drukarka);
            	
            	}
           }
		}

	
	}
}
