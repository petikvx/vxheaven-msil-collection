using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace SQLINJECT2;

public class Utilities
{
	public enum RichTextboxTypeSearch
	{
		New = 1,
		Next,
		Previous
	}

	public enum enumSQLServerOptions
	{
		DISABLE_DEF_CNST_CHK = 1,
		IMPLICIT_TRANSACTIONS = 2,
		CURSOR_CLOSE_ON_COMMIT = 4,
		ANSI_WARNINGS = 8,
		ANSI_PADDING = 0x10,
		ANSI_NULLS = 0x20,
		ARITHABORT = 0x40,
		ARITHIGNORE = 0x80,
		QUOTED_IDENTIFIER = 0x100,
		NOCOUNT = 0x200,
		ANSI_NULL_DFLT_ON = 0x400,
		ANSI_NULL_DFLT_OFF = 0x800,
		CONCAT_NULL_YIELDS_NULL = 0x1000,
		NUMERIC_ROUNDABORT = 0x2000,
		XACT_ABORT = 0x4000
	}

	public const int ENCODE_ERROR_CODE = -111111;

	private const int XML_ERROR_FORMAT = -2146233079;

	private const string USER_AGENTS_FILE = "userAgents.xml";

	private const string USER_AGENT_NAME = "name";

	private const string USER_AGENT_ID = "id";

	public static void CopyStream(Stream sourceStream, Stream destinationStream)
	{
		byte[] array = new byte[4096];
		try
		{
			while (true)
			{
				int num = sourceStream.Read(array, 0, array.Length);
				if (num > 0)
				{
					destinationStream.Write(array, 0, num);
					continue;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ex.Source = ex.Source + "\nInside the method: " + MethodBase.GetCurrentMethod()!.Name;
			throw ex;
		}
	}

	public static string GetStreamHTMLData(Stream currentStream, string charSet, bool supportSeek)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = null;
		int num = 0;
		byte[] array = new byte[8192];
		if (supportSeek)
		{
			currentStream.Position = 0L;
		}
		try
		{
			do
			{
				num = currentStream.Read(array, 0, array.Length);
				if (num == 0)
				{
					continue;
				}
				if (charSet != null)
				{
					if (charSet.Trim() != "")
					{
						try
						{
							text = Encoding.GetEncoding(charSet).GetString(array, 0, num);
						}
						catch (ArgumentException ex)
						{
							ex.Source = ex.Source + "\nInside the method: " + MethodBase.GetCurrentMethod()!.Name;
							throw new ArgumentException(Convert.ToString(-111111), ex);
						}
					}
					else
					{
						text = Encoding.ASCII.GetString(array, 0, num);
					}
				}
				else
				{
					text = Encoding.ASCII.GetString(array, 0, num);
				}
				stringBuilder.Append(text);
			}
			while (num > 0);
			currentStream?.Close();
			return stringBuilder.ToString();
		}
		catch (Exception ex2)
		{
			ex2.Source = ex2.Source + "\nInside the method: " + MethodBase.GetCurrentMethod()!.Name;
			throw ex2;
		}
	}
}
