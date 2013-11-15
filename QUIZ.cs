/*
 * Created by SharpDevelop.
 * User: Yanez
 * Date: 31/10/2013
 * Time: 07:17 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void CodigoClick(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox3CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox4CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox5CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
		
		void MonthCalendar1DateChanged(object sender, DateRangeEventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		
        int Acierto = 0;
        if(this.radioDF.Checked){
        	Acierto++;
        	
        }
		if(this.checkPortugal.Checked){
        	Acierto++;
        }
        if(this.checkMacedonia.Checked){
        	Acierto++;
        }
		if(this.checkReino.Checked){
        	Acierto++;
        	
        }
        if(numesta.Value == 32){
        	Acierto++;
        }
        
DateTime fecha = cale.SelectionStart;
       
if(fecha.ToShortDateString()=="07/05/1945"){
	Acierto++;
		}
       

        MessageBox.Show("Aciertos" + Acierto + " \n codigo" + codi.Text + " \n nombre" + nom.Text);
		}
	
	
	}
}
