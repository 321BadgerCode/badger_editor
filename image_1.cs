//badger
using System;
using System.Drawing;
using System.Text;

public class image_1
{
	private string file;
	private int size;
	private string[] chars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", "&nbsp;" };
	private Bitmap adjust_image(Bitmap A1, int A2)
	{
		int asciiHeight = (int)Math.Ceiling((double)A1.Height * A2 / A1.Width);

		Bitmap result = new Bitmap(A2, asciiHeight);

		Graphics g = Graphics.FromImage((Image)result);
		g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
		g.DrawImage(A1, 0, 0, A2, asciiHeight);
		g.Dispose();

		return result;
	}
	private string convert_image(Bitmap A1)
	{
		Boolean toggle = false;

		StringBuilder sb = new StringBuilder();

		for (int h = 0; h < A1.Height; h++)
		{
			for (int w = 0; w < A1.Width; w++)
			{
				Color pixelColor = A1.GetPixel(w, h);

				int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
				int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
				int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
				Color grayColor = Color.FromArgb(red, green, blue);

				if (!toggle) { int index = (grayColor.R * 10) / 255; sb.Append(chars[index]); }
			}
			if (!toggle) { sb.Append("\n"); toggle = true; }
			else { toggle = false; }
		}
		return sb.ToString();
	}

	public image_1(string A1, int A2) { file = A1; size = A2; }
	public override string ToString() { Bitmap image = new Bitmap(file, true); image = adjust_image(image, size); return convert_image(image).Replace("&nbsp;", " ").Replace("<BR>", "\n"); }
};