//badger
using System.Windows.Forms;

public class notification_form : Form
{
	protected override bool ShowWithoutActivation { get { return true; } }
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams baseParams = base.CreateParams;
			const int WS_EX_NOACTIVATE = 0x08000000;
			const int WS_EX_TOOLWINDOW = 0x00000080;
			baseParams.ExStyle |= (int)(WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW);
			return baseParams;
		}
	}

	public notification_form() { ShowInTaskbar = false; FormBorderStyle = FormBorderStyle.None; }
};