//badger
using System;
using System.Windows.Forms;

namespace badger_editor_1
{
	public partial class main_form : Form
	{
		private void undoToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Undo(); }
		private void redoToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Redo(); }
		private void cutToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Cut(); }
		private void copyToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Copy(); }
		private void pasteToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Paste(); }
		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.SelectAll(); }
		private void copyPasteLineToolStripMenuItem_Click(object sender, EventArgs e) { string b1 = richTextBox1.Lines[line]; richTextBox1.Select(first_char, b1.Length); richTextBox1.Copy(); richTextBox1.SelectedText += "\n"; richTextBox1.Paste(); }
		private void findToolStripMenuItem_Click(object sender, EventArgs e) { string b1 = new box_1("Find", "Input what string you want to search for in the text box", new System.Drawing.Size(400, 300)).input(); richTextBox1.Find(b1); }
		private void capitalizeToolStripMenuItem_Click(object sender, EventArgs e) { bool b1 = new box_1("Capitalize", "Click 'Yes' if you want to capitalize the selected text").confirm(); if (b1 == true) { richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper(); } else { richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower(); } }
		private void goToToolStripMenuItem_Click(object sender, EventArgs e) { try { string b1 = new box_1("Go To", "Input line for cursor to go to.").input(); int b2 = richTextBox1.GetFirstCharIndexFromLine(Int32.Parse(b1)); richTextBox1.Select(b2, 0); } catch { } }
	};
};
//richTextBox1.Text.Replace("", "");