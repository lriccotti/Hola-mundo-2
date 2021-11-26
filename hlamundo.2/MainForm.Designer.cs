/*
 * Created by SharpDevelop.
 * User: VaCkensi
 * Date: 16/11/2021
 * Time: 12:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace hlamundo._
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
			this.btn1 = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.rojo = new System.Windows.Forms.RadioButton();
			this.verde = new System.Windows.Forms.RadioButton();
			this.azul = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn1.Location = new System.Drawing.Point(140, 105);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(75, 79);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "Saludar";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(25, 18);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(169, 28);
			this.lbl1.TabIndex = 1;
			this.lbl1.Text = "ingrese nombre";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(133, 15);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(82, 20);
			this.txt1.TabIndex = 2;
			// 
			// rojo
			// 
			this.rojo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.rojo.Location = new System.Drawing.Point(20, 102);
			this.rojo.Name = "rojo";
			this.rojo.Size = new System.Drawing.Size(104, 24);
			this.rojo.TabIndex = 3;
			this.rojo.TabStop = true;
			this.rojo.Text = "rojo";
			this.rojo.UseVisualStyleBackColor = true;
			// 
			// verde
			// 
			this.verde.ForeColor = System.Drawing.Color.Red;
			this.verde.Location = new System.Drawing.Point(20, 132);
			this.verde.Name = "verde";
			this.verde.Size = new System.Drawing.Size(104, 24);
			this.verde.TabIndex = 4;
			this.verde.TabStop = true;
			this.verde.Text = "verde";
			this.verde.UseVisualStyleBackColor = true;
			// 
			// azul
			// 
			this.azul.ForeColor = System.Drawing.Color.Lime;
			this.azul.Location = new System.Drawing.Point(20, 162);
			this.azul.Name = "azul";
			this.azul.Size = new System.Drawing.Size(104, 24);
			this.azul.TabIndex = 5;
			this.azul.TabStop = true;
			this.azul.Text = "azul";
			this.azul.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 214);
			this.Controls.Add(this.azul);
			this.Controls.Add(this.verde);
			this.Controls.Add(this.rojo);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.btn1);
			this.Name = "MainForm";
			this.Text = "hlamundo.2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton azul;
		private System.Windows.Forms.RadioButton verde;
		private System.Windows.Forms.RadioButton rojo;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button btn1;
	}
}
