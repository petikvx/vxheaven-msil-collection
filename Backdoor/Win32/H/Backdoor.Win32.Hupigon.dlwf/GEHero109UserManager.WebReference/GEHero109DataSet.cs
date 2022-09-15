using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;

namespace GEHero109UserManager.WebReference;

[Serializable]
[DesignerCategory("code")]
[ToolboxItem(true)]
[DebuggerStepThrough]
public class GEHero109DataSet : DataSet
{
	public delegate void GDelegate0(object sender, GEventArgs0 e);

	public delegate void GDelegate1(object sender, GEventArgs1 e);

	public delegate void GDelegate2(object sender, GEventArgs2 e);

	public delegate void GDelegate3(object sender, GEventArgs3 e);

	public delegate void GDelegate4(object sender, GEventArgs4 e);

	[DebuggerStepThrough]
	public class GClass0 : DataTable, IEnumerable
	{
		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private GDelegate0 gdelegate0_0;

		private GDelegate0 gdelegate0_1;

		private GDelegate0 gdelegate0_2;

		private GDelegate0 gdelegate0_3;

		[Browsable(false)]
		public int Count => base.Rows.Count;

		internal DataColumn DataColumn_0 => dataColumn_0;

		internal DataColumn DataColumn_1 => dataColumn_1;

		public GClass1 this[int index] => (GClass1)base.Rows[index];

		public event GDelegate0 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate0_0 = (GDelegate0)Delegate.Combine(gdelegate0_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate0_0 = (GDelegate0)Delegate.Remove(gdelegate0_0, value);
			}
		}

		public event GDelegate0 Event_1
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate0_1 = (GDelegate0)Delegate.Combine(gdelegate0_1, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate0_1 = (GDelegate0)Delegate.Remove(gdelegate0_1, value);
			}
		}

		public event GDelegate0 Event_2
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate0_2 = (GDelegate0)Delegate.Combine(gdelegate0_2, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate0_2 = (GDelegate0)Delegate.Remove(gdelegate0_2, value);
			}
		}

		public event GDelegate0 Event_3
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate0_3 = (GDelegate0)Delegate.Combine(gdelegate0_3, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate0_3 = (GDelegate0)Delegate.Remove(gdelegate0_3, value);
			}
		}

		internal GClass0()
			: base("角色类别资料")
		{
			InitClass();
		}

		internal GClass0(DataTable table)
			: base(table.TableName)
		{
			if (table.CaseSensitive != table.DataSet!.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet!.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet!.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
			base.DisplayExpression = table.DisplayExpression;
		}

		public void method_0(GClass1 row)
		{
			base.Rows.Add(row);
		}

		public GClass1 method_1(string string_0)
		{
			GClass1 gClass = (GClass1)NewRow();
			gClass.ItemArray = new object[2] { null, string_0 };
			base.Rows.Add(gClass);
			return gClass;
		}

		public GClass1 method_2(int int_0)
		{
			return (GClass1)base.Rows.Find(new object[1] { int_0 });
		}

		public IEnumerator GetEnumerator()
		{
			return base.Rows.GetEnumerator();
		}

		public override DataTable Clone()
		{
			GClass0 gClass = (GClass0)base.Clone();
			gClass.InitVars();
			return gClass;
		}

		protected override DataTable CreateInstance()
		{
			return new GClass0();
		}

		internal void InitVars()
		{
			dataColumn_0 = base.Columns["角色类别ID"];
			dataColumn_1 = base.Columns["角色类别"];
		}

		private void InitClass()
		{
			dataColumn_0 = new DataColumn("角色类别ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_0);
			dataColumn_1 = new DataColumn("角色类别", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_1);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { dataColumn_0 }, isPrimaryKey: true));
			dataColumn_0.AutoIncrement = true;
			dataColumn_0.AllowDBNull = false;
			dataColumn_0.Unique = true;
		}

		public GClass1 method_3()
		{
			return (GClass1)NewRow();
		}

		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new GClass1(builder);
		}

		protected override Type GetRowType()
		{
			return typeof(GClass1);
		}

		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (gdelegate0_0 != null)
			{
				gdelegate0_0(this, new GEventArgs0((GClass1)e.Row, e.Action));
			}
		}

		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (gdelegate0_1 != null)
			{
				gdelegate0_1(this, new GEventArgs0((GClass1)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (gdelegate0_2 != null)
			{
				gdelegate0_2(this, new GEventArgs0((GClass1)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (gdelegate0_3 != null)
			{
				gdelegate0_3(this, new GEventArgs0((GClass1)e.Row, e.Action));
			}
		}

		public void method_4(GClass1 row)
		{
			base.Rows.Remove(row);
		}
	}

	[DebuggerStepThrough]
	public class GClass1 : DataRow
	{
		private GClass0 gclass0_0;

		public int Int32_0
		{
			get
			{
				return (int)base[gclass0_0.DataColumn_0];
			}
			set
			{
				base[gclass0_0.DataColumn_0] = value;
			}
		}

		public string String_0
		{
			get
			{
				try
				{
					return (string)base[gclass0_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass0_0.DataColumn_1] = value;
			}
		}

		internal GClass1(DataRowBuilder rb)
			: base(rb)
		{
			gclass0_0 = (GClass0)base.Table;
		}

		public bool method_0()
		{
			return IsNull(gclass0_0.DataColumn_1);
		}

		public void method_1()
		{
			base[gclass0_0.DataColumn_1] = Convert.DBNull;
		}
	}

	[DebuggerStepThrough]
	public class GEventArgs0 : EventArgs
	{
		private GClass1 eventRow;

		private DataRowAction eventAction;

		public GClass1 Row => eventRow;

		public DataRowAction Action => eventAction;

		public GEventArgs0(GClass1 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[DebuggerStepThrough]
	public class GClass2 : DataTable, IEnumerable
	{
		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn columnLV;

		private DataColumn dataColumn_5;

		private DataColumn dataColumn_6;

		private DataColumn dataColumn_7;

		private DataColumn dataColumn_8;

		private DataColumn dataColumn_9;

		private DataColumn dataColumn_10;

		private DataColumn dataColumn_11;

		private DataColumn dataColumn_12;

		private DataColumn dataColumn_13;

		private GDelegate1 gdelegate1_0;

		private GDelegate1 gdelegate1_1;

		private GDelegate1 gdelegate1_2;

		private GDelegate1 gdelegate1_3;

		[Browsable(false)]
		public int Count => base.Rows.Count;

		internal DataColumn DataColumn_0 => dataColumn_0;

		internal DataColumn DataColumn_1 => dataColumn_1;

		internal DataColumn DataColumn_2 => dataColumn_2;

		internal DataColumn DataColumn_3 => dataColumn_3;

		internal DataColumn DataColumn_4 => dataColumn_4;

		internal DataColumn LVColumn => columnLV;

		internal DataColumn DataColumn_5 => dataColumn_5;

		internal DataColumn DataColumn_6 => dataColumn_6;

		internal DataColumn DataColumn_7 => dataColumn_7;

		internal DataColumn DataColumn_8 => dataColumn_8;

		internal DataColumn DataColumn_9 => dataColumn_9;

		internal DataColumn DataColumn_10 => dataColumn_10;

		internal DataColumn DataColumn_11 => dataColumn_11;

		internal DataColumn DataColumn_12 => dataColumn_12;

		internal DataColumn DataColumn_13 => dataColumn_13;

		public GClass3 this[int index] => (GClass3)base.Rows[index];

		public event GDelegate1 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate1_0 = (GDelegate1)Delegate.Combine(gdelegate1_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate1_0 = (GDelegate1)Delegate.Remove(gdelegate1_0, value);
			}
		}

		public event GDelegate1 Event_1
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate1_1 = (GDelegate1)Delegate.Combine(gdelegate1_1, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate1_1 = (GDelegate1)Delegate.Remove(gdelegate1_1, value);
			}
		}

		public event GDelegate1 Event_2
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate1_2 = (GDelegate1)Delegate.Combine(gdelegate1_2, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate1_2 = (GDelegate1)Delegate.Remove(gdelegate1_2, value);
			}
		}

		public event GDelegate1 Event_3
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate1_3 = (GDelegate1)Delegate.Combine(gdelegate1_3, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate1_3 = (GDelegate1)Delegate.Remove(gdelegate1_3, value);
			}
		}

		internal GClass2()
			: base("角色资料")
		{
			InitClass();
		}

		internal GClass2(DataTable table)
			: base(table.TableName)
		{
			if (table.CaseSensitive != table.DataSet!.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet!.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet!.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
			base.DisplayExpression = table.DisplayExpression;
		}

		public void method_0(GClass3 row)
		{
			base.Rows.Add(row);
		}

		public GClass3 method_1(string string_0, int int_0, string string_1, string string_2, int LV, int int_1, string string_3, int int_2, string string_4, int int_3, string string_5, int int_4, int int_5, int int_6)
		{
			GClass3 gClass = (GClass3)NewRow();
			gClass.ItemArray = new object[15]
			{
				null, string_0, int_0, string_1, string_2, LV, int_1, string_3, int_2, string_4,
				int_3, string_5, int_4, int_5, int_6
			};
			base.Rows.Add(gClass);
			return gClass;
		}

		public GClass3 method_2(int int_0)
		{
			return (GClass3)base.Rows.Find(new object[1] { int_0 });
		}

		public IEnumerator GetEnumerator()
		{
			return base.Rows.GetEnumerator();
		}

		public override DataTable Clone()
		{
			GClass2 gClass = (GClass2)base.Clone();
			gClass.InitVars();
			return gClass;
		}

		protected override DataTable CreateInstance()
		{
			return new GClass2();
		}

		internal void InitVars()
		{
			dataColumn_0 = base.Columns["角色ID"];
			dataColumn_1 = base.Columns["帐户名"];
			dataColumn_2 = base.Columns["位置"];
			dataColumn_3 = base.Columns["角色名"];
			dataColumn_4 = base.Columns["角色类别"];
			columnLV = base.Columns["LV"];
			dataColumn_5 = base.Columns["左手LV"];
			dataColumn_6 = base.Columns["左手装备"];
			dataColumn_7 = base.Columns["右手LV"];
			dataColumn_8 = base.Columns["右手装备"];
			dataColumn_9 = base.Columns["身体LV"];
			dataColumn_10 = base.Columns["身体装备"];
			dataColumn_11 = base.Columns["护手LV"];
			dataColumn_12 = base.Columns["护腿LV"];
			dataColumn_13 = base.Columns["更换装备LV"];
		}

		private void InitClass()
		{
			dataColumn_0 = new DataColumn("角色ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_0);
			dataColumn_1 = new DataColumn("帐户名", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_1);
			dataColumn_2 = new DataColumn("位置", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_2);
			dataColumn_3 = new DataColumn("角色名", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_3);
			dataColumn_4 = new DataColumn("角色类别", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_4);
			columnLV = new DataColumn("LV", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnLV);
			dataColumn_5 = new DataColumn("左手LV", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_5);
			dataColumn_6 = new DataColumn("左手装备", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_6);
			dataColumn_7 = new DataColumn("右手LV", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_7);
			dataColumn_8 = new DataColumn("右手装备", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_8);
			dataColumn_9 = new DataColumn("身体LV", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_9);
			dataColumn_10 = new DataColumn("身体装备", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_10);
			dataColumn_11 = new DataColumn("护手LV", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_11);
			dataColumn_12 = new DataColumn("护腿LV", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_12);
			dataColumn_13 = new DataColumn("更换装备LV", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_13);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { dataColumn_0 }, isPrimaryKey: true));
			dataColumn_0.AutoIncrement = true;
			dataColumn_0.AllowDBNull = false;
			dataColumn_0.Unique = true;
		}

		public GClass3 method_3()
		{
			return (GClass3)NewRow();
		}

		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new GClass3(builder);
		}

		protected override Type GetRowType()
		{
			return typeof(GClass3);
		}

		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (gdelegate1_0 != null)
			{
				gdelegate1_0(this, new GEventArgs1((GClass3)e.Row, e.Action));
			}
		}

		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (gdelegate1_1 != null)
			{
				gdelegate1_1(this, new GEventArgs1((GClass3)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (gdelegate1_2 != null)
			{
				gdelegate1_2(this, new GEventArgs1((GClass3)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (gdelegate1_3 != null)
			{
				gdelegate1_3(this, new GEventArgs1((GClass3)e.Row, e.Action));
			}
		}

		public void method_4(GClass3 row)
		{
			base.Rows.Remove(row);
		}
	}

	[DebuggerStepThrough]
	public class GClass3 : DataRow
	{
		private GClass2 gclass2_0;

		public int Int32_0
		{
			get
			{
				return (int)base[gclass2_0.DataColumn_0];
			}
			set
			{
				base[gclass2_0.DataColumn_0] = value;
			}
		}

		public string String_0
		{
			get
			{
				try
				{
					return (string)base[gclass2_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_1] = value;
			}
		}

		public int Int32_1
		{
			get
			{
				try
				{
					return (int)base[gclass2_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_2] = value;
			}
		}

		public string String_1
		{
			get
			{
				try
				{
					return (string)base[gclass2_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_3] = value;
			}
		}

		public string String_2
		{
			get
			{
				try
				{
					return (string)base[gclass2_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_4] = value;
			}
		}

		public int LV
		{
			get
			{
				try
				{
					return (int)base[gclass2_0.LVColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.LVColumn] = value;
			}
		}

		public int Int32_2
		{
			get
			{
				try
				{
					return (int)base[gclass2_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_5] = value;
			}
		}

		public string String_3
		{
			get
			{
				try
				{
					return (string)base[gclass2_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_6] = value;
			}
		}

		public int Int32_3
		{
			get
			{
				try
				{
					return (int)base[gclass2_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_7] = value;
			}
		}

		public string String_4
		{
			get
			{
				try
				{
					return (string)base[gclass2_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_8] = value;
			}
		}

		public int Int32_4
		{
			get
			{
				try
				{
					return (int)base[gclass2_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_9] = value;
			}
		}

		public string String_5
		{
			get
			{
				try
				{
					return (string)base[gclass2_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_10] = value;
			}
		}

		public int Int32_5
		{
			get
			{
				try
				{
					return (int)base[gclass2_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_11] = value;
			}
		}

		public int Int32_6
		{
			get
			{
				try
				{
					return (int)base[gclass2_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_12] = value;
			}
		}

		public int Int32_7
		{
			get
			{
				try
				{
					return (int)base[gclass2_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass2_0.DataColumn_13] = value;
			}
		}

		internal GClass3(DataRowBuilder rb)
			: base(rb)
		{
			gclass2_0 = (GClass2)base.Table;
		}

		public bool method_0()
		{
			return IsNull(gclass2_0.DataColumn_1);
		}

		public void method_1()
		{
			base[gclass2_0.DataColumn_1] = Convert.DBNull;
		}

		public bool method_2()
		{
			return IsNull(gclass2_0.DataColumn_2);
		}

		public void method_3()
		{
			base[gclass2_0.DataColumn_2] = Convert.DBNull;
		}

		public bool method_4()
		{
			return IsNull(gclass2_0.DataColumn_3);
		}

		public void method_5()
		{
			base[gclass2_0.DataColumn_3] = Convert.DBNull;
		}

		public bool method_6()
		{
			return IsNull(gclass2_0.DataColumn_4);
		}

		public void method_7()
		{
			base[gclass2_0.DataColumn_4] = Convert.DBNull;
		}

		public bool IsLVNull()
		{
			return IsNull(gclass2_0.LVColumn);
		}

		public void SetLVNull()
		{
			base[gclass2_0.LVColumn] = Convert.DBNull;
		}

		public bool method_8()
		{
			return IsNull(gclass2_0.DataColumn_5);
		}

		public void method_9()
		{
			base[gclass2_0.DataColumn_5] = Convert.DBNull;
		}

		public bool method_10()
		{
			return IsNull(gclass2_0.DataColumn_6);
		}

		public void method_11()
		{
			base[gclass2_0.DataColumn_6] = Convert.DBNull;
		}

		public bool method_12()
		{
			return IsNull(gclass2_0.DataColumn_7);
		}

		public void method_13()
		{
			base[gclass2_0.DataColumn_7] = Convert.DBNull;
		}

		public bool method_14()
		{
			return IsNull(gclass2_0.DataColumn_8);
		}

		public void method_15()
		{
			base[gclass2_0.DataColumn_8] = Convert.DBNull;
		}

		public bool method_16()
		{
			return IsNull(gclass2_0.DataColumn_9);
		}

		public void method_17()
		{
			base[gclass2_0.DataColumn_9] = Convert.DBNull;
		}

		public bool method_18()
		{
			return IsNull(gclass2_0.DataColumn_10);
		}

		public void method_19()
		{
			base[gclass2_0.DataColumn_10] = Convert.DBNull;
		}

		public bool method_20()
		{
			return IsNull(gclass2_0.DataColumn_11);
		}

		public void method_21()
		{
			base[gclass2_0.DataColumn_11] = Convert.DBNull;
		}

		public bool method_22()
		{
			return IsNull(gclass2_0.DataColumn_12);
		}

		public void method_23()
		{
			base[gclass2_0.DataColumn_12] = Convert.DBNull;
		}

		public bool method_24()
		{
			return IsNull(gclass2_0.DataColumn_13);
		}

		public void method_25()
		{
			base[gclass2_0.DataColumn_13] = Convert.DBNull;
		}
	}

	[DebuggerStepThrough]
	public class GEventArgs1 : EventArgs
	{
		private GClass3 eventRow;

		private DataRowAction eventAction;

		public GClass3 Row => eventRow;

		public DataRowAction Action => eventAction;

		public GEventArgs1(GClass3 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[DebuggerStepThrough]
	public class GClass4 : DataTable, IEnumerable
	{
		private DataColumn columnCode;

		private DataColumn columnID;

		private DataColumn columnPW;

		private DataColumn columnUserName;

		private GDelegate2 gdelegate2_0;

		private GDelegate2 gdelegate2_1;

		private GDelegate2 gdelegate2_2;

		private GDelegate2 gdelegate2_3;

		[Browsable(false)]
		public int Count => base.Rows.Count;

		internal DataColumn CodeColumn => columnCode;

		internal DataColumn IDColumn => columnID;

		internal DataColumn PWColumn => columnPW;

		internal DataColumn UserNameColumn => columnUserName;

		public GClass5 this[int index] => (GClass5)base.Rows[index];

		public event GDelegate2 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate2_0 = (GDelegate2)Delegate.Combine(gdelegate2_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate2_0 = (GDelegate2)Delegate.Remove(gdelegate2_0, value);
			}
		}

		public event GDelegate2 Event_1
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate2_1 = (GDelegate2)Delegate.Combine(gdelegate2_1, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate2_1 = (GDelegate2)Delegate.Remove(gdelegate2_1, value);
			}
		}

		public event GDelegate2 Event_2
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate2_2 = (GDelegate2)Delegate.Combine(gdelegate2_2, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate2_2 = (GDelegate2)Delegate.Remove(gdelegate2_2, value);
			}
		}

		public event GDelegate2 Event_3
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate2_3 = (GDelegate2)Delegate.Combine(gdelegate2_3, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate2_3 = (GDelegate2)Delegate.Remove(gdelegate2_3, value);
			}
		}

		internal GClass4()
			: base("卡表资料")
		{
			InitClass();
		}

		internal GClass4(DataTable table)
			: base(table.TableName)
		{
			if (table.CaseSensitive != table.DataSet!.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet!.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet!.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
			base.DisplayExpression = table.DisplayExpression;
		}

		public void method_0(GClass5 row)
		{
			base.Rows.Add(row);
		}

		public GClass5 method_1(string Code, string PW, string UserName)
		{
			GClass5 gClass = (GClass5)NewRow();
			gClass.ItemArray = new object[4] { Code, null, PW, UserName };
			base.Rows.Add(gClass);
			return gClass;
		}

		public GClass5 FindByID(int ID)
		{
			return (GClass5)base.Rows.Find(new object[1] { ID });
		}

		public IEnumerator GetEnumerator()
		{
			return base.Rows.GetEnumerator();
		}

		public override DataTable Clone()
		{
			GClass4 gClass = (GClass4)base.Clone();
			gClass.InitVars();
			return gClass;
		}

		protected override DataTable CreateInstance()
		{
			return new GClass4();
		}

		internal void InitVars()
		{
			columnCode = base.Columns["Code"];
			columnID = base.Columns["ID"];
			columnPW = base.Columns["PW"];
			columnUserName = base.Columns["UserName"];
		}

		private void InitClass()
		{
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCode);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnPW = new DataColumn("PW", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPW);
			columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUserName);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnID }, isPrimaryKey: true));
			columnID.AutoIncrement = true;
			columnID.AllowDBNull = false;
			columnID.Unique = true;
		}

		public GClass5 method_2()
		{
			return (GClass5)NewRow();
		}

		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new GClass5(builder);
		}

		protected override Type GetRowType()
		{
			return typeof(GClass5);
		}

		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (gdelegate2_0 != null)
			{
				gdelegate2_0(this, new GEventArgs2((GClass5)e.Row, e.Action));
			}
		}

		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (gdelegate2_1 != null)
			{
				gdelegate2_1(this, new GEventArgs2((GClass5)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (gdelegate2_2 != null)
			{
				gdelegate2_2(this, new GEventArgs2((GClass5)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (gdelegate2_3 != null)
			{
				gdelegate2_3(this, new GEventArgs2((GClass5)e.Row, e.Action));
			}
		}

		public void method_3(GClass5 row)
		{
			base.Rows.Remove(row);
		}
	}

	[DebuggerStepThrough]
	public class GClass5 : DataRow
	{
		private GClass4 gclass4_0;

		public string Code
		{
			get
			{
				try
				{
					return (string)base[gclass4_0.CodeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass4_0.CodeColumn] = value;
			}
		}

		public int ID
		{
			get
			{
				return (int)base[gclass4_0.IDColumn];
			}
			set
			{
				base[gclass4_0.IDColumn] = value;
			}
		}

		public string PW
		{
			get
			{
				try
				{
					return (string)base[gclass4_0.PWColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass4_0.PWColumn] = value;
			}
		}

		public string UserName
		{
			get
			{
				try
				{
					return (string)base[gclass4_0.UserNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass4_0.UserNameColumn] = value;
			}
		}

		internal GClass5(DataRowBuilder rb)
			: base(rb)
		{
			gclass4_0 = (GClass4)base.Table;
		}

		public bool IsCodeNull()
		{
			return IsNull(gclass4_0.CodeColumn);
		}

		public void SetCodeNull()
		{
			base[gclass4_0.CodeColumn] = Convert.DBNull;
		}

		public bool IsPWNull()
		{
			return IsNull(gclass4_0.PWColumn);
		}

		public void SetPWNull()
		{
			base[gclass4_0.PWColumn] = Convert.DBNull;
		}

		public bool IsUserNameNull()
		{
			return IsNull(gclass4_0.UserNameColumn);
		}

		public void SetUserNameNull()
		{
			base[gclass4_0.UserNameColumn] = Convert.DBNull;
		}
	}

	[DebuggerStepThrough]
	public class GEventArgs2 : EventArgs
	{
		private GClass5 eventRow;

		private DataRowAction eventAction;

		public GClass5 Row => eventRow;

		public DataRowAction Action => eventAction;

		public GEventArgs2(GClass5 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[DebuggerStepThrough]
	public class GClass6 : DataTable, IEnumerable
	{
		private DataColumn columnBak;

		private DataColumn columnCode;

		private DataColumn columnID;

		private DataColumn columnLastDate;

		private DataColumn columnName;

		private DataColumn columnPW;

		private DataColumn columnValid;

		private GDelegate3 gdelegate3_0;

		private GDelegate3 gdelegate3_1;

		private GDelegate3 gdelegate3_2;

		private GDelegate3 gdelegate3_3;

		[Browsable(false)]
		public int Count => base.Rows.Count;

		internal DataColumn BakColumn => columnBak;

		internal DataColumn CodeColumn => columnCode;

		internal DataColumn IDColumn => columnID;

		internal DataColumn LastDateColumn => columnLastDate;

		internal DataColumn NameColumn => columnName;

		internal DataColumn PWColumn => columnPW;

		internal DataColumn ValidColumn => columnValid;

		public GClass7 this[int index] => (GClass7)base.Rows[index];

		public event GDelegate3 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate3_0 = (GDelegate3)Delegate.Combine(gdelegate3_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate3_0 = (GDelegate3)Delegate.Remove(gdelegate3_0, value);
			}
		}

		public event GDelegate3 Event_1
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate3_1 = (GDelegate3)Delegate.Combine(gdelegate3_1, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate3_1 = (GDelegate3)Delegate.Remove(gdelegate3_1, value);
			}
		}

		public event GDelegate3 Event_2
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate3_2 = (GDelegate3)Delegate.Combine(gdelegate3_2, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate3_2 = (GDelegate3)Delegate.Remove(gdelegate3_2, value);
			}
		}

		public event GDelegate3 Event_3
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate3_3 = (GDelegate3)Delegate.Combine(gdelegate3_3, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate3_3 = (GDelegate3)Delegate.Remove(gdelegate3_3, value);
			}
		}

		internal GClass6()
			: base("授权帐号资料")
		{
			InitClass();
		}

		internal GClass6(DataTable table)
			: base(table.TableName)
		{
			if (table.CaseSensitive != table.DataSet!.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet!.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet!.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
			base.DisplayExpression = table.DisplayExpression;
		}

		public void method_0(GClass7 row)
		{
			base.Rows.Add(row);
		}

		public GClass7 method_1(string Bak, string Code, DateTime LastDate, string Name, string PW, int Valid)
		{
			GClass7 gClass = (GClass7)NewRow();
			gClass.ItemArray = new object[7] { Bak, Code, null, LastDate, Name, PW, Valid };
			base.Rows.Add(gClass);
			return gClass;
		}

		public GClass7 FindByID(int ID)
		{
			return (GClass7)base.Rows.Find(new object[1] { ID });
		}

		public IEnumerator GetEnumerator()
		{
			return base.Rows.GetEnumerator();
		}

		public override DataTable Clone()
		{
			GClass6 gClass = (GClass6)base.Clone();
			gClass.InitVars();
			return gClass;
		}

		protected override DataTable CreateInstance()
		{
			return new GClass6();
		}

		internal void InitVars()
		{
			columnBak = base.Columns["Bak"];
			columnCode = base.Columns["Code"];
			columnID = base.Columns["ID"];
			columnLastDate = base.Columns["LastDate"];
			columnName = base.Columns["Name"];
			columnPW = base.Columns["PW"];
			columnValid = base.Columns["Valid"];
		}

		private void InitClass()
		{
			columnBak = new DataColumn("Bak", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBak);
			columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCode);
			columnID = new DataColumn("ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnID);
			columnLastDate = new DataColumn("LastDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnLastDate);
			columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnName);
			columnPW = new DataColumn("PW", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPW);
			columnValid = new DataColumn("Valid", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnValid);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnID }, isPrimaryKey: true));
			columnID.AutoIncrement = true;
			columnID.AllowDBNull = false;
			columnID.Unique = true;
		}

		public GClass7 method_2()
		{
			return (GClass7)NewRow();
		}

		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new GClass7(builder);
		}

		protected override Type GetRowType()
		{
			return typeof(GClass7);
		}

		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (gdelegate3_0 != null)
			{
				gdelegate3_0(this, new GEventArgs3((GClass7)e.Row, e.Action));
			}
		}

		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (gdelegate3_1 != null)
			{
				gdelegate3_1(this, new GEventArgs3((GClass7)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (gdelegate3_2 != null)
			{
				gdelegate3_2(this, new GEventArgs3((GClass7)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (gdelegate3_3 != null)
			{
				gdelegate3_3(this, new GEventArgs3((GClass7)e.Row, e.Action));
			}
		}

		public void method_3(GClass7 row)
		{
			base.Rows.Remove(row);
		}
	}

	[DebuggerStepThrough]
	public class GClass7 : DataRow
	{
		private GClass6 gclass6_0;

		public string Bak
		{
			get
			{
				try
				{
					return (string)base[gclass6_0.BakColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass6_0.BakColumn] = value;
			}
		}

		public string Code
		{
			get
			{
				try
				{
					return (string)base[gclass6_0.CodeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass6_0.CodeColumn] = value;
			}
		}

		public int ID
		{
			get
			{
				return (int)base[gclass6_0.IDColumn];
			}
			set
			{
				base[gclass6_0.IDColumn] = value;
			}
		}

		public DateTime LastDate
		{
			get
			{
				try
				{
					return (DateTime)base[gclass6_0.LastDateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass6_0.LastDateColumn] = value;
			}
		}

		public string Name
		{
			get
			{
				try
				{
					return (string)base[gclass6_0.NameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass6_0.NameColumn] = value;
			}
		}

		public string PW
		{
			get
			{
				try
				{
					return (string)base[gclass6_0.PWColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass6_0.PWColumn] = value;
			}
		}

		public int Valid
		{
			get
			{
				try
				{
					return (int)base[gclass6_0.ValidColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass6_0.ValidColumn] = value;
			}
		}

		internal GClass7(DataRowBuilder rb)
			: base(rb)
		{
			gclass6_0 = (GClass6)base.Table;
		}

		public bool IsBakNull()
		{
			return IsNull(gclass6_0.BakColumn);
		}

		public void SetBakNull()
		{
			base[gclass6_0.BakColumn] = Convert.DBNull;
		}

		public bool IsCodeNull()
		{
			return IsNull(gclass6_0.CodeColumn);
		}

		public void SetCodeNull()
		{
			base[gclass6_0.CodeColumn] = Convert.DBNull;
		}

		public bool IsLastDateNull()
		{
			return IsNull(gclass6_0.LastDateColumn);
		}

		public void SetLastDateNull()
		{
			base[gclass6_0.LastDateColumn] = Convert.DBNull;
		}

		public bool IsNameNull()
		{
			return IsNull(gclass6_0.NameColumn);
		}

		public void SetNameNull()
		{
			base[gclass6_0.NameColumn] = Convert.DBNull;
		}

		public bool IsPWNull()
		{
			return IsNull(gclass6_0.PWColumn);
		}

		public void SetPWNull()
		{
			base[gclass6_0.PWColumn] = Convert.DBNull;
		}

		public bool IsValidNull()
		{
			return IsNull(gclass6_0.ValidColumn);
		}

		public void SetValidNull()
		{
			base[gclass6_0.ValidColumn] = Convert.DBNull;
		}
	}

	[DebuggerStepThrough]
	public class GEventArgs3 : EventArgs
	{
		private GClass7 eventRow;

		private DataRowAction eventAction;

		public GClass7 Row => eventRow;

		public DataRowAction Action => eventAction;

		public GEventArgs3(GClass7 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[DebuggerStepThrough]
	public class GClass8 : DataTable, IEnumerable
	{
		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn dataColumn_5;

		private DataColumn dataColumn_6;

		private DataColumn dataColumn_7;

		private DataColumn dataColumn_8;

		private DataColumn dataColumn_9;

		private DataColumn dataColumn_10;

		private DataColumn dataColumn_11;

		private GDelegate4 gdelegate4_0;

		private GDelegate4 gdelegate4_1;

		private GDelegate4 gdelegate4_2;

		private GDelegate4 gdelegate4_3;

		[Browsable(false)]
		public int Count => base.Rows.Count;

		internal DataColumn DataColumn_0 => dataColumn_0;

		internal DataColumn DataColumn_1 => dataColumn_1;

		internal DataColumn DataColumn_2 => dataColumn_2;

		internal DataColumn DataColumn_3 => dataColumn_3;

		internal DataColumn DataColumn_4 => dataColumn_4;

		internal DataColumn DataColumn_5 => dataColumn_5;

		internal DataColumn DataColumn_6 => dataColumn_6;

		internal DataColumn DataColumn_7 => dataColumn_7;

		internal DataColumn DataColumn_8 => dataColumn_8;

		internal DataColumn DataColumn_9 => dataColumn_9;

		internal DataColumn DataColumn_10 => dataColumn_10;

		internal DataColumn DataColumn_11 => dataColumn_11;

		public GClass9 this[int index] => (GClass9)base.Rows[index];

		public event GDelegate4 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate4_0 = (GDelegate4)Delegate.Combine(gdelegate4_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate4_0 = (GDelegate4)Delegate.Remove(gdelegate4_0, value);
			}
		}

		public event GDelegate4 Event_1
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate4_1 = (GDelegate4)Delegate.Combine(gdelegate4_1, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate4_1 = (GDelegate4)Delegate.Remove(gdelegate4_1, value);
			}
		}

		public event GDelegate4 Event_2
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate4_2 = (GDelegate4)Delegate.Combine(gdelegate4_2, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate4_2 = (GDelegate4)Delegate.Remove(gdelegate4_2, value);
			}
		}

		public event GDelegate4 Event_3
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				gdelegate4_3 = (GDelegate4)Delegate.Combine(gdelegate4_3, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				gdelegate4_3 = (GDelegate4)Delegate.Remove(gdelegate4_3, value);
			}
		}

		internal GClass8()
			: base("帐户资料")
		{
			InitClass();
		}

		internal GClass8(DataTable table)
			: base(table.TableName)
		{
			if (table.CaseSensitive != table.DataSet!.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet!.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet!.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
			base.DisplayExpression = table.DisplayExpression;
		}

		public void method_0(GClass9 row)
		{
			base.Rows.Add(row);
		}

		public GClass9 method_1(string string_0, string string_1, string string_2, int int_0, int int_1, int int_2, int int_3, string string_3, int int_4, DateTime dateTime_0, string string_4)
		{
			GClass9 gClass = (GClass9)NewRow();
			gClass.ItemArray = new object[12]
			{
				null, string_0, string_1, string_2, int_0, int_1, int_2, int_3, string_3, int_4,
				dateTime_0, string_4
			};
			base.Rows.Add(gClass);
			return gClass;
		}

		public GClass9 method_2(int int_0)
		{
			return (GClass9)base.Rows.Find(new object[1] { int_0 });
		}

		public IEnumerator GetEnumerator()
		{
			return base.Rows.GetEnumerator();
		}

		public override DataTable Clone()
		{
			GClass8 gClass = (GClass8)base.Clone();
			gClass.InitVars();
			return gClass;
		}

		protected override DataTable CreateInstance()
		{
			return new GClass8();
		}

		internal void InitVars()
		{
			dataColumn_0 = base.Columns["帐户ID"];
			dataColumn_1 = base.Columns["帐户名"];
			dataColumn_2 = base.Columns["密码"];
			dataColumn_3 = base.Columns["服务器类别"];
			dataColumn_4 = base.Columns["服位置"];
			dataColumn_5 = base.Columns["区位置"];
			dataColumn_6 = base.Columns["有效"];
			dataColumn_7 = base.Columns["被封"];
			dataColumn_8 = base.Columns["地图"];
			dataColumn_9 = base.Columns["更换地图LV"];
			dataColumn_10 = base.Columns["更新时间"];
			dataColumn_11 = base.Columns["备注"];
		}

		private void InitClass()
		{
			dataColumn_0 = new DataColumn("帐户ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_0);
			dataColumn_1 = new DataColumn("帐户名", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_1);
			dataColumn_2 = new DataColumn("密码", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_2);
			dataColumn_3 = new DataColumn("服务器类别", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_3);
			dataColumn_4 = new DataColumn("服位置", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_4);
			dataColumn_5 = new DataColumn("区位置", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_5);
			dataColumn_6 = new DataColumn("有效", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_6);
			dataColumn_7 = new DataColumn("被封", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_7);
			dataColumn_8 = new DataColumn("地图", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_8);
			dataColumn_9 = new DataColumn("更换地图LV", typeof(int), null, MappingType.Element);
			base.Columns.Add(dataColumn_9);
			dataColumn_10 = new DataColumn("更新时间", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(dataColumn_10);
			dataColumn_11 = new DataColumn("备注", typeof(string), null, MappingType.Element);
			base.Columns.Add(dataColumn_11);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { dataColumn_0 }, isPrimaryKey: true));
			dataColumn_0.AutoIncrement = true;
			dataColumn_0.AllowDBNull = false;
			dataColumn_0.Unique = true;
		}

		public GClass9 method_3()
		{
			return (GClass9)NewRow();
		}

		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new GClass9(builder);
		}

		protected override Type GetRowType()
		{
			return typeof(GClass9);
		}

		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (gdelegate4_0 != null)
			{
				gdelegate4_0(this, new GEventArgs4((GClass9)e.Row, e.Action));
			}
		}

		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (gdelegate4_1 != null)
			{
				gdelegate4_1(this, new GEventArgs4((GClass9)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (gdelegate4_2 != null)
			{
				gdelegate4_2(this, new GEventArgs4((GClass9)e.Row, e.Action));
			}
		}

		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (gdelegate4_3 != null)
			{
				gdelegate4_3(this, new GEventArgs4((GClass9)e.Row, e.Action));
			}
		}

		public void method_4(GClass9 row)
		{
			base.Rows.Remove(row);
		}
	}

	[DebuggerStepThrough]
	public class GClass9 : DataRow
	{
		private GClass8 gclass8_0;

		public int Int32_0
		{
			get
			{
				return (int)base[gclass8_0.DataColumn_0];
			}
			set
			{
				base[gclass8_0.DataColumn_0] = value;
			}
		}

		public string String_0
		{
			get
			{
				try
				{
					return (string)base[gclass8_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_1] = value;
			}
		}

		public string String_1
		{
			get
			{
				try
				{
					return (string)base[gclass8_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_2] = value;
			}
		}

		public string String_2
		{
			get
			{
				try
				{
					return (string)base[gclass8_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_3] = value;
			}
		}

		public int Int32_1
		{
			get
			{
				try
				{
					return (int)base[gclass8_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_4] = value;
			}
		}

		public int Int32_2
		{
			get
			{
				try
				{
					return (int)base[gclass8_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_5] = value;
			}
		}

		public int Int32_3
		{
			get
			{
				try
				{
					return (int)base[gclass8_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_6] = value;
			}
		}

		public int Int32_4
		{
			get
			{
				try
				{
					return (int)base[gclass8_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_7] = value;
			}
		}

		public string String_3
		{
			get
			{
				try
				{
					return (string)base[gclass8_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_8] = value;
			}
		}

		public int Int32_5
		{
			get
			{
				try
				{
					return (int)base[gclass8_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_9] = value;
			}
		}

		public DateTime DateTime_0
		{
			get
			{
				try
				{
					return (DateTime)base[gclass8_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_10] = value;
			}
		}

		public string String_4
		{
			get
			{
				try
				{
					return (string)base[gclass8_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("无法获取值，因为它是 DBNull。", innerException);
				}
			}
			set
			{
				base[gclass8_0.DataColumn_11] = value;
			}
		}

		internal GClass9(DataRowBuilder rb)
			: base(rb)
		{
			gclass8_0 = (GClass8)base.Table;
		}

		public bool method_0()
		{
			return IsNull(gclass8_0.DataColumn_1);
		}

		public void method_1()
		{
			base[gclass8_0.DataColumn_1] = Convert.DBNull;
		}

		public bool method_2()
		{
			return IsNull(gclass8_0.DataColumn_2);
		}

		public void method_3()
		{
			base[gclass8_0.DataColumn_2] = Convert.DBNull;
		}

		public bool method_4()
		{
			return IsNull(gclass8_0.DataColumn_3);
		}

		public void method_5()
		{
			base[gclass8_0.DataColumn_3] = Convert.DBNull;
		}

		public bool method_6()
		{
			return IsNull(gclass8_0.DataColumn_4);
		}

		public void method_7()
		{
			base[gclass8_0.DataColumn_4] = Convert.DBNull;
		}

		public bool method_8()
		{
			return IsNull(gclass8_0.DataColumn_5);
		}

		public void method_9()
		{
			base[gclass8_0.DataColumn_5] = Convert.DBNull;
		}

		public bool method_10()
		{
			return IsNull(gclass8_0.DataColumn_6);
		}

		public void method_11()
		{
			base[gclass8_0.DataColumn_6] = Convert.DBNull;
		}

		public bool method_12()
		{
			return IsNull(gclass8_0.DataColumn_7);
		}

		public void method_13()
		{
			base[gclass8_0.DataColumn_7] = Convert.DBNull;
		}

		public bool method_14()
		{
			return IsNull(gclass8_0.DataColumn_8);
		}

		public void method_15()
		{
			base[gclass8_0.DataColumn_8] = Convert.DBNull;
		}

		public bool method_16()
		{
			return IsNull(gclass8_0.DataColumn_9);
		}

		public void method_17()
		{
			base[gclass8_0.DataColumn_9] = Convert.DBNull;
		}

		public bool method_18()
		{
			return IsNull(gclass8_0.DataColumn_10);
		}

		public void method_19()
		{
			base[gclass8_0.DataColumn_10] = Convert.DBNull;
		}

		public bool method_20()
		{
			return IsNull(gclass8_0.DataColumn_11);
		}

		public void method_21()
		{
			base[gclass8_0.DataColumn_11] = Convert.DBNull;
		}
	}

	[DebuggerStepThrough]
	public class GEventArgs4 : EventArgs
	{
		private GClass9 eventRow;

		private DataRowAction eventAction;

		public GClass9 Row => eventRow;

		public DataRowAction Action => eventAction;

		public GEventArgs4(GClass9 row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private GClass0 gclass0_0;

	private GClass2 gclass2_0;

	private GClass4 gclass4_0;

	private GClass6 gclass6_0;

	private GClass8 gclass8_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public GClass0 GClass0_0 => gclass0_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public GClass2 GClass2_0 => gclass2_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public GClass4 GClass4_0 => gclass4_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public GClass6 GClass6_0 => gclass6_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public GClass8 GClass8_0 => gclass8_0;

	public GEHero109DataSet()
	{
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
	}

	protected GEHero109DataSet(SerializationInfo info, StreamingContext context)
	{
		string text = (string)info.GetValue("XmlSchema", typeof(string));
		if (text != null)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(text)));
			if (dataSet.Tables["角色类别资料"] != null)
			{
				base.Tables.Add(new GClass0(dataSet.Tables["角色类别资料"]));
			}
			if (dataSet.Tables["角色资料"] != null)
			{
				base.Tables.Add(new GClass2(dataSet.Tables["角色资料"]));
			}
			if (dataSet.Tables["卡表资料"] != null)
			{
				base.Tables.Add(new GClass4(dataSet.Tables["卡表资料"]));
			}
			if (dataSet.Tables["授权帐号资料"] != null)
			{
				base.Tables.Add(new GClass6(dataSet.Tables["授权帐号资料"]));
			}
			if (dataSet.Tables["帐户资料"] != null)
			{
				base.Tables.Add(new GClass8(dataSet.Tables["帐户资料"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			InitClass();
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
	}

	public override DataSet Clone()
	{
		GEHero109DataSet gEHero109DataSet = (GEHero109DataSet)base.Clone();
		gEHero109DataSet.InitVars();
		return gEHero109DataSet;
	}

	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	protected override void ReadXmlSerializable(XmlReader reader)
	{
		Reset();
		DataSet dataSet = new DataSet();
		dataSet.ReadXml(reader);
		if (dataSet.Tables["角色类别资料"] != null)
		{
			base.Tables.Add(new GClass0(dataSet.Tables["角色类别资料"]));
		}
		if (dataSet.Tables["角色资料"] != null)
		{
			base.Tables.Add(new GClass2(dataSet.Tables["角色资料"]));
		}
		if (dataSet.Tables["卡表资料"] != null)
		{
			base.Tables.Add(new GClass4(dataSet.Tables["卡表资料"]));
		}
		if (dataSet.Tables["授权帐号资料"] != null)
		{
			base.Tables.Add(new GClass6(dataSet.Tables["授权帐号资料"]));
		}
		if (dataSet.Tables["帐户资料"] != null)
		{
			base.Tables.Add(new GClass8(dataSet.Tables["帐户资料"]));
		}
		base.DataSetName = dataSet.DataSetName;
		base.Prefix = dataSet.Prefix;
		base.Namespace = dataSet.Namespace;
		base.Locale = dataSet.Locale;
		base.CaseSensitive = dataSet.CaseSensitive;
		base.EnforceConstraints = dataSet.EnforceConstraints;
		Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
		InitVars();
	}

	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	internal void InitVars()
	{
		gclass0_0 = (GClass0)base.Tables["角色类别资料"];
		if (gclass0_0 != null)
		{
			gclass0_0.InitVars();
		}
		gclass2_0 = (GClass2)base.Tables["角色资料"];
		if (gclass2_0 != null)
		{
			gclass2_0.InitVars();
		}
		gclass4_0 = (GClass4)base.Tables["卡表资料"];
		if (gclass4_0 != null)
		{
			gclass4_0.InitVars();
		}
		gclass6_0 = (GClass6)base.Tables["授权帐号资料"];
		if (gclass6_0 != null)
		{
			gclass6_0.InitVars();
		}
		gclass8_0 = (GClass8)base.Tables["帐户资料"];
		if (gclass8_0 != null)
		{
			gclass8_0.InitVars();
		}
	}

	private void InitClass()
	{
		base.DataSetName = "GEHero109DataSet";
		base.Prefix = "";
		base.Namespace = "http://www.tempuri.org/GEHero109DataSet.xsd";
		base.Locale = new CultureInfo("zh-CN");
		base.CaseSensitive = false;
		base.EnforceConstraints = true;
		gclass0_0 = new GClass0();
		base.Tables.Add(gclass0_0);
		gclass2_0 = new GClass2();
		base.Tables.Add(gclass2_0);
		gclass4_0 = new GClass4();
		base.Tables.Add(gclass4_0);
		gclass6_0 = new GClass6();
		base.Tables.Add(gclass6_0);
		gclass8_0 = new GClass8();
		base.Tables.Add(gclass8_0);
	}

	private bool method_0()
	{
		return false;
	}

	private bool method_1()
	{
		return false;
	}

	private bool method_2()
	{
		return false;
	}

	private bool method_3()
	{
		return false;
	}

	private bool method_4()
	{
		return false;
	}

	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}
}
