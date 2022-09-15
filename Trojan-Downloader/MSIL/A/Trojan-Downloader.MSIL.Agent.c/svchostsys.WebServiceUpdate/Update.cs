using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace svchostsys.WebServiceUpdate;

[DebuggerStepThrough]
[WebServiceBinding(Name = "UpdateSoap", Namespace = "http://tempuri.org/")]
[DesignerCategory("code")]
public class Update : SoapHttpClientProtocol
{
	public Update()
	{
		((WebClientProtocol)this).set_Url("http://209.213.106.160/WebService/Update.asmx");
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlArrayItem(IsNullable = false)]
	public UpdateData[] CheckForUpdates(string strProjectName, int intVersionNumber)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("CheckForUpdates", new object[2] { strProjectName, intVersionNumber });
		return (UpdateData[])array[0];
	}

	public IAsyncResult BeginCheckForUpdates(string strProjectName, int intVersionNumber, AsyncCallback callback, object asyncState)
	{
		return ((SoapHttpClientProtocol)this).BeginInvoke("CheckForUpdates", new object[2] { strProjectName, intVersionNumber }, callback, asyncState);
	}

	public UpdateData[] EndCheckForUpdates(IAsyncResult asyncResult)
	{
		object[] array = ((SoapHttpClientProtocol)this).EndInvoke(asyncResult);
		return (UpdateData[])array[0];
	}
}
