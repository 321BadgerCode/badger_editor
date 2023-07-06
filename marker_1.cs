//badger
using System.Drawing;
using System.Windows.Forms;

public class marker_1
{
	public readonly Rectangle rectangle;
	public marker_1(Rectangle A1) { rectangle = A1; }
	public virtual void Draw(Graphics gr, Pen pen) { }
	public virtual Cursor Cursor { get { return Cursors.Hand; } }
};
public class CollapseFoldingMarker : marker_1
{
	public readonly int iLine;
	public CollapseFoldingMarker(int iLine, Rectangle rectangle) : base(rectangle)
	{
		this.iLine = iLine;
	}
	public void Draw(Graphics gr, Pen pen, Brush backgroundBrush, Pen forePen)
	{
		//draw minus
		gr.FillRectangle(backgroundBrush, rectangle);
		gr.DrawRectangle(pen, rectangle);
		gr.DrawLine(forePen, rectangle.Left + 2, rectangle.Top + rectangle.Height / 2, rectangle.Right - 2, rectangle.Top + rectangle.Height / 2);
	}
};
public class ExpandFoldingMarker : marker_1
{
	public readonly int iLine;
	public ExpandFoldingMarker(int iLine, Rectangle rectangle): base(rectangle){this.iLine = iLine;}
	public void Draw(Graphics gr, Pen pen, Brush backgroundBrush, Pen forePen)
	{
		//draw plus
		gr.FillRectangle(backgroundBrush, rectangle);
		gr.DrawRectangle(pen, rectangle);
		gr.DrawLine(forePen, rectangle.Left + 2, rectangle.Top + rectangle.Height / 2, rectangle.Right - 2, rectangle.Top + rectangle.Height / 2);
		gr.DrawLine(forePen, rectangle.Left + rectangle.Width / 2, rectangle.Top + 2, rectangle.Left + rectangle.Width / 2, rectangle.Bottom - 2);
	}
};
public class FoldedAreaMarker : marker_1
{
	public readonly int iLine;
	public FoldedAreaMarker(int iLine, Rectangle rectangle) : base(rectangle) { this.iLine = iLine; }
	public override void Draw(Graphics gr, Pen pen) { gr.DrawRectangle(pen, rectangle); }
};