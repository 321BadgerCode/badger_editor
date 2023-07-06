using System.Drawing;
using System;
using System.Drawing.Drawing2D;

public abstract class Style : IDisposable
{
	protected virtual void AddVisualMarker(FastColoredTextBox tb, StyleVisualMarker marker) { tb.AddVisualMarker(marker); }

	public virtual bool IsExportable { get; set; }
	public event EventHandler<VisualMarkerEventArgs> VisualMarkerClick;
	public Style() { IsExportable = true; }
	public abstract void Draw(Graphics gr, Point position, Range range);
	public virtual void OnVisualMarkerClick(FastColoredTextBox tb, VisualMarkerEventArgs args) { if (VisualMarkerClick != null) { VisualMarkerClick(tb, args); } }
	public static Size GetSizeOfRange(Range range) { return new Size((range.End.iChar - range.Start.iChar) * range.tb.CharWidth, range.tb.CharHeight); }
	public static GraphicsPath GetRoundedRectangle(Rectangle rect, int d)
	{
		GraphicsPath gp = new GraphicsPath();

		gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
		gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
		gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
		gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
		gp.AddLine(rect.X, rect.Y + rect.Height - d, rect.X, rect.Y + d / 2);

		return gp;
	}
	public virtual void Dispose() { }
	public virtual string GetCSS() { return ""; }
	public virtual RTFStyleDescriptor GetRTF() { return new RTFStyleDescriptor(); }
};
public class TextStyle : Style
{
	public Brush ForeBrush { get; set; }
	public Brush BackgroundBrush { get; set; }
	public FontStyle FontStyle { get; set; }
	public StringFormat stringFormat;

	public TextStyle(Brush foreBrush, Brush backgroundBrush, FontStyle fontStyle)
	{
		this.ForeBrush = foreBrush;
		this.BackgroundBrush = backgroundBrush;
		this.FontStyle = fontStyle;
		stringFormat = new StringFormat(StringFormatFlags.MeasureTrailingSpaces);
	}

	public override void Draw(Graphics gr, Point position, Range range)
	{
		if (BackgroundBrush != null) { gr.FillRectangle(BackgroundBrush, position.X, position.Y, (range.End.iChar - range.Start.iChar) * range.tb.CharWidth, range.tb.CharHeight); }
		using (var f = new Font(range.tb.Font, FontStyle))
		{
			Line line = range.tb[range.Start.iLine];
			float dx = range.tb.CharWidth;
			float y = position.Y + range.tb.LineInterval / 2;
			float x = position.X - range.tb.CharWidth / 3;

			if (ForeBrush == null)
				ForeBrush = new SolidBrush(range.tb.ForeColor);

			if (range.tb.ImeAllowed)
			{
				for (int i = range.Start.iChar; i < range.End.iChar; i++)
				{
					SizeF size = FastColoredTextBox.GetCharSize(f, line[i].c);

					var gs = gr.Save();
					float k = size.Width > range.tb.CharWidth + 1 ? range.tb.CharWidth / size.Width : 1;
					gr.TranslateTransform(x, y + (1 - k) * range.tb.CharHeight / 2);
					gr.ScaleTransform(k, (float)Math.Sqrt(k));
					gr.DrawString(line[i].c.ToString(), f, ForeBrush, 0, 0, stringFormat);
					gr.Restore(gs);
					x += dx;
				}
			}
			else
			{
				for (int i = range.Start.iChar; i < range.End.iChar; i++)
				{
					gr.DrawString(line[i].c.ToString(), f, ForeBrush, x, y, stringFormat);
					x += dx;
				}
			}
		}
	}
};