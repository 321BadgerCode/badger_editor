//badger
using System.Drawing;
using System.Windows.Forms;

public sealed class console_1
{
	private RichTextBox rtb;

	public console_1(RichTextBox A1) { rtb = A1; }
	public void print(Color? A1, string A2) { rtb.SelectionStart = rtb.TextLength; rtb.SelectionLength = 0; rtb.SelectionColor = A1 ?? rtb.ForeColor; rtb.AppendText(A2); rtb.SelectionColor = rtb.ForeColor; }
};