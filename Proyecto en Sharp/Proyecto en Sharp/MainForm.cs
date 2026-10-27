/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 27/10/2026
 * Hora: 07:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_en_Sharp
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
		
		void Button4Click(object sender, EventArgs e)
		{
			double n1 = double.Parse(txt1.Text);
		    double n2 = double.Parse(txt2.Text);
		
		    lblResultado.Text = (n1 / n2).ToString();
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txt1.Text);
		    double n2 = double.Parse(txt2.Text);
		
		    lblResultado.Text = (n1 + n2).ToString();
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txt1.Text);
		    double n2 = double.Parse(txt2.Text);
		
		    lblResultado.Text = (n1 - n2).ToString();
		}
		
		void BtnMultiplicacionClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txt1.Text);
		    double n2 = double.Parse(txt2.Text);
		
		    lblResultado.Text = (n1 * n2).ToString();
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txt1.Text);
		    double n2 = double.Parse(txt2.Text);
		
		    if (n2 !=0)
		    {
		    	lblResultado.Text = (n1 % n2).ToString();
		    }
		    else 
		    {
		    	MessageBox.Show("No se pude calcular modulo entre 0");
		    }
		}   
		
		void BtnFormulaGneralClick(object sender, EventArgs e)
		{
			Valores formulario = new Valores();
			formulario.Show();
		}
	}
}
