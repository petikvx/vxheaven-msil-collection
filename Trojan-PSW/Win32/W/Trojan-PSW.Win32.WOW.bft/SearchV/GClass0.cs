using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Threading;
using System.Windows.Forms;

namespace SearchV;

public class GClass0
{
	private static uint uint_0 = 3862272608u;

	public string method_0(string string_0)
	{
		try
		{
			string string_ = method_1(string_0);
			string text = method_6(string_);
			string[] array = text.Split(new char[1] { ':' });
			return array[2];
		}
		catch (Exception)
		{
		}
		return "0";
	}

	private string method_1(string string_0)
	{
		string text = "info:" + string_0;
		Application.DoEvents();
		return "http://www.google.com/search?client=navclient-auto&ch=6" + method_5(method_2(text)) + "&features=Rank&q=" + text;
	}

	private int[] method_2(string string_0)
	{
		int length = string_0.Length;
		int[] array = new int[length];
		for (int i = 0; i < length; i++)
		{
			array[i] = string_0[i];
		}
		return array;
	}

	private int method_3(int int_0, int int_1)
	{
		uint num = 2147483648u;
		if ((0x80000000L & int_0) == 0L)
		{
			int_0 >>= int_1;
		}
		else
		{
			int_0 >>= 1;
			int_0 &= (int)(~num);
			int_0 |= 0x40000000;
			int_0 >>= int_1 - 1;
		}
		return int_0;
	}

	private int[] method_4(int int_0, int int_1, int int_2)
	{
		int_0 -= int_1;
		int_0 -= int_2;
		int_0 ^= method_3(int_2, 13);
		int_1 -= int_2;
		int_1 -= int_0;
		int_1 ^= int_0 << 8;
		int_2 -= int_0;
		int_2 -= int_1;
		int_2 ^= method_3(int_1, 13);
		int_0 -= int_1;
		int_0 -= int_2;
		int_0 ^= method_3(int_2, 12);
		int_1 -= int_2;
		int_1 -= int_0;
		int_1 ^= int_0 << 16;
		int_2 -= int_0;
		int_2 -= int_1;
		int_2 ^= method_3(int_1, 5);
		int_0 -= int_1;
		int_0 -= int_2;
		int_0 ^= method_3(int_2, 3);
		int_1 -= int_2;
		int_1 -= int_0;
		int_1 ^= int_0 << 10;
		int_2 -= int_0;
		int_2 -= int_1;
		int_2 ^= method_3(int_1, 15);
		return new int[3] { int_0, int_1, int_2 };
	}

	private int method_5(int[] int_0)
	{
		int num = (int)uint_0;
		int num2 = -1640531527;
		int num3 = -1640531527;
		int[] array = new int[3];
		int num4 = int_0.Length;
		int num5 = num;
		int num6 = 0;
		int num7;
		for (num7 = num4; num7 >= 12; num7 -= 12)
		{
			Application.DoEvents();
			num3 += int_0[num6] + (int_0[num6 + 1] << 8) + (int_0[num6 + 2] << 16) + (int_0[num6 + 3] << 24);
			num2 += int_0[num6 + 4] + (int_0[num6 + 5] << 8) + (int_0[num6 + 6] << 16) + (int_0[num6 + 7] << 24);
			num5 += int_0[num6 + 8] + (int_0[num6 + 9] << 8) + (int_0[num6 + 10] << 16) + (int_0[num6 + 11] << 24);
			array = method_4(num3, num2, num5);
			num3 = array[0];
			num2 = array[1];
			num5 = array[2];
			num6 += 12;
		}
		num5 += num4;
		switch (num7)
		{
		case 11:
			num5 += int_0[num6 + 10] << 24;
			goto case 10;
		case 10:
			num5 += int_0[num6 + 9] << 16;
			goto case 9;
		case 9:
			num5 += int_0[num6 + 8] << 8;
			goto case 8;
		case 8:
			num2 += int_0[num6 + 7] << 24;
			goto case 7;
		case 7:
			num2 += int_0[num6 + 6] << 16;
			goto case 6;
		case 6:
			num2 += int_0[num6 + 5] << 8;
			goto case 5;
		case 5:
			num2 += int_0[num6 + 4];
			goto case 4;
		case 4:
			num3 += int_0[num6 + 3] << 24;
			goto case 3;
		case 3:
			num3 += int_0[num6 + 2] << 16;
			goto case 2;
		case 2:
			num3 += int_0[num6 + 1] << 8;
			goto case 1;
		case 1:
			num3 += int_0[num6];
			break;
		}
		array = method_4(num3, num2, num5);
		return array[2];
	}

	private string method_6(string string_0)
	{
		Application.DoEvents();
		string result = "\n\nRank_1:1:0\n\n";
		Random random = new Random();
		WebRequest webRequest = null;
		HttpRequestCachePolicy httpRequestCachePolicy = null;
		StreamReader streamReader = null;
		Stream stream = null;
		HttpWebResponse httpWebResponse = null;
		try
		{
			Thread.Sleep(1000 * random.Next(10));
			webRequest = WebRequest.Create(string_0);
			httpRequestCachePolicy = (HttpRequestCachePolicy)(webRequest.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore));
			httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			stream = httpWebResponse.GetResponseStream();
			streamReader = new StreamReader(stream);
			result = streamReader.ReadToEnd();
		}
		catch (Exception)
		{
		}
		if (streamReader != null)
		{
			streamReader.Close();
			streamReader = null;
		}
		if (stream != null)
		{
			stream.Close();
			stream = null;
		}
		if (httpWebResponse != null)
		{
			httpWebResponse.Close();
			httpWebResponse = null;
		}
		webRequest = null;
		httpRequestCachePolicy = null;
		return result;
	}
}
