//badger
using System;
using System.Linq;
using System.Text;

public static class type_1
{
	public static string type<A>(A A1) { return A1.GetType().ToString(); }
	public static class string_1
	{
		public static string hexidecimal(string A1) { string b1 = ""; byte[] bytes = Encoding.Default.GetBytes(A1); string hexString = BitConverter.ToString(bytes); b1 = hexString.Replace("-", ""); return b1; }
		public static string hexidecimal2(string A1) { string b1 = ""; b1 = string.Join("", A1.Select(a => String.Format("{0:X2}", Convert.ToInt32(a)))); return b1; }
		public static string hexidecimal3(string A1) { string b1 = ""; b1 = Convert.ToInt32(A1).ToString(); return b1; }
		public static string binary(string A1) { string b1 = BitConverter.ToString(BitConverter.GetBytes(Convert.ToInt32(A1))); return b1; }
		public static string assembly(string A1) { return A1.GetType().Assembly.ToString(); }
	};
	public static class hexidecimal_1
	{
		public static string string2(string A1)
		{
			string b1 = "";
			foreach (string a in A1.Split(' '))
			{
				int value = Convert.ToInt32(a, 16);
				char char_value = (char)value;
				b1 += char_value;
			}
			return b1;
		}
	};
};
//https://users.cs.fiu.edu/~downeyt/cda4101/hex2mal.html