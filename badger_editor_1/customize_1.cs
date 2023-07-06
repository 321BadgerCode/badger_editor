//badger
using System;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace badger_editor_1
{
	public partial class main_form : Form
	{
		private string string_to_binary(string A1) { StringBuilder sb = new StringBuilder(); foreach (char c in A1.ToCharArray()) { sb.Append(Convert.ToString(c, 2).PadLeft(8, '0')); } return sb.ToString(); }
		private string binary_to_string(string data) { List<Byte> byteList = new List<Byte>(); for (int i = 0; i < data.Length; i += 8) { try { byteList.Add(Convert.ToByte(data.Substring(i, 8), 2)); } catch { } } return Encoding.ASCII.GetString(byteList.ToArray()); }
		private void textColorToolStripMenuItem_Click(object sender, EventArgs e) { ColorDialog cd = new ColorDialog(); if (cd.ShowDialog() == DialogResult.OK) { richTextBox1.ForeColor = cd.Color; } }
		private void textFontToolStripMenuItem_Click(object sender, EventArgs e) { FontDialog fd = new FontDialog(); if (fd.ShowDialog() == DialogResult.OK) { richTextBox1.Font = fd.Font; } }
		private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e) { ColorDialog cd = new ColorDialog(); if (cd.ShowDialog() == DialogResult.OK) { richTextBox1.BackColor = cd.Color; } }
		private void backgroundOpacityToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int b1 = new box_1("Opacity", "Slide the slider to adjust the background opacity of the editor.", new Size(300, 200)).slider(0, 10);
			float b2 = b1 / 10;
			Opacity = b2;
		}
		private void filePathToolStripMenuItem_Click(object sender, EventArgs e) { string b1 = new box_1("File Path", "Input a file path for the editor to go to once you open a file(ctrl+o)", new Size(400, 300)).input(); dir = b1; }
		private void zoomInToolStripMenuItem_Click(object sender, EventArgs e) { bool b1 = false; if (richTextBox1.ZoomFactor >= 3) { b1 = true; } if (b1 == false) { richTextBox1.ZoomFactor += .1f; label_zoom.Text = (100 * richTextBox1.ZoomFactor).ToString() + "%"; } }
		private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e) { bool b1 = false; if (richTextBox1.ZoomFactor <= 1) { b1 = true; } if (b1 == false) { richTextBox1.ZoomFactor -= .1f; label_zoom.Text = (100 * richTextBox1.ZoomFactor).ToString() + "%"; } }
		private void defaultToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.ForeColor = Color.Gray; richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular); richTextBox1.BackColor = Color.Black; Opacity = 1; dir = ""; richTextBox1.ZoomFactor = 1; richTextBox1.SelectionColor = Color.Gray; }
		private void textSelectionColorToolStripMenuItem_Click(object sender, EventArgs e) { ColorDialog cd = new ColorDialog(); if (cd.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionColor = cd.Color; } }
		private void binaryToolStripMenuItem_Click(object sender, EventArgs e) { bool b1 = new box_1("Binary", "Do you want the text in the text box to be converted to binary(you can change it back to normal by clicking 'No')?", new Size(400, 300)).confirm(); binaryToolStripMenuItem.Checked = b1; if (b1 == true) { richTextBox1.Text = string_to_binary(richTextBox1.Text); } else { richTextBox1.Text = binary_to_string(richTextBox1.Text); } }
		private void tabSizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int b1 = new box_1("Tab Size", "Specify the tab size").slider(1, 10) * 10;
			tab_size = b1;
			/*richTextBox1.SelectAll();
			richTextBox1.TabIndex = b1;
			richTextBox1.SelectionTabs = new int[3] { b1, b1 * 2, b1 * 3 };*/
		}
		private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			wordWrapToolStripMenuItem.Checked = !wordWrapToolStripMenuItem.Checked;
			richTextBox1.WordWrap = !richTextBox1.WordWrap;
		}
	};
};
//fix tab size
/*Size formsizeholder = new Size(new Point(500, 300));  
Point formloc = new Point(0, 0);  
  
private void View_FullScreen_MenuItem_Click(object sender, EventArgs e)  
{  
    if(View_FullScreen_MenuItem.Checked==false)  
    {  
	this.Visible = false;  
	TopPanel.Visible = false;  
	this.WindowState = FormWindowState.Maximized;  
	this.Visible = true;  
  
	formsizeholder = this.Size;  
	formloc = this.Location;  
  
	View_FullScreen_MenuItem.Checked = true;  
    }  
    else  
    {  
	this.Visible = false;  
	TopPanel.Visible =true;  
	this.Location = formloc;  
	this.Size = formsizeholder;  
	this.Visible = true;  
  
	this.WindowState = FormWindowState.Normal;  
  
	View_FullScreen_MenuItem.Checked =false ;  
    }  
}*/