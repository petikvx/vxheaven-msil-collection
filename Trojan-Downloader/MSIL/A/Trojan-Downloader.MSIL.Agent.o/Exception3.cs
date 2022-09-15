using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

[Serializable]
internal class Exception3 : ApplicationException
{
	public Exception3()
	{
		method_0();
	}

	public Exception3(string string_0)
		: base(string_0)
	{
		method_0();
	}

	public Exception3(string string_0, Exception exception_0)
		: base(string_0, exception_0)
	{
		method_0();
	}

	protected Exception3(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		: base(serializationInfo_0, streamingContext_0)
	{
	}

	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\n               version=\"1\">\r\n   <IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\n                version=\"1\"\r\n                Flags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
	}

	protected void method_0()
	{
	}

	[SpecialName]
	public virtual string vmethod_0()
	{
		return smethod_0(this);
	}

	public static string smethod_0(Exception exception_0)
	{
		return smethod_1(exception_0, null);
	}

	public static string smethod_1(Exception exception_0, NameValueCollection nameValueCollection_0)
	{
		return exception_0.ToString();
	}
}
