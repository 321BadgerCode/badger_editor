//badger

public static class type
{
	public enum data_type { image, video, audio, text, language };
	public static data_type dt;
	public static string all { get; private set; } = ".*";
	public static string text { get; private set; } = ".txt";
	public static string[] image { get; private set; } = { ".bmp", ".jpg", ".gif" };
	public static string video { get; private set; } = ".mp4";
	public static string[] sound { get; private set; } = { ".wav", ".mp3" };
	public static string filter { get; private set; } = "All file types(*.*)|*" + all + "|Text file types(*.txt)|*" + text;
	public static string[] language { get; private set; } = { ".c", ".cpp", ".cs", ".vb", ".b_bad" };
};