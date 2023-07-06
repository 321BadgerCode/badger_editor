//badger
using System.Drawing;
using System.Text.RegularExpressions;

public static class language
{
	public enum type { visual_basic, c_sharp, b_bad };
	public struct syntax
	{
		public string[] keyword;
		public Color[] color;
		public RegexOptions[] type;
		public syntax(string[] a1, Color[] a2, RegexOptions[] a3) { language.keyword = a1[0]; data_type = a1[1]; comment = a1[2]; quote = a1[3]; /*for (int a = 0; a < language.s.keyword.Length; a++) { lb.Items.AddRange(language.s.keyword[a].Split("|")); }*/ keyword = a1; color = a2; type = a3; }
	};
	public static type t;
	public static syntax s;
	public static string file { get; private set; }
	public static string keyword { get; private set; }
	public static string data_type { get; private set; }
	public static string comment { get; private set; }
	public static string quote { get; private set; }
	public static string[] keyword_list { get; private set; }
	public static class visual_basic
	{
		private static string extra = "\b(AddHandler|AddressOf|Alias|And|AndAlso|As|Boolean|ByRef|Byte|ByVal|Call|Case|Catch|CBool|CByte|CChar|CDate|CDbl|CDec|Char|CInt|Class|CLng|CObj|Const|Continue|CSByte|CShort|CSng|CStr|CType|CUInt|CULng|CUShort|Date|Decimal|Declare|Default|Delegate|Dim|DirectCast|Do|Double|Each|Else|ElseIf|End|EndIf|Enum|Erase|Error|Event|Exit|False|Finally|For|Friend|Function|Get|GetType|GetXMLNamespace|Global|GoSub|GoTo|Handles|If|Implements|Imports|In|Inherits|Integer|Interface|Is|IsNot|Let|Lib|Like|Long|Loop|Me|Mod|Module|MustInherit|MustOverride|MyBase|MyClass|Namespace|Narrowing|New|Next|Not|Nothing|NotInheritable|NotOverridable|Object|Of|On|Operator|Option|Optional|Or|OrElse|Overloads|Overridable|Overrides|ParamArray|Partial|Private|Property|Protected|Public|RaiseEvent|ReadOnly|ReDim|REM|RemoveHandler|Resume|Return|SByte|Select|Set|Shadows|Shared|Short|Single|Static|Step|Stop|String|Structure|Sub|SyncLock|Then|Throw|To|True|Try|TryCast|TypeOf|UInteger|ULong|UShort|Using|Variant|Wend|When|While|Widening|With|WithEvents|WriteOnly|Xor|Region)\b|(#Const|#Else|#ElseIf|#End|#If|#Region)\b";
		public static string file = ".vb";
		public static string keyword { get; } = @"^\s*(end|endif|next|loop)\b|^\s*(if|while|for|do|try|with|using|select)\b|^\s*(else|elseIf|case|catch|finally)\b"+extra;
		public static string type { get; } = @"\b(class|property|enum|structure|sub|function|namespace|interface|get)\b|(set\s*\()|\b(then)\s*\S+";
		public static string comment { get; } = "\'.+?\n";
		public static string quote { get; } = "\".+?\"";
		public static syntax s = new syntax(new string[] { keyword, type, comment, quote }, new Color[] { Color.LightBlue, Color.LightBlue, Color.LightGreen, Color.Orange }, new RegexOptions[] { RegexOptions.IgnoreCase, RegexOptions.IgnoreCase, RegexOptions.IgnoreCase, RegexOptions.IgnoreCase });
	};
	public static class c_sharp
	{
		public static string file { get; } = ".cs";
		public static string keyword { get; } = @"\b(as|const|catch|else|short|long|foreach|for|if|in|public|private|protected|partial|partial|static|try|using|var|virtual|override|get|set)\b";
		public static string type { get; } = @"\b(class|char|int|string|double|void|float|struct|namespace)\b";
		public static string comment { get; } = @"(\/\/.+?$|\/\*.+?\*\/)";
		public static string quote { get; } = "\".+?\"";
		public static syntax s = new syntax(new string[] { keyword, type, comment, quote }, new Color[] { Color.LightBlue, Color.Purple, Color.LightGreen, Color.Yellow }, new RegexOptions[] { RegexOptions.None, RegexOptions.None, RegexOptions.Multiline, RegexOptions.None });
	};
	public static class b_bad
	{
		public static string file { get; } = ".b_bad";
	};
};