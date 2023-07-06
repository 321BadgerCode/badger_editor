//badger
using System.IO;
using System.Diagnostics;

public static class compile_1
{
        public static void java(string A1)
        {
                string type = Path.GetExtension(A1);
                Process p = new Process();
                bool b1 = false;
                string b2 = A1.Remove(A1.Length - type.Length);

                p.StartInfo.FileName = b2 + ".exe";
                p.StartInfo.Arguments = A1;
                p.StartInfo.WorkingDirectory = ".\\";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.ErrorDialog = false;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                b1 = p.Start();
        }
};
//make function take string rather than file name
//https://gnuu.org/2009/09/18/writing-your-own-toy-compiler/
//https://www.c-sharpcorner.com/article/creating-java-integrated-development-environmentide-in-c-sharp/