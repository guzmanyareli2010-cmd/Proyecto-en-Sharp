/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 27/10/2026
 * Hora: 04:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_en_Sharp
{
	/// <summary>
	/// Description of Valores.
	/// </summary>
	public partial class Valores : Form
	{
		public Valores()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a = double.Parse(txtValorA.Text);
			double b = double.Parse(txtValorB.Text);
			double c = double.Parse(txtValorC.Text);
			
			double discriminante = b * b - 4 * a * c;
			if ( a == 0 )
			{
				MessageBox.Show("El valor de a no puede ser 0 ");
			}
			else if (discriminante >= 0)
			{
				double X1 = (-b + Math.Sqrt(discriminante )) / ( 2 * a);
				double X2 = (-b - Math.Sqrt(discriminante )) / ( 2 * a);
				
				txtX1.Text = X1.ToString();
				txtX2.Text = X2.ToString();
			}
			else 
			{
				MessageBox.Show ("La ecuacion no tiene reultados reales");
			}
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MainForm operaciones = new MainForm();
			operaciones.Show();
		}
	}
}
