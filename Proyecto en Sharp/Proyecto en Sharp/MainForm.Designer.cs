/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 27/10/2026
 * Hora: 07:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_en_Sharp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMultiplicacion = new System.Windows.Forms.Button();
			this.btnDivicion = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.btnModulo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Numero 2";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numero1";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(120, 13);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 26);
			this.txt1.TabIndex = 3;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(120, 57);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 26);
			this.txt2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(317, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Resultado";
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(13, 102);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(75, 39);
			this.btnSuma.TabIndex = 8;
			this.btnSuma.Text = "Suma";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(107, 102);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(75, 39);
			this.btnResta.TabIndex = 9;
			this.btnResta.Text = "Resta";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnMultiplicacion
			// 
			this.btnMultiplicacion.Location = new System.Drawing.Point(188, 102);
			this.btnMultiplicacion.Name = "btnMultiplicacion";
			this.btnMultiplicacion.Size = new System.Drawing.Size(113, 39);
			this.btnMultiplicacion.TabIndex = 10;
			this.btnMultiplicacion.Text = "Multiplicacion";
			this.btnMultiplicacion.UseVisualStyleBackColor = true;
			this.btnMultiplicacion.Click += new System.EventHandler(this.BtnMultiplicacionClick);
			// 
			// btnDivicion
			// 
			this.btnDivicion.Location = new System.Drawing.Point(307, 102);
			this.btnDivicion.Name = "btnDivicion";
			this.btnDivicion.Size = new System.Drawing.Size(91, 39);
			this.btnDivicion.TabIndex = 11;
			this.btnDivicion.Text = "Division";
			this.btnDivicion.UseVisualStyleBackColor = true;
			this.btnDivicion.Click += new System.EventHandler(this.Button4Click);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(424, 34);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 12;
			// 
			// btnModulo
			// 
			this.btnModulo.Location = new System.Drawing.Point(404, 102);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(106, 39);
			this.btnModulo.TabIndex = 13;
			this.btnModulo.Text = "Modulo";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 188);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnDivicion);
			this.Controls.Add(this.btnMultiplicacion);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Proyecto en Sharp";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnDivicion;
		private System.Windows.Forms.Button btnMultiplicacion;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
