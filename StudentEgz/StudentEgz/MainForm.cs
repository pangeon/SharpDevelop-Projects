/*
 * Created by SharpDevelop.
 * User: P33
 * Date: 2017-04-09
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudentEgz
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{ 
			InitializeComponent();
		}
		
		void Przedmiot_Click(object sender, EventArgs e) {
			Button button = (Button) sender;
			decimal oc1 = numericUpDown1.Value;
			decimal oc2 = numericUpDown2.Value;
			decimal oc3 = numericUpDown3.Value;
			decimal oc4 = numericUpDown4.Value;
			decimal oc5 = numericUpDown5.Value;
			
			int ile_dwoj = 0;
			
			if(oc1 < 3) {
				ile_dwoj = ile_dwoj + 1;
			}
			if(oc2 < 3) {
				ile_dwoj = ile_dwoj + 1;
			}
			if(oc3 < 3) {
				ile_dwoj = ile_dwoj + 1;
			}
			if(oc4 < 3) {
				ile_dwoj = ile_dwoj + 1;
			}
			if(oc5 < 3) {
				ile_dwoj = ile_dwoj + 1;
			}
			if(ile_dwoj > 1) {
				label6.Text = " " + "poprawka";
			}
			if(ile_dwoj > 2) {
				label6.Text = " " + "warunek";
			}
			if(ile_dwoj > 3) {
				label6.Text = " " + "skreślony z listy";
			}
			double srednia = (double) (oc1 + oc2 + oc3 + oc4 + oc5)/5;
			if(srednia > 3.5) {
				label6.Text = " " + "stypendium 500" + "sr " + srednia;
			}
			if(srednia > 4) {
				label6.Text = " " + "stypendium 2000" + "sr " + srednia;
			}
			if(srednia > 4.5) {
				label6.Text = " " + "stypendium 4000" + "sr " + srednia;
			}
		}
	}
}
