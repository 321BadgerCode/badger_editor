//badger
using System;
using System.Windows.Forms;

namespace badger_editor_1
{
	public partial class main_form : Form
	{
		private void asciiValueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string b1 = new box_1("Ascii Value", "Input a char to be converted to an ascii value").input();
				char b2 = Char.Parse(b1);
				int b3 = (int)b2;
				new box_1("Ascii Value Output", "Output: " + b3.ToString()).message();
			}
			catch { new box_1("ERROR!", "ERROR: AN ERROR OCCURED IN THE PROGRAM! CHECK TO MAKE SURE THAT THE INPUT IS A CHAR(ex. 'a') BECAUSE YOUR INPUT MIGHT HAVE BEEN A STRING INSTEAD(ex. 'abc')").error(); }
		}
	};
};