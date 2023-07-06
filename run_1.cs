//badger
using System.CodeDom.Compiler;//CompilerParameters
using Microsoft.CSharp;//CSharpCodeProvider
using System.Diagnostics;//Process
using System.IO;//_

public class run_1
{
	private string input;

	public run_1(string A1) { input = A1; }
	public void c_sharp(string A1)
	{
		CSharpCodeProvider cscp = new CSharpCodeProvider();
		CompilerParameters cp = new CompilerParameters(new string[] { "system.dll" });
		cp.GenerateExecutable = true;
		cp.OutputAssembly = A1;
		CompilerResults cr = cscp.CompileAssemblyFromSource(cp, new string[] { input });

		if (cr.Errors.Count > 0)
		{
			foreach (CompilerError a in cr.Errors)
			{
				string b2 = "File: " + a.FileName + "\n" +
				"ERROR: [" + a.ErrorNumber + "]" + a.ErrorText + "\n" +
				"Line: " + a.Line + "\n" +
				"Column: " + a.Column + "\n" +
				"Warning: " + a.IsWarning.ToString();

				new box_1("ERROR!", b2).error();
			}
		}
		else { Process.Start(A1); }
	}
	public void visual_basic(string file)
	{
		string file_path = Path.GetFullPath(file);
		string file_name = Path.GetFileName(file);

		Process scriptProc = new Process();
		scriptProc.StartInfo.FileName = file_name;
		scriptProc.StartInfo.WorkingDirectory = file_path;
		scriptProc.StartInfo.Arguments = "//B //Nologo vbscript.vbs";
		scriptProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		scriptProc.Start();
		scriptProc.WaitForExit();
		scriptProc.Close();
	}
	public void java()
	{
		string news = input.Remove(input.Length - 5); new box_1("news", news).message();
		string text = ("java " + news + "@pause").Replace("@", System.Environment.NewLine);

		File.WriteAllText(".\\run_1.bat", text);

		try
		{
			Process p = new Process();
			p.StartInfo.FileName = "run_1.bat";
			p.StartInfo.WorkingDirectory = ".\\";
			p.StartInfo.CreateNoWindow = true;
			p.Start();
			p.WaitForExit();
		}
		catch { }
	}
	public void b_bad()
	{
		if (input.IndexOf("print") > 0) { /*new console_1().print(Color.Red, "[._.]: ");*/ }
		/*else if (input.IndexOf("cmd") > 0) { Process p = Process.Start("C:\\WINDOWS\\system32\\cmd.exe"); SendKeys.Send("//badger"); }
		else if (input.IndexOf("convert image") > 0) { new image_1("", 100).ToString(); }
		else if (input.IndexOf("billy")>0) { label_menu_description1.Text = ""; }
		else if (input.IndexOf("box") > 0) { new box_1("","").message(); }*/
	}
};
//fix java compile and run