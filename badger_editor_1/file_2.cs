//badger
using System;//_
using System.IO;//file
using System.Text;//encoding

public sealed class file : IDisposable
{
	private string file_name;

	public file(string A1) { file_name = A1; if (exist() == false) { create(); } }
	public static class carriage_return
	{
		public struct cr
		{
			public cr(string type1, string ascii1, string new_line1, string[] device_type1, string device_os1) {
				type = type1;
				string[] word = type.Split(" ");
				abbreviation = "";
				for (int a = 0; a < word.Length; a++) { abbreviation += word[a][0].ToString().ToUpper()+"."; }
				ascii = ascii1;
				new_line = new_line1;
				device_type = device_type1;
				device_os = device_os1;
			}
			public cr(types a1)
			{
				cr b1 = new cr();
				if (a1 == types.line_feed) { b1 = new cr("Line Feed", "0x0A", "\\n", new string[] { "Linux", "Mac", "OSX" }, "Unix Operating System"); }
				else if (a1 == types.end_of_line) { b1 = new cr("End of Line", "0x0D 0x0A", "\\r\\n", new string[] { "Microsoft Windows", "Symbian OS" }, "Not Unix Operating System"); }
				this = b1;
			}
			public enum types { line_feed, end_of_line };
			public string type;
			public string abbreviation;
			public string ascii;
			public string new_line;
			public string[] device_type;
			public string device_os;
			public override string ToString()
			{
				string device_type_1 = "";
				for (int a = 0; a < device_type.Length; a++) { device_type_1 += device_type[a] + ", "; }
				string b1 = type + "(" + abbreviation + ")" + " : " + ascii + ", '" + new_line + "', " + device_type_1 + ", " + device_os;
				return b1;
			}
		};
		public static cr line_feed = new cr(cr.types.line_feed);
		public static cr end_of_line = new cr(cr.types.end_of_line);
	};
	public void create() { File.Create(file_name); }
	public void delete() { File.Delete(file_name); }
	public void write(string A1) { File.WriteAllText(file_name, A1); }
	public string read() { return File.ReadAllText(file_name); }
	public bool exist() { return File.Exists(file_name); }
	public void encrypt() { File.Encrypt(file_name); }
	public Encoding encode() { using (var reader = new StreamReader(file_name, Encoding.Default, true)) { if (reader.Peek() >= 0) reader.Read(); return reader.CurrentEncoding; } }
	public string break_line() {
		string b1 = "";
		if (Environment.NewLine == "\n") { b1 = carriage_return.line_feed.ToString(); }
		else if (Environment.NewLine == "\r\n") { b1 = carriage_return.end_of_line.ToString(); }
		return b1;
	}
	//public string binary() { byte[] b1 = File.ReadAllBytes(file); return b1.ToString(); }
	//public void set_binary(byte[] A1) { File.WriteAllBytes(file, A1); }
	public void Dispose() { new StreamReader(file_name).Dispose(); }
};
//fix binary converter