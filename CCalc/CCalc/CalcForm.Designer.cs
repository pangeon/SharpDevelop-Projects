/*
 * Created by SharpDevelop.
 * User: Kamil
 * Date: 08.04.2017
 * Time: 19:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CCalc
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Num7;
		private System.Windows.Forms.Button Num8;
		private System.Windows.Forms.Button Num9;
		private System.Windows.Forms.Button devide;
		private System.Windows.Forms.Button CE;
		private System.Windows.Forms.Button C;
		private System.Windows.Forms.Button multiple;
		private System.Windows.Forms.Button Num6;
		private System.Windows.Forms.Button Num5;
		private System.Windows.Forms.Button Num4;
		private System.Windows.Forms.Button equal;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.Button dot;
		private System.Windows.Forms.Button Num0;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button Num3;
		private System.Windows.Forms.Button Num2;
		private System.Windows.Forms.Button Num1;
		private System.Windows.Forms.TextBox calcDisplay;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Num7 = new System.Windows.Forms.Button();
			this.Num8 = new System.Windows.Forms.Button();
			this.Num9 = new System.Windows.Forms.Button();
			this.devide = new System.Windows.Forms.Button();
			this.CE = new System.Windows.Forms.Button();
			this.C = new System.Windows.Forms.Button();
			this.multiple = new System.Windows.Forms.Button();
			this.Num6 = new System.Windows.Forms.Button();
			this.Num5 = new System.Windows.Forms.Button();
			this.Num4 = new System.Windows.Forms.Button();
			this.equal = new System.Windows.Forms.Button();
			this.plus = new System.Windows.Forms.Button();
			this.dot = new System.Windows.Forms.Button();
			this.Num0 = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.Num3 = new System.Windows.Forms.Button();
			this.Num2 = new System.Windows.Forms.Button();
			this.Num1 = new System.Windows.Forms.Button();
			this.calcDisplay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Num7
			// 
			this.Num7.BackColor = System.Drawing.Color.Lime;
			this.Num7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num7.Location = new System.Drawing.Point(37, 127);
			this.Num7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num7.Name = "Num7";
			this.Num7.Size = new System.Drawing.Size(38, 41);
			this.Num7.TabIndex = 0;
			this.Num7.Text = "7";
			this.Num7.UseVisualStyleBackColor = false;
			this.Num7.Click += new System.EventHandler(this.Number_click);
			// 
			// Num8
			// 
			this.Num8.BackColor = System.Drawing.Color.Lime;
			this.Num8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num8.Location = new System.Drawing.Point(79, 127);
			this.Num8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num8.Name = "Num8";
			this.Num8.Size = new System.Drawing.Size(38, 41);
			this.Num8.TabIndex = 1;
			this.Num8.Text = "8";
			this.Num8.UseVisualStyleBackColor = false;
			this.Num8.Click += new System.EventHandler(this.Number_click);
			// 
			// Num9
			// 
			this.Num9.BackColor = System.Drawing.Color.Lime;
			this.Num9.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num9.Location = new System.Drawing.Point(121, 127);
			this.Num9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num9.Name = "Num9";
			this.Num9.Size = new System.Drawing.Size(38, 41);
			this.Num9.TabIndex = 2;
			this.Num9.Text = "9";
			this.Num9.UseVisualStyleBackColor = false;
			this.Num9.Click += new System.EventHandler(this.Number_click);
			// 
			// devide
			// 
			this.devide.BackColor = System.Drawing.Color.Lime;
			this.devide.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.devide.Location = new System.Drawing.Point(163, 127);
			this.devide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.devide.Name = "devide";
			this.devide.Size = new System.Drawing.Size(38, 41);
			this.devide.TabIndex = 3;
			this.devide.Text = ":";
			this.devide.UseVisualStyleBackColor = false;
			this.devide.Click += new System.EventHandler(this.Operator_click);
			// 
			// CE
			// 
			this.CE.BackColor = System.Drawing.Color.Lime;
			this.CE.Font = new System.Drawing.Font("Arial Narrow", 14.2F, System.Drawing.FontStyle.Bold);
			this.CE.Location = new System.Drawing.Point(205, 127);
			this.CE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CE.Name = "CE";
			this.CE.Size = new System.Drawing.Size(44, 41);
			this.CE.TabIndex = 4;
			this.CE.Text = "CE";
			this.CE.UseVisualStyleBackColor = false;
			this.CE.Click += new System.EventHandler(this.CE_click);
			// 
			// C
			// 
			this.C.BackColor = System.Drawing.Color.Lime;
			this.C.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.C.Location = new System.Drawing.Point(205, 172);
			this.C.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(44, 41);
			this.C.TabIndex = 9;
			this.C.Text = "C";
			this.C.UseVisualStyleBackColor = false;
			this.C.Click += new System.EventHandler(this.C_click);
			// 
			// multiple
			// 
			this.multiple.BackColor = System.Drawing.Color.Lime;
			this.multiple.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.multiple.Location = new System.Drawing.Point(163, 172);
			this.multiple.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.multiple.Name = "multiple";
			this.multiple.Size = new System.Drawing.Size(38, 41);
			this.multiple.TabIndex = 8;
			this.multiple.Text = "x";
			this.multiple.UseVisualStyleBackColor = false;
			this.multiple.Click += new System.EventHandler(this.Operator_click);
			// 
			// Num6
			// 
			this.Num6.BackColor = System.Drawing.Color.Lime;
			this.Num6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num6.Location = new System.Drawing.Point(121, 172);
			this.Num6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num6.Name = "Num6";
			this.Num6.Size = new System.Drawing.Size(38, 41);
			this.Num6.TabIndex = 7;
			this.Num6.Text = "6";
			this.Num6.UseVisualStyleBackColor = false;
			this.Num6.Click += new System.EventHandler(this.Number_click);
			// 
			// Num5
			// 
			this.Num5.BackColor = System.Drawing.Color.Lime;
			this.Num5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num5.Location = new System.Drawing.Point(79, 172);
			this.Num5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num5.Name = "Num5";
			this.Num5.Size = new System.Drawing.Size(38, 41);
			this.Num5.TabIndex = 6;
			this.Num5.Text = "5";
			this.Num5.UseVisualStyleBackColor = false;
			this.Num5.Click += new System.EventHandler(this.Number_click);
			// 
			// Num4
			// 
			this.Num4.BackColor = System.Drawing.Color.Lime;
			this.Num4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num4.Location = new System.Drawing.Point(37, 172);
			this.Num4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num4.Name = "Num4";
			this.Num4.Size = new System.Drawing.Size(38, 41);
			this.Num4.TabIndex = 5;
			this.Num4.Text = "4";
			this.Num4.UseVisualStyleBackColor = false;
			this.Num4.Click += new System.EventHandler(this.Number_click);
			// 
			// equal
			// 
			this.equal.BackColor = System.Drawing.Color.Lime;
			this.equal.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.equal.Location = new System.Drawing.Point(205, 218);
			this.equal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.equal.Name = "equal";
			this.equal.Size = new System.Drawing.Size(44, 86);
			this.equal.TabIndex = 19;
			this.equal.Text = "=";
			this.equal.UseVisualStyleBackColor = false;
			this.equal.Click += new System.EventHandler(this.equal_click);
			// 
			// plus
			// 
			this.plus.BackColor = System.Drawing.Color.Lime;
			this.plus.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.plus.Location = new System.Drawing.Point(163, 263);
			this.plus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(38, 41);
			this.plus.TabIndex = 18;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = false;
			this.plus.Click += new System.EventHandler(this.Operator_click);
			// 
			// dot
			// 
			this.dot.BackColor = System.Drawing.Color.Lime;
			this.dot.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dot.Location = new System.Drawing.Point(121, 263);
			this.dot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dot.Name = "dot";
			this.dot.Size = new System.Drawing.Size(38, 41);
			this.dot.TabIndex = 17;
			this.dot.Text = ",";
			this.dot.UseVisualStyleBackColor = false;
			this.dot.Click += new System.EventHandler(this.Number_click);
			// 
			// Num0
			// 
			this.Num0.BackColor = System.Drawing.Color.Lime;
			this.Num0.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num0.Location = new System.Drawing.Point(37, 263);
			this.Num0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num0.Name = "Num0";
			this.Num0.Size = new System.Drawing.Size(80, 41);
			this.Num0.TabIndex = 16;
			this.Num0.Text = "0";
			this.Num0.UseVisualStyleBackColor = false;
			this.Num0.Click += new System.EventHandler(this.Number_click);
			// 
			// minus
			// 
			this.minus.BackColor = System.Drawing.Color.Lime;
			this.minus.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.minus.Location = new System.Drawing.Point(163, 218);
			this.minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(38, 41);
			this.minus.TabIndex = 13;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = false;
			this.minus.Click += new System.EventHandler(this.Operator_click);
			// 
			// Num3
			// 
			this.Num3.BackColor = System.Drawing.Color.Lime;
			this.Num3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num3.Location = new System.Drawing.Point(121, 218);
			this.Num3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num3.Name = "Num3";
			this.Num3.Size = new System.Drawing.Size(38, 41);
			this.Num3.TabIndex = 12;
			this.Num3.Text = "3";
			this.Num3.UseVisualStyleBackColor = false;
			this.Num3.Click += new System.EventHandler(this.Number_click);
			// 
			// Num2
			// 
			this.Num2.BackColor = System.Drawing.Color.Lime;
			this.Num2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num2.Location = new System.Drawing.Point(79, 218);
			this.Num2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num2.Name = "Num2";
			this.Num2.Size = new System.Drawing.Size(38, 41);
			this.Num2.TabIndex = 11;
			this.Num2.Text = "2";
			this.Num2.UseVisualStyleBackColor = false;
			this.Num2.Click += new System.EventHandler(this.Number_click);
			// 
			// Num1
			// 
			this.Num1.BackColor = System.Drawing.Color.Lime;
			this.Num1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Num1.Location = new System.Drawing.Point(37, 218);
			this.Num1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Num1.Name = "Num1";
			this.Num1.Size = new System.Drawing.Size(38, 41);
			this.Num1.TabIndex = 10;
			this.Num1.Text = "1";
			this.Num1.UseVisualStyleBackColor = false;
			this.Num1.Click += new System.EventHandler(this.Number_click);
			// 
			// calcDisplay
			// 
			this.calcDisplay.Enabled = false;
			this.calcDisplay.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.calcDisplay.Location = new System.Drawing.Point(37, 78);
			this.calcDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.calcDisplay.Name = "calcDisplay";
			this.calcDisplay.Size = new System.Drawing.Size(213, 32);
			this.calcDisplay.TabIndex = 20;
			this.calcDisplay.Text = "0";
			this.calcDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(286, 368);
			this.Controls.Add(this.calcDisplay);
			this.Controls.Add(this.equal);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.dot);
			this.Controls.Add(this.Num0);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.Num3);
			this.Controls.Add(this.Num2);
			this.Controls.Add(this.Num1);
			this.Controls.Add(this.C);
			this.Controls.Add(this.multiple);
			this.Controls.Add(this.Num6);
			this.Controls.Add(this.Num5);
			this.Controls.Add(this.Num4);
			this.Controls.Add(this.CE);
			this.Controls.Add(this.devide);
			this.Controls.Add(this.Num9);
			this.Controls.Add(this.Num8);
			this.Controls.Add(this.Num7);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.Text = "CCalc";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
