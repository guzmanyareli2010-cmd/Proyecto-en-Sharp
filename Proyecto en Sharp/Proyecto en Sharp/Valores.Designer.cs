/*
 * Creado por SharpDevelop.
 * Usuario: guzma
 * Fecha: 27/10/2026
 * Hora: 04:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_en_Sharp
{
	partial class Valores
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
			this.txtValorA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtValorB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtValorC = new System.Windows.Forms.TextBox();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.txtX2 = new System.Windows.Forms.TextBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor de a ";
			// 
			// txtValorA
			// 
			this.txtValorA.Location = new System.Drawing.Point(97, 25);
			this.txtValorA.Name = "txtValorA";
			this.txtValorA.Size = new System.Drawing.Size(100, 26);
			this.txtValorA.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Valor de b ";
			// 
			// txtValorB
			// 
			this.txtValorB.Location = new System.Drawing.Point(97, 65);
			this.txtValorB.Name = "txtValorB";
			this.txtValorB.Size = new System.Drawing.Size(100, 26);
			this.txtValorB.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Valor de c ";
			// 
			// txtValorC
			// 
			this.txtValorC.Location = new System.Drawing.Point(97, 106);
			this.txtValorC.Name = "txtValorC";
			this.txtValorC.Size = new System.Drawing.Size(100, 26);
			this.txtValorC.TabIndex = 5;
			// 
			// BtnCalcular
			// 
			this.BtnCalcular.Location = new System.Drawing.Point(13, 138);
			this.BtnCalcular.Name = "BtnCalcular";
			this.BtnCalcular.Size = new System.Drawing.Size(88, 45);
			this.BtnCalcular.TabIndex = 6;
			this.BtnCalcular.Text = "Calcular ";
			this.BtnCalcular.UseVisualStyleBackColor = true;
			this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(244, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "X1";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(244, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "X2";
			// 
			// txtX1
			// 
			this.txtX1.Location = new System.Drawing.Point(280, 44);
			this.txtX1.Name = "txtX1";
			this.txtX1.Size = new System.Drawing.Size(100, 26);
			this.txtX1.TabIndex = 9;
			// 
			// txtX2
			// 
			this.txtX2.Location = new System.Drawing.Point(280, 76);
			this.txtX2.Name = "txtX2";
			this.txtX2.Size = new System.Drawing.Size(100, 26);
			this.txtX2.TabIndex = 10;
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(107, 138);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(106, 45);
			this.btnRegresar.TabIndex = 11;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Valores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 199);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.txtX2);
			this.Controls.Add(this.txtX1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BtnCalcular);
			this.Controls.Add(this.txtValorC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtValorB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtValorA);
			this.Controls.Add(this.label1);
			this.Name = "Valores";
			this.Text = "Valores";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.TextBox txtX2;
		private System.Windows.Forms.TextBox txtX1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BtnCalcular;
		private System.Windows.Forms.TextBox txtValorC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtValorB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtValorA;
		private System.Windows.Forms.Label label1;
	}
}
