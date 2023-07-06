//badger
using System;//_
using System.IO;//File
using System.Drawing.Printing;//PrintDocument
using System.Drawing;//_
using System.Windows.Forms;//_

namespace badger_editor_1
{
	public partial class main_form
	{
		private string dir;
		private string file_path;
		private string file_name;
		private string file_type;
		private bool saved;
		private bool error_file_unsaved() { bool b1 = false; if (saved == false) { new box_1("ERROR!", "[._.]: ERROR: WARNING; YOU DID NOT SAVE YOUR PROJECT!", new Size(300, 200)).error(); b1 = new box_1("Confirm", "[._.]: Are you sure that you want to discard your project?", new Size(300, 200)).confirm(); } return b1; }
		private void optimize_file() { richTextBox1.Text = richTextBox1.Text.Replace(" \n", "\n"); }
		private void set_file(string A1)
		{
			file_name = A1;
			file_path = Path.GetFullPath(file_name);
			file_type = Path.GetExtension(A1);

			if (file_type == ".txt") { type.dt = type.data_type.text; }
			for (int a = 0; a < type.image.Length; a++) { if (file_type == type.image[a]) { type.dt = type.data_type.image; } }
			for (int a = 0; a < type.sound.Length; a++) { if (file_type == type.sound[a]) { type.dt = type.data_type.audio; } }

			if (file_type == ".cs") { language.t = language.type.c_sharp; type.dt = type.data_type.language; }
			else if (file_type == ".vb") { language.t = language.type.visual_basic; type.dt = type.data_type.language; }
			else if (file_type == ".vbs") { language.t = language.type.visual_basic; type.dt = type.data_type.language; }
			else if (file_type == ".b_bad") { language.t = language.type.b_bad; type.dt = type.data_type.language; }
		}
		private void save_file(string A1)
		{
			if (type.dt == type.data_type.text || type.dt == type.data_type.language)
			{
				StreamWriter sw = new StreamWriter(A1);
				sw.Write(richTextBox1.Text);
				sw.Close();
				set_file(A1);
				set_saved(true);
			}
		}
		private void set_saved(bool A1) { if (file_name != "") { if (A1 == false) { Text = "BADGER_EDITOR(" + file_name + "*)!"; } else { Text = "BADGER_EDITOR(" + file_name + ")!"; } } saved = A1; }
		private void newToolStripMenuItem_Click(object sender, EventArgs e) { new main_form().Show(); }
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (error_file_unsaved() == true)
			{
				OpenFileDialog ofd = new OpenFileDialog() { Title = "BADGER_EDITOR(CHOOSE A FILE TO OPEN IN THE EDITOR)!", CheckFileExists = true, Filter = type.filter/*, Multiselect = true*/ };
				if (dir != "") { ofd.InitialDirectory = dir; }
				if (ofd.ShowDialog() == DialogResult.OK) { open_file(ofd.FileName); }
			}
		}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.UseWaitCursor = true;
			if (!File.Exists(file_name))
			{
				SaveFileDialog sfd = new SaveFileDialog() { Title = "BADGER_EDITOR(CHOOSE A PLACE TO SAVE YOUR FILE)!", Filter = type.filter, };
				if (dir != "") { sfd.InitialDirectory = dir; }
				if (sfd.ShowDialog() == DialogResult.OK) { save_file(sfd.FileName); }
			}
			else { optimize_file(); save_file(file_name); }
			richTextBox1.UseWaitCursor = false;
		}
		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PrintDocument pd = new PrintDocument() { DocumentName = file_name }; PrintPreviewDialog pvd = new PrintPreviewDialog(); PrintDialog pd2 = new PrintDialog();
			try { pd.PrintPage += new PrintPageEventHandler(pd_PrintPage); pd2.Document = pd; pvd.Document = pd; if (pd2.ShowDialog() == DialogResult.OK) { pvd.ShowDialog(); } }
			catch (Exception A) { MessageBox.Show(A.ToString()); }
		}
		private void pd_PrintPage(Object sender, PrintPageEventArgs e) { e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, new PointF(100, 100)); }
		private void exitToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }
		private void clearToolStripMenuItem_Click(object sender, EventArgs e) { if (error_file_unsaved() == true) { richTextBox1.Clear(); } }
		private void runToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				run_1 run = new run_1(richTextBox1.Text);
				if (saved == true)
				{
					if (language.t == language.type.c_sharp) { SaveFileDialog sfd = new SaveFileDialog() { Title = "BADGER_EDITOR(CHOOSE A PLACE TO SAVE YOUR FILE)!", Filter = "Executable file type(*.exe)|*.exe", InitialDirectory = file_path }; if (sfd.ShowDialog() == DialogResult.OK) { run.c_sharp(sfd.FileName); } }
					else if (language.t == language.type.visual_basic) { run.visual_basic(file_name); }
					else if (language.t == language.type.b_bad) { run.b_bad(); }
				}
				else { new box_1("ERROR!", "ERROR: YOU MUST SAVE YOUR FILE FIRST BEFORE RUNNING IT!").error(); }
			}
			catch (Exception A) { new box_1("ERROR!", "ERROR: COULD NOT RUN PROGRAM!").error(); new box_1("ERROR!", A.ToString()).error(); }
		}

		public void open_file(string file)
		{
			try
			{
				/*for (int a = 0; a < ofd.FileNames.Length; a++)
				{
					file_path = Path.GetFullPath(file_name);
					file_type = Path.GetExtension(ofd.FileNames[a]);
					main_1 b1 = new main_1(); b1.Show();
					for (int b = 0; b < image.Length; b++) { if (file_type == image[b]) { int zoom = new box_1("Zoom", "Set the zoom value of the image").slider(1, 100); b1.richTextBox1.Text = new convert_image_1().convert_image_to_text(ofd.FileNames[a], zoom); b1.richTextBox1.Text = b1.richTextBox1.Text.Replace("&nbsp;", " ").Replace("<BR>", "\n"); } }
					for (int b = 0; b < sound.Length; b++) { if (file_type == sound[b]) { new audio_1().play(ofd.FileNames[a]); } }
					StreamReader sr = new StreamReader(ofd.FileNames[a]);
					b1.richTextBox1.Text = sr.ReadToEnd();
					sr.Close();
					optimize_file();
					save_file(file_name);
					b1.file_name = ofd.FileNames[a];
				}*/
				if (type.dt == type.data_type.image) { int zoom = new box_1("Zoom", "Set the zoom value of the image").slider(1, 100); richTextBox1.Text = new image_1(file, zoom).ToString(); }
				else if (type.dt == type.data_type.audio) { audio_1.play(file); }
				else
				{
					StreamReader sr = new StreamReader(file);
					richTextBox1.Text = sr.ReadToEnd();
					sr.Close();
					optimize_file();
					save_file(file);
				}
			}
			catch (Exception A) { MessageBox.Show("ERROR: FILE TYPE NOT COMPATIBLE WITH EDITOR!"); MessageBox.Show(A.ToString()); }
		}
	};
};