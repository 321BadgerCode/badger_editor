//badger
using System;//_
using System.IO;//file
using System.Windows.Forms;//_

namespace badger_editor_1
{
	public partial class main_form : Form
	{
		list_box lb;
		private void main_1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (error_file_unsaved() == false) { e.Cancel = true; }
			else
			{
				new file(Application.StartupPath + "file_1.b_save").write(file_name);

				richTextBox1.SaveFile(Application.StartupPath + "text_box_1.b_save");
			}
		}
		private void main_1_Load(object sender, EventArgs e)
		{
			if (File.Exists(Application.StartupPath + "text_box_1.b_save")) { richTextBox1.LoadFile(Application.StartupPath + "text_box_1.b_save"); }
			set_text_box_values();
			get_line_number();
			file_name = new file(Application.StartupPath + "file_1.b_save").read();
			richTextBox1.Text = new file(file_name).read();

			set_saved(true);
			richTextBox1.AllowDrop = true;
			richTextBox1.DragDrop += richTextBox1_DragDrop;
			set_file(file_name);
			load_menu_event();
		}
		private void main_1_Shown(object sender, EventArgs e)
		{
			richTextBox1.Text = richTextBox1.Text.Trim();
			richTextBox1.Text.Normalize();
		}
		private void autocomplete_box_setup()
		{
			language.s = new language.syntax(language.c_sharp.s.keyword, language.c_sharp.s.color, language.c_sharp.s.type);
			lb = new list_box(this, autocomplete_select, null);
			for (int a = 0; a < language.s.keyword.Length; a++) { lb.Items.AddRange(language.s.keyword[a].Split("|")); }
		}
		private void init()
		{
			autocomplete_box_setup();
		}
		private void autocomplete_select()
		{
			richTextBox1.Select(first_char, richTextBox1.Lines[line].Length);
			richTextBox1.SelectedText += lb.value;
		}

		public main_form()
		{
			init();
			InitializeComponent();
			string a1 = new box_2("title", new box_2.text_box("text", new box_2.style2(null, null, null)) { WordWrap = false, ScrollBars = ScrollBars.Both }, null).input();
			new box_2("title", new box_2.text_box(a1, new box_2.style2(null, null, System.Drawing.Color.Green)), null) { FormBorderStyle = FormBorderStyle.SizableToolWindow, MaximizeBox = true, ShowInTaskbar = true }.message();
		}
	};
};
//https://www.codeproject.com/Articles/161871/Fast-Colored-TextBox-for-syntax-highlighting-2
//https://github.com/PavelTorgashov/FastColoredTextBox/tree/master/FastColoredTextBox
//fix zoom label
//fix binary conversion, so it automatically adds new lines when neccessary
//fix app parameter/let user open files with this app without opening the app and then opening files from the app
//add nullable vectors
//fix