//badger
using System;//_
using System.ComponentModel;//browsable
using System.Drawing;//size
using System.Windows.Forms;//_

[Browsable(false)]
public class list_box : ListBox
{
	private string[] text;
	private Form form;
	private Action a;
	private void init()
	{
		FormattingEnabled = true;
		ItemHeight = 10;
		Location = new Point(200, 200);
		Size = new Size(200, 200);
		TabIndex = 8;
		BackColor = Color.Black;
		ForeColor = Color.Gray;
		SelectedIndexChanged += select_change;
		KeyDown += key_down;
		DoubleClick += double_click;
	}
	private void select_change(object select, EventArgs e) { value = GetItemText(SelectedItem); }
	private void key_down(object select, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
			case Keys.Enter: select_1(); break;
		}
	}
	private void double_click(object select, EventArgs e) { select_1(); }
	private void select_1() { a(); }

	public string value;
	public list_box(Form? f, Action select, string?[] t)
	{
		a = select;
		init();
		if (f != null) { form = f; form.Controls.Add(this); }
		if (t != null) { text = t; Items.AddRange(text); }
	}
};
//change listbox to be in a form, so that the user can drag the autocomplete box around the screen
//public class list_box : ToolStripDropDown{};
//public class list_box : ComboBox{};
//https://en.wikipedia.org/wiki/Levenshtein_distance
//http://forum.codecall.net/topic/55750-c-tutorial-creating-a-auto-completing-richtextbox/