/*
 * Created by SharpDevelop.
 * User: Kamil
 * Date: 08.04.2017
 * Time: 23:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CCalc
{
	/// <summary>
	/// Kamil Cecherz
	/// </summary>
	public partial class MainForm : Form {
		
		Double displayValue = 0;
		String operationPerformed = "";
		bool isOperationPerformed = false;
		
		public MainForm() {
			InitializeComponent();
		}
		void Number_click(object sender, EventArgs e) {
			if (calcDisplay.Text == "0" || (isOperationPerformed)) {
				calcDisplay.Clear();
			}
			isOperationPerformed = false;
			Button button = (Button) sender;
			if (button.Text == ",") {
				if(!calcDisplay.Text.Contains(",")) {
					calcDisplay.Text = calcDisplay.Text + button.Text;
				}
			} else {
				calcDisplay.Text = calcDisplay.Text + button.Text;
			}
		}
		void Operator_click(object sender, EventArgs e) {
			Button button = (Button) sender;
			operationPerformed = button.Text;
			displayValue = Double.Parse(calcDisplay.Text);
			isOperationPerformed = true;
		}
		void C_click(object sender, EventArgs e) {
			calcDisplay.Text = "0";
		}
		void CE_click(object sender, EventArgs e) {
			calcDisplay.Text = "0";
			displayValue = 0;
		}
		void equal_click(object sender, EventArgs e) {
			switch (operationPerformed) {
				case "+":
					calcDisplay.Text = (displayValue + Double.Parse(calcDisplay.Text)).ToString();
					break;
				case "-":
					calcDisplay.Text = (displayValue - Double.Parse(calcDisplay.Text)).ToString();
					break;
				case "x":
					calcDisplay.Text = (displayValue * Double.Parse(calcDisplay.Text)).ToString();
					break;
				case ":":
					calcDisplay.Text = (displayValue / Double.Parse(calcDisplay.Text)).ToString();
					break;
				default:
					break;
			}
		}
	}
}
