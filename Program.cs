//badger
using System;
using System.Windows.Forms;

#if (!NETCOREAPP3_0_OR_GREATER)
#error [._.]: ERROR: THE FRAMEWORK IS NOT 3.0 OR ABOVE!
#endif

namespace badger_editor_1
{
	static class Program
	{
		[STAThread()]
		static void Main(string[] file)
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			for (int a = 0; a < file.Length; a++)
			{
				main_form mf = new main_form();
				mf.open_file(file[a]);
			}

			Application.Run(new main_form());
		}
	};
};
//Environment.GetCommandLineArgs();//this gets my .dll for this app somehow. lol