using System;
using System.IO;
using ns0;
using ns3;
using ns4;

namespace ns2;

public class GStream0 : Stream
{
	protected GClass3 gclass3_0;

	protected byte[] byte_0;

	protected int int_0;

	private byte[] byte_1;

	protected Stream stream_0;

	protected long long_0;

	private int int_1;

	protected byte[] byte_2;

	private uint[] uint_0;

	public override bool CanRead => stream_0.CanRead;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override long Length => int_0;

	public override long Position
	{
		get
		{
			return stream_0.Position;
		}
		set
		{
			throw new NotSupportedException("InflaterInputStream Position not supported");
		}
	}

	public virtual int Available => (!gclass3_0.Boolean_2) ? 1 : 0;

	protected int Int32_0
	{
		get
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
		set
		{
			throw new Exception("This method was pruned during dead code elimination.");
		}
	}

	public override void Flush()
	{
		stream_0.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("Seek not supported");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("InflaterInputStream SetLength not supported");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("InflaterInputStream Write not supported");
	}

	public override void WriteByte(byte value)
	{
		throw new NotSupportedException("InflaterInputStream WriteByte not supported");
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException("InflaterInputStream BeginWrite not supported");
	}

	public GStream0(Stream stream_1)
		: this(stream_1, new GClass3(), 4096)
	{
	}

	public GStream0(Stream stream_1, GClass3 gclass3_1)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	public GStream0(Stream stream_1, GClass3 gclass3_1, int int_2)
	{
		byte_1 = new byte[1];
		int_1 = 0;
		byte_2 = null;
		uint_0 = null;
		base._002Ector();
		if (stream_1 == null)
		{
			throw new ArgumentNullException("InflaterInputStream baseInputStream is null");
		}
		if (gclass3_1 == null)
		{
			throw new ArgumentNullException("InflaterInputStream Inflater is null");
		}
		if (int_2 > 0)
		{
			stream_0 = stream_1;
			gclass3_0 = gclass3_1;
			byte_0 = new byte[int_2];
			try
			{
				int_0 = (int)stream_1.Length;
				return;
			}
			catch (Exception)
			{
				int_0 = 0;
				return;
			}
		}
		throw new ArgumentOutOfRangeException("bufferSize");
	}

	public override void Close()
	{
		stream_0.Close();
	}

	protected void method_0()
	{
		if (int_1 <= 0)
		{
			int_0 = stream_0.Read(byte_0, 0, byte_0.Length);
		}
		else
		{
			int_0 = stream_0.Read(byte_0, 0, int_1);
		}
	}

	protected void method_1()
	{
		method_0();
		if (uint_0 != null)
		{
			method_4(byte_0, 0, int_0);
		}
		if (int_0 <= 0)
		{
			throw new GException1("Deflated stream ends early.");
		}
		gclass3_0.method_9(byte_0, 0, int_0);
	}

	public override int ReadByte()
	{
		int num = Read(byte_1, 0, 1);
		if (num <= 0)
		{
			return -1;
		}
		return byte_1[0] & 0xFF;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num;
		while (true)
		{
			try
			{
				num = gclass3_0.method_11(buffer, offset, count);
			}
			catch (Exception ex)
			{
				throw new GException1(ex.ToString());
			}
			if (num > 0)
			{
				break;
			}
			if (!gclass3_0.Boolean_1)
			{
				if (!gclass3_0.Boolean_2)
				{
					if (gclass3_0.Boolean_0)
					{
						method_1();
						continue;
					}
					throw new InvalidOperationException("Don't know what to do");
				}
				return 0;
			}
			throw new GException1("Need a dictionary");
		}
		return num;
	}

	public long method_2(long long_1)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	protected byte method_3()
	{
		uint num = (uint_0[2] & 0xFFFFu) | 2u;
		return (byte)(num * (num ^ 1) >> 8);
	}

	protected void method_4(byte[] byte_3, int int_2, int int_3)
	{
		for (int i = int_2; i < int_2 + int_3; i++)
		{
			byte[] array;
			byte[] array2 = (array = byte_3);
			int num = i;
			nint num2 = num;
			array2[num] = (byte)(array[num2] ^ method_3());
			method_6(byte_3[i]);
		}
	}

	protected void method_5(string string_0)
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}

	protected void method_6(byte byte_3)
	{
		uint_0[0] = GClass16.smethod_0(uint_0[0], byte_3);
		uint_0[1] = uint_0[1] + (byte)uint_0[0];
		uint_0[1] = uint_0[1] * 134775813 + 1;
		uint_0[2] = GClass16.smethod_0(uint_0[2], (byte)(uint_0[1] >> 24));
	}

	protected void method_7()
	{
		throw new Exception("This method was pruned during dead code elimination.");
	}
}
