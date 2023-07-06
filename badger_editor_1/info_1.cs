//badger
using System;//_
using System.Windows.Forms;//_
using System.Drawing;//font

namespace badger_editor_1
{
	public partial class main_form : Form
	{
		private void helpToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			object o = (ToolStripMenuItem)sender;
			string s = o.ToString().Trim();
			label_menu_description1.Text = s;
			/*switch (s.ToLower())
			{
				case "help": label_menu_description1.Text = "[._.]: Help menu."; break;
				case "search": label_menu_description1.Text = "[._.]: Search the internet for 'badger'."; break;
				case "about": label_menu_description1.Text = "[._.]: Learn about the badger editor and it's creator."; break;
				case "welcome": label_menu_description1.Text = "[._.]: The welcome message for new users."; break;
				case "user": label_menu_description1.Text = "[._.]: Displays user/device info."; break;
				default: label_menu_description1.Text = "[._.]: ..."; break;
			}*/
		}
		private void helpToolStripMenuItem_MouseHover(object sender, EventArgs e) { label_menu_description1.Font = new Font(label_menu_description1.Font, FontStyle.Italic); }
		private void helpToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			label_menu_description1.Font = new Font(label_menu_description1.Font, FontStyle.Regular);
			label_menu_description1.Text = "[._.]";
		}
		private void add_menu_event(ToolStripMenuItem A1)
		{
			A1.MouseEnter += new EventHandler(helpToolStripMenuItem_MouseEnter);
			A1.MouseEnter += new EventHandler(helpToolStripMenuItem_MouseHover);
			A1.MouseLeave += new EventHandler(helpToolStripMenuItem_MouseLeave);
		}
		private void load_menu_event()
		{
			add_menu_event(searchToolStripMenuItem);
			add_menu_event(aboutToolStripMenuItem);
			add_menu_event(welcomeToolStripMenuItem);
			add_menu_event(userToolStripMenuItem);
		}
		private void searchToolStripMenuItem_Click(object sender, EventArgs e) { try { new WebBrowser() { Url = new Uri(@"https://www.bing.com/search?q=badger") }.GoSearch(); } catch (Exception A) { new WebBrowser().Navigate(@"https://www.bing.com/search?q=" + A.ToString().Replace(" ", "%20")); } }
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new box_1("About", "[._.]: Howdy there! I am Billy; I hope you like this simple text editor program that was made by Badger in C#. " +
				"This editor was made to make life easier for programmers. " +
				"The editor's purpose was that you would have coding templates, so that when you created a new script, you would already have something created. " +
				"The creator also liked the simplicity of Notepad, but didn't like that it didn't have dark theme and some other features. Have a nice day!", new Size(400, 300)).message();
		}
		private void welcomeToolStripMenuItem_Click(object sender, EventArgs e) { new box_1("Welcome(" + DateTime.Now.ToString() + ")", "[._.]: Hello and welcome to the badger editor; I hope you enjoy the app!").message(); }
		private void userToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new box_1("User(device)", "User platform type/operating system: " + device.operating_system().ToString() + "; " + device.info() + "\nUser I.P(internet protocol) adress: " + device.ip.address() + "\nWifi conncectivity: " + device.wifi.connect()).message();
			new box_1("User(memory)", "Total memory: " + device.storage.space(device.memory.total()) + "\nMemory used: " + device.storage.space(device.memory.use()) + "\nMemory available: " + device.storage.space(device.memory.available()) + "\nMemory percent: " + device.storage.size((ulong)device.memory.percent())).message();
			//new box_1("User(C.P.U)", "C.P.U(central processing unit) name: " + device.cpu.name + "\nC.P.U(central processing unit) usage: " + device.cpu.usage.ToString()).message();
			new box_1("User('C' drive)", "Drive name: " + device.drive.name + "\nDrive total storage: " + device.storage.size((ulong)device.drive.total) + "\nDrive available storage: " + device.storage.size((ulong)device.drive.available) + "\nDrive storage: " + device.storage.size((ulong)device.drive.storage()) + "%").message();
			new box_1("User(file)", "User folder: " + device.file.user() + "\nApplication directory: " + device.file.application()).message();
		}
		private void appToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new box_2("Application", new box_2.text_box("Application path: " + app.path + "\nApplication directory: " + app.dir + "\nApplication name: " + app.name + "\nApplication company: " + app.company + "\nApplication version: " + app.version + "\nApplication test: " + app.test, new box_2.style2(null, null, null)) { WordWrap = false }, null).message();
		}
		private void fileToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			file f = new file(file_name);
			new box_2("File", new box_2.text_box("File: " + file_name + "\nCarriage return: " + f.break_line() + "\nEncode type: " + f.encode().ToString(), new box_2.style2(null, null, null)) { WordWrap = false }, null).message();
		}
	};
};