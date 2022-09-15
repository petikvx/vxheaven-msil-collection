using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

internal class Class27
{
	public static Hashtable hashtable_0;

	protected Class38 class38_0 = new Class38();

	protected Class26 class26_0;

	protected WebResponse webResponse_0;

	protected string string_0 = null;

	protected byte[] byte_0 = null;

	public DateTime dateTime_0;

	static Class27()
	{
		hashtable_0 = new Hashtable();
		hashtable_0.Add(HttpStatusCode.BadGateway, 502);
		hashtable_0.Add(HttpStatusCode.BadRequest, 400);
		hashtable_0.Add(HttpStatusCode.Conflict, 409);
		hashtable_0.Add(HttpStatusCode.Continue, 100);
		hashtable_0.Add(HttpStatusCode.Created, 201);
		hashtable_0.Add(HttpStatusCode.ExpectationFailed, 417);
		hashtable_0.Add(HttpStatusCode.Forbidden, 403);
		hashtable_0.Add(HttpStatusCode.Found, 302);
		hashtable_0.Add(HttpStatusCode.GatewayTimeout, 504);
		hashtable_0.Add(HttpStatusCode.Gone, 410);
		hashtable_0.Add(HttpStatusCode.HttpVersionNotSupported, 505);
		hashtable_0.Add(HttpStatusCode.InternalServerError, 500);
		hashtable_0.Add(HttpStatusCode.LengthRequired, 411);
		hashtable_0.Add(HttpStatusCode.MethodNotAllowed, 405);
		hashtable_0.Add(HttpStatusCode.MovedPermanently, 301);
		hashtable_0.Add(HttpStatusCode.MultipleChoices, 300);
		hashtable_0.Add(HttpStatusCode.NoContent, 204);
		hashtable_0.Add(HttpStatusCode.NonAuthoritativeInformation, 203);
		hashtable_0.Add(HttpStatusCode.NotAcceptable, 406);
		hashtable_0.Add(HttpStatusCode.NotFound, 404);
		hashtable_0.Add(HttpStatusCode.NotImplemented, 501);
		hashtable_0.Add(HttpStatusCode.NotModified, 304);
		hashtable_0.Add(HttpStatusCode.OK, 200);
		hashtable_0.Add(HttpStatusCode.PartialContent, 206);
		hashtable_0.Add(HttpStatusCode.PaymentRequired, 402);
		hashtable_0.Add(HttpStatusCode.PreconditionFailed, 412);
		hashtable_0.Add(HttpStatusCode.ProxyAuthenticationRequired, 407);
		hashtable_0.Add(HttpStatusCode.SeeOther, 303);
		hashtable_0.Add(HttpStatusCode.RequestedRangeNotSatisfiable, 416);
		hashtable_0.Add(HttpStatusCode.RequestEntityTooLarge, 413);
		hashtable_0.Add(HttpStatusCode.RequestTimeout, 408);
		hashtable_0.Add(HttpStatusCode.RequestUriTooLong, 414);
		hashtable_0.Add(HttpStatusCode.ResetContent, 205);
		hashtable_0.Add(HttpStatusCode.ServiceUnavailable, 503);
		hashtable_0.Add(HttpStatusCode.SwitchingProtocols, 101);
		hashtable_0.Add(HttpStatusCode.TemporaryRedirect, 307);
		hashtable_0.Add(HttpStatusCode.Unauthorized, 401);
		hashtable_0.Add(HttpStatusCode.UnsupportedMediaType, 415);
		hashtable_0.Add(HttpStatusCode.Unused, 306);
		hashtable_0.Add(HttpStatusCode.UseProxy, 305);
	}

	public Class27(WebResponse webResponse_1, Class26 class26_1)
	{
		class26_0 = class26_1;
		webResponse_0 = webResponse_1;
		foreach (string key in webResponse_0.Headers.Keys)
		{
			class38_0.vmethod_1(key, webResponse_0.Headers[key]);
		}
	}

	[SpecialName]
	public Class26 method_0()
	{
		return class26_0;
	}

	public bool method_1(Stream stream_0)
	{
		Stream responseStream = webResponse_0.GetResponseStream();
		if (!GClass1.smethod_10(responseStream, stream_0))
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
		return string_0 = Class24.encoding_0.GetString(byte_0);
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
	public Class38 method_6()
	{
		return class38_0;
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
		return (int)hashtable_0[method_8().StatusCode];
	}

	[SpecialName]
	public Uri method_11()
	{
		return webResponse_0.ResponseUri;
	}
}
