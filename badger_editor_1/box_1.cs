//badger
using System.Drawing;
using System.Windows.Forms;

public class box_1
{
	private bool ok;
	private class form : Form { private const int drop_shadow = 0x20000; protected override CreateParams CreateParams { get { CreateParams cp = base.CreateParams; cp.ClassStyle |= drop_shadow; return cp; } } };
	private void win_setup() { win.AutoSize = true; win.Text = title; label.Text = text; win.Icon = new Icon(icon, icon_size); }
	private void button_setup() { if (t != type.confirm) { buttonOk.Text = "Ok"; buttonCancel.Text = "Cancel"; } else { buttonOk.Text = "Yes"; buttonCancel.Text = "No"; } buttonOk.DialogResult = DialogResult.OK; buttonCancel.DialogResult = DialogResult.Cancel; }
	//private void bound_setup() { label.SetBounds(9, 20, 372, 13); if (t == type.input) { textBox.SetBounds(12, 36, 372, 20); } else if (t == type.slider) { tb.SetBounds(100, 50, 100, 20); } buttonOk.SetBounds(228, 72, 75, 23); buttonCancel.SetBounds(309, 72, 75, 23); }
	//private void bound_setup() { label.SetBounds(10, 20, 350, 10); if (t == type.input) { textBox.SetBounds(10, 30, 350, 20); } else if (t == type.slider) { tb.SetBounds(100, 50, 100, 20); } buttonOk.SetBounds(230, 70, 70, 20); buttonCancel.SetBounds(300, 70, 80, 20); }
	private void bound_setup()
	{
		/*label.SetBounds(10, 10, win.Width, win.Height / 5);
		if (t == type.input) { textBox.SetBounds(10, 30, win.Width - 30, 20); }
		else if (t == type.slider) { tb.SetBounds(10, win.Height / 3, win.Width - 30, 20); }
		else if (t == type.load) { pb.SetBounds(10, 30, win.Width - 30, 20); }*/
		label.SetBounds(10, 10, win.Width, win.Height / 5);
		if (t == type.input) { set(textBox, 3); }
		else if (t == type.slider) { set(tb, 3); }
		else if (t == type.load) { set(pb, 3); }
		buttonOk.SetBounds(win.Width - 140, win.Height / 2, 50, 20);
		buttonCancel.SetBounds(win.Width - 90, win.Height / 2, 80, 20);
	}
	private void anchor_setup()
	{
		if (t == type.input) { textBox.Anchor = textBox.Anchor | AnchorStyles.Right; }
		else if (t == type.slider) { tb.Anchor = tb.Anchor | AnchorStyles.Right; }
		else if (t == type.load) { pb.Anchor = pb.Anchor | AnchorStyles.Right; }
		buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
	}
	private void set(dynamic A1, int A2)
	{
		int b1 = win.Height / A2;
		A1.SetBounds(10, b1, win.Width - b1, b1);
	}

	public enum type { message, error, important, task, confirm, input, slider, load };
	public Form win = new form();
	public Label label = new Label();
	public Button buttonOk = new Button();
	public Button buttonCancel = new Button();
	public TextBox textBox = new TextBox();
	public TrackBar tb = new TrackBar();
	public ProgressBar pb = new ProgressBar();
	public Icon icon;
	public Size size;
	public Size icon_size = new Size(50, 50);
	public type t;
	public string title;
	public string text;
	public box_1(string A1, string A2, Size A3) { title = A1; text = A2; size = A3; }
	public box_1(string A1, string A2) { title = A1; text = A2; size = new Size(400, 250); }
	public void build()
	{
		win_setup(); button_setup(); anchor_setup();

		win.ClientSize = size;

		bound_setup();

		win.FormBorderStyle = FormBorderStyle.FixedDialog;
		win.StartPosition = FormStartPosition.CenterScreen;

		win.MinimizeBox = false;
		win.MaximizeBox = false;

		win.AcceptButton = buttonOk;
		win.CancelButton = buttonCancel;

		if (t == type.input) { win.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel }); }
		else if (t == type.slider) { win.Controls.AddRange(new Control[] { label, tb, buttonOk, buttonCancel }); }
		else if (t == type.load) { win.Controls.AddRange(new Control[] { label, pb, buttonOk, buttonCancel }); }
		else { win.Controls.AddRange(new Control[] { label, buttonOk, buttonCancel }); }

		ok = win.ShowDialog() == DialogResult.OK;
		if (ok == false) { win.Dispose(); }
	}
	public void message() { t = type.message; icon = SystemIcons.Information; build(); }
	public void error() { t = type.error; icon = SystemIcons.Error; build(); }
	public void important() { t = type.important; icon = SystemIcons.Exclamation; build(); }
	public void task() { t = type.task; icon = SystemIcons.Asterisk; build(); }
	public bool confirm() { t = type.confirm; icon = SystemIcons.Question; build(); return ok; }
	public string input() { t = type.input; icon = SystemIcons.Application; build(); return textBox.Text; }
	public int slider(int A1, int A2) { t = type.slider; tb.Minimum = A1; tb.Maximum = A2; icon = SystemIcons.Application; build(); return tb.Value; }
	public void load() { t = type.load; icon = SystemIcons.Application; build(); }
};
//add progress bar and checkbox box
//https://www.c-sharpcorner.com/UploadFile/f5a10c/creating-custom-controls-in-C-Sharp/