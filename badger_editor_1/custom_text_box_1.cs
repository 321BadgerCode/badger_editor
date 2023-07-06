//badger
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

//[Browsable(true)]
public class badger_text_box : RichTextBox
{
	private notification_form auto_complete_form = new notification_form();
	private ListBox auto_complete_list_box = new ListBox();
	private bool form_show;
	private bool replace_tab;
	private bool mouse_click;
	private int suggestion = 20;
	private void select_index_change(object sender, EventArgs e)
	{
		if (mouse_click) { if (auto_complete_list_box.SelectedIndex >= 0) { ReplaceCurrentWordWith(auto_complete_list_box.SelectedItem.ToString()); replace_tab = false; } }
		mouse_click = false;
	}
	private void auto_complete_list_box_Click(object sender, EventArgs e) { mouse_click = true; }
	private void selection_change(object sender, EventArgs e) { auto_complete_form.Hide(); form_show = false; }
	private void key_press(object sender, KeyPressEventArgs e) { if (replace_tab) { e.Handled = true; replace_tab = false; } else { if (e.KeyChar == (char)Keys.Escape) { auto_complete_form.Hide(); form_show = false; e.Handled = true; } } }
	private void key_down(object sender, KeyEventArgs e)
	{
		if (form_show)
		{
			if (e.KeyCode == Keys.Up)
			{
				if (auto_complete_list_box.Items.Count > 0)
				{
					if (auto_complete_list_box.SelectedIndex < 0) { auto_complete_list_box.SelectedIndex = 0; }
					else if (auto_complete_list_box.SelectedIndex > 0) { auto_complete_list_box.SelectedIndex = auto_complete_list_box.SelectedIndex - 1; }
				}
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Down)
			{
				if (auto_complete_list_box.Items.Count > 0)
				{
					if (auto_complete_list_box.SelectedIndex < 0) { auto_complete_list_box.SelectedIndex = 0; }
					else if (auto_complete_list_box.SelectedIndex < auto_complete_list_box.Items.Count - 1) { auto_complete_list_box.SelectedIndex = auto_complete_list_box.SelectedIndex + 1; }
				}
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Enter)
			{
				if (auto_complete_list_box.SelectedIndex >= 0) { ReplaceCurrentWordWith(auto_complete_list_box.SelectedItem.ToString()); }
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Tab)
			{
				if (auto_complete_list_box.SelectedIndex >= 0) { ReplaceCurrentWordWith(auto_complete_list_box.SelectedItem.ToString()); }
				e.Handled = true;
			}
		}
	}
	private void text_change(object sender, EventArgs e)
	{
		if (IntellisenseWords != null && IntellisenseWords.Length > 0)
		{
			string wordText;
			int lastIndexOfSpace;
			int lastIndexOfNewline;
			int lastIndexOfTab;
			int lastIndexOf;
			if (SelectionStart == Text.Length)
			{
				if (SelectionStart > 0 && Text[SelectionStart - 1] != ' ' && Text[SelectionStart - 1] != '\t' && Text[SelectionStart - 1] != '\n')
				{
					wordText = Text.Substring(0, SelectionStart);
					lastIndexOfSpace = wordText.LastIndexOf(' ');
					lastIndexOfNewline = wordText.LastIndexOf('\n');
					lastIndexOfTab = wordText.LastIndexOf('\t');
					lastIndexOf = Math.Max(Math.Max(lastIndexOfSpace, lastIndexOfNewline), lastIndexOfTab);
					if (lastIndexOf >= 0) { wordText = wordText.Substring(lastIndexOf + 1); }
					if (PopulateIntelliListBox(wordText)) { ShowAutoCompleteForm(); }
					else { auto_complete_form.Hide(); form_show = false; }
				}
				else { auto_complete_form.Hide(); form_show = false; }
			}
			else
			{
				char currentChar = Text[SelectionStart];
				if (SelectionStart > 0)
				{
					if (SelectionStart > 0 && Text[SelectionStart - 1] != ' ' && Text[SelectionStart - 1] != '\t' && Text[SelectionStart - 1] != '\n'
					    && (Text[SelectionStart] == ' ' || Text[SelectionStart] == '\t' || Text[SelectionStart] == '\n'))
					{
						wordText = Text.Substring(0, SelectionStart);
						lastIndexOfSpace = wordText.LastIndexOf(' ');
						lastIndexOfNewline = wordText.LastIndexOf('\n');
						lastIndexOfTab = wordText.LastIndexOf('\t');
						lastIndexOf = Math.Max(Math.Max(lastIndexOfSpace, lastIndexOfNewline), lastIndexOfTab);
						if (lastIndexOf >= 0) { wordText = wordText.Substring(lastIndexOf + 1); }
						if (PopulateIntelliListBox(wordText)) { ShowAutoCompleteForm(); }
						else { auto_complete_form.Hide(); form_show = false; }
					}
					else { auto_complete_form.Hide(); form_show = false; }
				}
				else { auto_complete_form.Hide(); form_show = false; }
			}
		}
		else { auto_complete_form.Hide(); form_show = false; }
	}
	private bool PopulateIntelliListBox(string wordTyping)
	{
		auto_complete_list_box.Items.Clear();

		List<KeyValuePair<int, string>> tempWords = new List<KeyValuePair<int, string>>();
		string[] outArray;

		for (int i = 0; i < IntellisenseWords.Length; i++)
		{
			if (IntellisenseWords[i].StartsWith(wordTyping, StringComparison.CurrentCultureIgnoreCase)) { tempWords.Add(new KeyValuePair<int, string>(1, IntellisenseWords[i])); }
		}

		if (tempWords.Count < suggestion && wordTyping.Length > 1)
		{
			for (int i = 0; i < IntellisenseWords.Length; i++)
			{
				if (IntellisenseWords[i].Contains(wordTyping, StringComparison.CurrentCultureIgnoreCase))
				{
					if (tempWords.Count(c => c.Value == IntellisenseWords[i]) == 0) { tempWords.Add(new KeyValuePair<int, string>(2, IntellisenseWords[i])); }
				}
			}
		}

		outArray = tempWords.OrderBy(o => o.Key).Take(suggestion).Select(s => s.Value).ToArray();

		auto_complete_list_box.Items.AddRange(outArray);

		return outArray.Length > 0;
	}
	private void ShowAutoCompleteForm()
	{
		Point tmpPoint = PointToClient(Location);
		Point tmpSelPoint = GetPositionFromCharIndex(SelectionStart);
		auto_complete_form.Location = new Point((-1 * tmpPoint.X) + tmpSelPoint.X + XOffset, (-1 * tmpPoint.Y) + tmpSelPoint.Y + Margin.Top + YOffset);
		auto_complete_form.Show();
		form_show = true;
		Focus();
	}
	private void ReplaceCurrentWordWith(string Word)
	{
		string startString = "";
		string endString = Text.Substring(SelectionStart);
		string wordText = Text.Substring(0, SelectionStart);
		int lastIndexOfSpace = wordText.LastIndexOf(' ');
		int lastIndexOfNewline = wordText.LastIndexOf('\n');
		int lastIndexOfTab = wordText.LastIndexOf('\t');
		int lastIndexOf = Math.Max(Math.Max(lastIndexOfSpace, lastIndexOfNewline), lastIndexOfTab);
		if (lastIndexOf >= 0) { startString = wordText.Substring(0, lastIndexOf + 1); wordText = wordText.Substring(lastIndexOf + 1); }

		Text = String.Format("{0}{1} {2}", startString, Word, endString);

		if (lastIndexOf >= 0) { SelectionStart = startString.Length + Word.Length + 1; }
		else { SelectionStart = Word.Length + 1; }

		replace_tab = true;
	}

	public string[] IntellisenseWords { get; set; }
	public int YOffset { get; set; }
	public int XOffset { get; set; }
	public int suggestions { get { return suggestion; } set { suggestion = value; } }
	public badger_text_box()
	{
		AcceptsTab = true;
		YOffset = 30;

		auto_complete_form.Size = new Size(200, 200);
		auto_complete_form.TopMost = true;
		auto_complete_list_box.Dock = DockStyle.Fill;
		auto_complete_form.Controls.Add(auto_complete_list_box);

		TextChanged += text_change;
		KeyDown += key_down;
		KeyPress += key_press;
		SelectionChanged += selection_change;

		auto_complete_list_box.Click += auto_complete_list_box_Click;
		auto_complete_list_box.SelectedIndexChanged += select_index_change;

		auto_complete_form.Show();
		auto_complete_form.Hide();
	}
	public void transparent()
	{
		SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
		BackColor = Color.Transparent;
	}
};