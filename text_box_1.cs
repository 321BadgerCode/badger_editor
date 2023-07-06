//badger
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace badger_editor_1
{
	public partial class main_form : Form
	{
		private int prev_line;
		private int line;
		private int lines;
		private int character;
		private int characters;
		private int index;
		private int first_char;
		private int tab_size = 8;
		private void color()
		{
			if (language.t == language.type.c_sharp) { language.s = new language.syntax(language.c_sharp.s.keyword, language.c_sharp.s.color, language.c_sharp.s.type); }
			new syntax_2(richTextBox1.Text, language.s).highlight(richTextBox1);
			//if (language_1.t == language_1.type.c_sharp) { new syntax_1(richTextBox1).highlight(new string[] { language_1.c_sharp.keyword, language_1.c_sharp.type, language_1.c_sharp.comment, language_1.c_sharp.quote }, new Color[] { Color.LightBlue, Color.Purple, Color.LightGreen, Color.Yellow }, new RegexOptions[] { RegexOptions.None, RegexOptions.None, RegexOptions.Multiline, RegexOptions.None }); }
			//else if (language_1.t == language_1.type.visual_basic) { new syntax_1(richTextBox1).highlight(new string[] { language_1.visual_basic.keyword, language_1.visual_basic.type, language_1.visual_basic.comment, language_1.visual_basic.quote }, new Color[] { Color.LightBlue, Color.LightBlue, Color.LightGreen, Color.Orange }, new RegexOptions[] { RegexOptions.IgnoreCase, RegexOptions.IgnoreCase, RegexOptions.IgnoreCase, RegexOptions.IgnoreCase }); }
		}
		private void get_line_number() { if (prev_line != lines) { prev_line = lines; label2.Text = ""; for (int a = 0; a < lines + 1; a++) { label2.Text += a.ToString() + "\n"; } } }
		private void set_text_box_values()
		{
			index = richTextBox1.SelectionStart;
			line = richTextBox1.GetLineFromCharIndex(index);
			lines = richTextBox1.Lines.Length - 1;
			first_char = richTextBox1.GetFirstCharIndexOfCurrentLine();
			character = index - first_char;
			characters = richTextBox1.Text.Length;
		}
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			set_saved(false);
			color();
		}
		private void richTextBox1_SelectionChanged(object sender, EventArgs e)
		{
			//richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Strikeout);
			//lb.Location = richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart);
			set_text_box_values();
			get_line_number();
			label1.Text = "Line: " + line.ToString() + "/" + lines.ToString() + ", Character: " + character.ToString() + "/" + characters.ToString();
		}
		private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Tab && richTextBox1.SelectedText.Length > 1)
			{
				string indent = new string(' ', tab_size);
				richTextBox1.SelectedText = indent + Regex.Replace(richTextBox1.SelectedText, @"\r?\n", m => m.Groups[0] + indent);
			}
			switch (e.KeyCode)
			{
				case Keys.ControlKey: richTextBox1.Cursor = Cursors.Cross; break;
				case Keys.Insert: richTextBox1.Cursor = Cursors.UpArrow; break;
			}
		}
		private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e) { try { new WebBrowser() { Url = new Uri(e.ToString()) }.GoSearch(); } catch { new box_1("ERROR!", "ERROR: THE LINK YOU ARE TRYING TO ACCESS COULD NOT BE REACHED!").error(); } }
		private void richTextBox1_DragDrop(object sender, DragEventArgs e) { richTextBox1.SelectedText = e.Data.GetData(DataFormats.Text, true).ToString(); }
		private void richTextBox1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text)) { e.Effect = DragDropEffects.Copy; }
			else { e.Effect = DragDropEffects.None; }
		}
		private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right) { string b1 = new box_1("Right Click", "Input a string/text that you want to input here.").input(); new console_1(richTextBox1).print(null, b1); }
		}
		/*private void richTextBox1_DragDrop(object sender, DragEventArgs e)
		{
			int i;
			String s;

			// Get start position to drop the text.  
			i = richTextBox1.SelectionStart;
			s = richTextBox1.Text.Substring(i);
			richTextBox1.Text = richTextBox1.Text.Substring(0, i);

			// Drop the text on to the RichTextBox.  
			richTextBox1.Text = richTextBox1.Text +
			   e.Data.GetData(DataFormats.Text).ToString();
			richTextBox1.Text = richTextBox1.Text + s;
		}*/
	};
};