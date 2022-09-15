using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

internal class Class32
{
	public static IDictionary idictionary_0;

	protected Class48 class48_0 = new Class48();

	protected Class31 class31_0;

	protected WebResponse webResponse_0;

	protected string string_0 = null;

	protected byte[] byte_0 = null;

	public DateTime dateTime_0;

	static Class32()
	{
		idictionary_0 = new Hashtable();
		idictionary_0.Add(HttpStatusCode.BadGateway, 502);
		idictionary_0.Add(HttpStatusCode.BadRequest, 400);
		idictionary_0.Add(HttpStatusCode.Conflict, 409);
		idictionary_0.Add(HttpStatusCode.Continue, 100);
		idictionary_0.Add(HttpStatusCode.Created, 201);
		idictionary_0.Add(HttpStatusCode.ExpectationFailed, 417);
		idictionary_0.Add(HttpStatusCode.Forbidden, 403);
		idictionary_0.Add(HttpStatusCode.Found, 302);
		idictionary_0.Add(HttpStatusCode.GatewayTimeout, 504);
		idictionary_0.Add(HttpStatusCode.Gone, 410);
		idictionary_0.Add(HttpStatusCode.HttpVersionNotSupported, 505);
		idictionary_0.Add(HttpStatusCode.InternalServerError, 500);
		idictionary_0.Add(HttpStatusCode.LengthRequired, 411);
		idictionary_0.Add(HttpStatusCode.MethodNotAllowed, 405);
		idictionary_0.Add(HttpStatusCode.MovedPermanently, 301);
		idictionary_0.Add(HttpStatusCode.MultipleChoices, 300);
		idictionary_0.Add(HttpStatusCode.NoContent, 204);
		idictionary_0.Add(HttpStatusCode.NonAuthoritativeInformation, 203);
		idictionary_0.Add(HttpStatusCode.NotAcceptable, 406);
		idictionary_0.Add(HttpStatusCode.NotFound, 404);
		idictionary_0.Add(HttpStatusCode.NotImplemented, 501);
		idictionary_0.Add(HttpStatusCode.NotModified, 304);
		idictionary_0.Add(HttpStatusCode.OK, 200);
		idictionary_0.Add(HttpStatusCode.PartialContent, 206);
		idictionary_0.Add(HttpStatusCode.PaymentRequired, 402);
		idictionary_0.Add(HttpStatusCode.PreconditionFailed, 412);
		idictionary_0.Add(HttpStatusCode.ProxyAuthenticationRequired, 407);
		idictionary_0.Add(HttpStatusCode.SeeOther, 303);
		idictionary_0.Add(HttpStatusCode.RequestedRangeNotSatisfiable, 416);
		idictionary_0.Add(HttpStatusCode.RequestEntityTooLarge, 413);
		idictionary_0.Add(HttpStatusCode.RequestTimeout, 408);
		idictionary_0.Add(HttpStatusCode.RequestUriTooLong, 414);
		idictionary_0.Add(HttpStatusCode.ResetContent, 205);
		idictionary_0.Add(HttpStatusCode.ServiceUnavailable, 503);
		idictionary_0.Add(HttpStatusCode.SwitchingProtocols, 101);
		idictionary_0.Add(HttpStatusCode.TemporaryRedirect, 307);
		idictionary_0.Add(HttpStatusCode.Unauthorized, 401);
		idictionary_0.Add(HttpStatusCode.UnsupportedMediaType, 415);
		idictionary_0.Add(HttpStatusCode.Unused, 306);
		idictionary_0.Add(HttpStatusCode.UseProxy, 305);
	}

	public Class32(WebResponse webResponse_1, Class31 class31_1)
	{
		class31_0 = class31_1;
		webResponse_0 = webResponse_1;
		foreach (string key in webResponse_0.Headers.Keys)
		{
			class48_0.vmethod_1(key, webResponse_0.Headers[key]);
		}
	}

	[SpecialName]
	public Class31 method_0()
	{
		return class31_0;
	}

	public bool method_1(Stream stream_0)
	{
		Stream responseStream = webResponse_0.GetResponseStream();
		if (!Class51.smethod_22(responseStream, stream_0))
		{
			responseStream.Close();
			return false;
		}
		responseStream.Close();
		return true;
	}

	protected byte[] method_2()
	{
		MemoryStream memoryStream = new MemoryStream();
		if (!method_1(memoryStream))
		{
			memoryStream.Close();
			return null;
		}
		byte_0 = memoryStream.ToArray();
		memoryStream.Close();
		return byte_0;
	}

	protected string method_3()
	{
		if (byte_0 == null && method_2() == null)
		{
			return null;
		}
		return string_0 = Class12.encoding_0.GetString(byte_0);
	}

	[SpecialName]
	public string method_4()
	{
		if (string_0 == null)
		{
			return method_3();
		}
		return string_0;
	}

	[SpecialName]
	public byte[] method_5()
	{
		if (byte_0 == null)
		{
			return method_2();
		}
		return byte_0;
	}

	[SpecialName]
	public Class48 method_6()
	{
		return class48_0;
	}

	[SpecialName]
	public WebResponse method_7()
	{
		return webResponse_0;
	}

	[SpecialName]
	public HttpWebResponse method_8()
	{
		return webResponse_0 as HttpWebResponse;
	}

	[SpecialName]
	public FileWebResponse method_9()
	{
		return webResponse_0 as FileWebResponse;
	}

	[SpecialName]
	public int method_10()
	{
		if (method_8() == null)
		{
			return -1;
		}
		return (int)idictionary_0[method_8().StatusCode];
	}

	[SpecialName]
	public Uri method_11()
	{
		return webResponse_0.ResponseUri;
	}
}
