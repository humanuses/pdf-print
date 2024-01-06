/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: 001986
 * Data: 27.05.2020
 * Godzina: 12:27
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
namespace pdf_print
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button wyszukaj;
		private System.Windows.Forms.Button drukuj;
		private System.Windows.Forms.TextBox ramka;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.wyszukaj = new System.Windows.Forms.Button();
			this.drukuj = new System.Windows.Forms.Button();
			this.ramka = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// wyszukaj
			// 
			this.wyszukaj.BackColor = System.Drawing.Color.Yellow;
			this.wyszukaj.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.wyszukaj.ForeColor = System.Drawing.Color.Red;
			this.wyszukaj.Location = new System.Drawing.Point(12, 1);
			this.wyszukaj.Name = "wyszukaj";
			this.wyszukaj.Size = new System.Drawing.Size(241, 61);
			this.wyszukaj.TabIndex = 0;
			this.wyszukaj.Text = "WYSZUKAJ";
			this.wyszukaj.UseVisualStyleBackColor = false;
			this.wyszukaj.Click += new System.EventHandler(this.WyszukajClick);
			// 
			// drukuj
			// 
			this.drukuj.Location = new System.Drawing.Point(516, 1);
			this.drukuj.Name = "drukuj";
			this.drukuj.Size = new System.Drawing.Size(357, 166);
			this.drukuj.TabIndex = 1;
			this.drukuj.Text = "Drukuj";
			this.drukuj.UseVisualStyleBackColor = true;
			this.drukuj.Visible = false;
			this.drukuj.Click += new System.EventHandler(this.DrukujClick);
			// 
			// ramka
			// 
			this.ramka.Location = new System.Drawing.Point(22, 89);
			this.ramka.Multiline = true;
			this.ramka.Name = "ramka";
			this.ramka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ramka.Size = new System.Drawing.Size(264, 121);
			this.ramka.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 237);
			this.Controls.Add(this.ramka);
			this.Controls.Add(this.drukuj);
			this.Controls.Add(this.wyszukaj);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "PDF PRINT";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
