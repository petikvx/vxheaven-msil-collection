using System.Globalization;
using System.Text.RegularExpressions;

namespace WoW_Sharp;

public class WoW_ChatLogLine
{
	private static Regex regex_0 = new Regex("^\\[(?<time>[\\d,:]{8})\\]\\[(?<id>[\\d,A-F]{2})\\]\\[(?<idstring>.[^\\]]+)\\](?:<(?<param5>.[^>]+)>){0,1}(?:\\((?<param4>.[^\\)]+)\\)){0,1}(?:\\{(?<param3>.[^\\}]+)\\}){0,1}(?:\\[(?<param2>.[^\\]]+)\\]){0,1}(?:: (?<param1>.+)){0,1}$");

	private string string_0 = "";

	private bool bool_0 = false;

	private int int_0 = -1;

	private string string_1 = "";

	private string string_2 = "";

	private string string_3 = "";

	private string string_4 = "";

	private string string_5 = "";

	private string string_6 = "";

	public string RawLine => string_0;

	public bool IsValid => bool_0;

	public int Id => int_0;

	public string IdString => string_1;

	public string Message => string_2;

	public string Sender => string_3;

	public string SenderStatus => string_6;

	public string Channel => string_4;

	public string Param1 => string_2;

	public string Param2 => string_3;

	public string Param3 => string_4;

	public string Param4 => string_5;

	public string Param5 => string_6;

	internal WoW_ChatLogLine(string string_7)
	{
		string_0 = string_7;
		Match match = regex_0.Match(string_7);
		bool_0 = match.Success;
		if (match.Success)
		{
			int_0 = int.Parse(match.Groups["id"].Value, NumberStyles.AllowHexSpecifier);
			string_1 = match.Groups["idstring"].Value;
			string_2 = match.Groups["param1"].Value;
			string_3 = match.Groups["param2"].Value;
			string_4 = match.Groups["param3"].Value;
			string_5 = match.Groups["param4"].Value;
			string_6 = match.Groups["param5"].Value;
		}
	}
}
