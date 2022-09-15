using System;
using System.Runtime.Serialization;

[Serializable]
internal class Exception4 : Exception3
{
	public Exception4()
		: base("<Unknow exception>")
	{
	}

	public Exception4(string string_0)
		: base(string_0)
	{
	}

	public Exception4(string string_0, Exception exception_0)
		: base(string_0, exception_0)
	{
	}

	protected Exception4(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		: base(serializationInfo_0, streamingContext_0)
	{
	}

	void Exception3.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		GetObjectData(info, context);
	}
}
