//badger
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public sealed class syntax_1
{
	private RichTextBox rtb;

	public syntax_1(RichTextBox A1) { rtb = A1; }
	public void highlight(string[] A1, Color[] A2, RegexOptions[] A3)
	{
		int b1 = rtb.SelectionStart; int b2 = rtb.SelectionLength; Color b3 = rtb.ForeColor;
		string line = rtb.Lines[rtb.GetLineFromCharIndex(rtb.SelectionStart)];
		for (int a = 0; a < A1.Length; a++)
		{
			MatchCollection b4 = Regex.Matches(line, A1[a], A3[a]);

			foreach (Match b in b4) { rtb.Select(rtb.GetFirstCharIndexOfCurrentLine(), b.Length); rtb.SelectionColor = A2[a]; }
		}
		rtb.Select(b1, b2); rtb.SelectionColor = b3; rtb.Focus();
	}
};

public sealed class syntax_2
{
	private string text;
	private string[] keyword;
	private RegexOptions[] type;
	private Color[] color;

	public syntax_2(string a1, language.syntax s) { text = a1; keyword = s.keyword; type = s.type; color = s.color; }
	public void highlight(RichTextBox rtb)
	{
		int b1 = rtb.SelectionStart; int b2 = rtb.SelectionLength; Color b3 = rtb.ForeColor;
		for (int a = 0; a < keyword.Length; a++)
		{
			MatchCollection mc = Regex.Matches(text, keyword[a], type[a]);

			foreach (Match m in mc) { rtb.Select(m.Index, m.Length); rtb.SelectionColor = color[a]; }
		}
		rtb.Select(b1, b2); rtb.SelectionColor = b3; rtb.Focus();
	}
	public string[] get()
	{
		string[] b1 = { "" };
		for (int a = 0; a < keyword.Length; a++)
		{
			MatchCollection match = Regex.Matches(text, keyword[a], type[a]);

			b1[a] = match[a].ToString();
		}
		return b1;
	}
};
//add option to return string found, etc