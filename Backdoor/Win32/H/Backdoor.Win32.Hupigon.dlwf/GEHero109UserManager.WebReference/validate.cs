using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace GEHero109UserManager.WebReference;

[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "validateSoap", Namespace = "http://GE.com/GEWebService/")]
public class validate : SoapHttpClientProtocol
{
	public validate()
	{
		((WebClientProtocol)this).set_Url("http://gewg.kmip.net/WE/Validate.asmx\0\0\0\0\0\0");
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public string Validate(string Name, string PW)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("Validate", new object[2] { Name, PW });
		return (string)array[0];
	}

	public IAsyncResult BeginValidate(string Name, string PW, AsyncCallback callback, object asyncState)
	{
		return ((SoapHttpClientProtocol)this).BeginInvoke("Validate", new object[2] { Name, PW }, callback, asyncState);
	}

	public string EndValidate(IAsyncResult asyncResult)
	{
		object[] array = ((SoapHttpClientProtocol)this).EndInvoke(asyncResult);
		return (string)array[0];
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public string AddValidateInfo(string Name, string Code, string CodePW, string Info)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("AddValidateInfo", new object[4] { Name, Code, CodePW, Info });
		return (string)array[0];
	}

	public IAsyncResult BeginAddValidateInfo(string Name, string Code, string CodePW, string Info, AsyncCallback callback, object asyncState)
	{
		return ((SoapHttpClientProtocol)this).BeginInvoke("AddValidateInfo", new object[4] { Name, Code, CodePW, Info }, callback, asyncState);
	}

	public string EndAddValidateInfo(IAsyncResult asyncResult)
	{
		object[] array = ((SoapHttpClientProtocol)this).EndInvoke(asyncResult);
		return (string)array[0];
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public string CodeInfo(string Code)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("CodeInfo", new object[1] { Code });
		return (string)array[0];
	}

	public IAsyncResult BeginCodeInfo(string Code, AsyncCallback callback, object asyncState)
	{
		return ((SoapHttpClientProtocol)this).BeginInvoke("CodeInfo", new object[1] { Code }, callback, asyncState);
	}

	public string EndCodeInfo(IAsyncResult asyncResult)
	{
		object[] array = ((SoapHttpClientProtocol)this).EndInvoke(asyncResult);
		return (string)array[0];
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public GEHero109DataSet FillCodeTable()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FillCodeTable", new object[0]);
		return (GEHero109DataSet)array[0];
	}

	public IAsyncResult BeginFillCodeTable(AsyncCallback callback, object asyncState)
	{
		return ((SoapHttpClientProtocol)this).BeginInvoke("FillCodeTable", new object[0], callback, asyncState);
	}

	public GEHero109DataSet EndFillCodeTable(IAsyncResult asyncResult)
	{
		object[] array = ((SoapHttpClientProtocol)this).EndInvoke(asyncResult);
		return (GEHero109DataSet)array[0];
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public GEHero109DataSet FillUserTable()
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("FillUserTable", new object[0]);
		return (GEHero109DataSet)array[0];
	}

	public IAsyncResult BeginFillUserTable(AsyncCallback callback, object asyncState)
	{
		return ((SoapHttpClientProtocol)this).BeginInvoke("FillUserTable", new object[0], callback, asyncState);
	}

	public GEHero109DataSet EndFillUserTable(IAsyncResult asyncResult)
	{
		object[] array = ((SoapHttpClientProtocol)this).EndInvoke(asyncResult);
		return (GEHero109DataSet)array[0];
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public string ChangeUserID(string nameOld, string nameNew, string PW)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("ChangeUserID", new object[3] { nameOld, nameNew, PW });
		return (string)array[0];
	}

	public IAsyncResult BeginChangeUserID(string nameOld, string nameNew, string PW, AsyncCallback callback, object asyncState)
	{
		return ((SoapHttpClientProtocol)this).BeginInvoke("ChangeUserID", new object[3] { nameOld, nameNew, PW }, callback, asyncState);
	}

	public string EndChangeUserID(IAsyncResult asyncResult)
	{
		object[] array = ((SoapHttpClientProtocol)this).EndInvoke(asyncResult);
		return (string)array[0];
	}
}
