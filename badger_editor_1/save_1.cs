//badger
using System.IO;

public sealed class save_1
{
	public save_1(string A1) { file = A1; }
	public string file;
	public void save(string A1) { StreamWriter sw = new StreamWriter(file); sw.Write(A1); sw.Close(); }
	public void save(string[] A1) { StreamWriter sw = new StreamWriter(file); for (int a = 0; a < A1.Length; a++) { sw.Write(A1[a] + "\n"); } sw.Close(); }
};