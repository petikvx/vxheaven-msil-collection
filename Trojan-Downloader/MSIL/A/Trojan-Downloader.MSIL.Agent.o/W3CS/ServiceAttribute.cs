using System;

namespace W3CS;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
[GAttribute0(Feature = "renaming", Exclude = true, ApplyToMembers = true, StripAfterObfuscation = true)]
[Attribute0]
internal class ServiceAttribute : Attribute
{
	protected string name_;

	protected string displayName_;

	protected string description_;

	protected string logName_;

	protected bool run_;

	protected GClass2.GEnum2 servType_;

	protected GClass2.GEnum1 servAccessType_;

	protected GClass2.GEnum4 servStartType_;

	protected GClass2.GEnum5 servErrorControl_;

	protected GClass2.GEnum3 servControls_;

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			Name = value;
		}
	}

	public string DisplayName
	{
		get
		{
			return displayName_;
		}
		set
		{
			displayName_ = value;
		}
	}

	public string Description
	{
		get
		{
			return description_;
		}
		set
		{
			description_ = value;
		}
	}

	public bool Run
	{
		get
		{
			return run_;
		}
		set
		{
			run_ = value;
		}
	}

	public GClass2.GEnum2 ServiceType
	{
		get
		{
			return servType_;
		}
		set
		{
			servType_ = value;
		}
	}

	public GClass2.GEnum1 ServiceAccessType
	{
		get
		{
			return servAccessType_;
		}
		set
		{
			servAccessType_ = value;
		}
	}

	public GClass2.GEnum4 ServiceStartType
	{
		get
		{
			return servStartType_;
		}
		set
		{
			servStartType_ = value;
		}
	}

	public GClass2.GEnum5 ServiceErrorControl
	{
		get
		{
			return servErrorControl_;
		}
		set
		{
			servErrorControl_ = value;
		}
	}

	public GClass2.GEnum3 ServiceControls
	{
		get
		{
			return servControls_;
		}
		set
		{
			servControls_ = value;
		}
	}

	public string LogName
	{
		get
		{
			return logName_;
		}
		set
		{
			logName_ = value;
		}
	}

	public ServiceAttribute(string Name, string DisplayName, string Description, bool Run, GClass2.GEnum2 ServiceType, GClass2.GEnum1 ServiceAccessType, GClass2.GEnum4 ServiceStartType, GClass2.GEnum5 ServiceErrorControl, GClass2.GEnum3 ServiceControls)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = Description;
		run_ = Run;
		servType_ = ServiceType;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = ServiceStartType;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = ServiceControls;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name, string DisplayName, string Description, bool Run, GClass2.GEnum2 ServiceType, GClass2.GEnum1 ServiceAccessType, GClass2.GEnum4 ServiceStartType, GClass2.GEnum5 ServiceErrorControl)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = Description;
		run_ = Run;
		servType_ = ServiceType;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = ServiceStartType;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name, string DisplayName, string Description, GClass2.GEnum2 ServiceType, GClass2.GEnum1 ServiceAccessType, GClass2.GEnum4 ServiceStartType, GClass2.GEnum5 ServiceErrorControl)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = Description;
		run_ = true;
		servType_ = ServiceType;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = ServiceStartType;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name, string DisplayName, string Description, GClass2.GEnum2 ServiceType, GClass2.GEnum4 ServiceStartType)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = Description;
		run_ = true;
		servType_ = ServiceType;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = ServiceStartType;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name, string DisplayName, string Description, GClass2.GEnum4 ServiceStartType)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = Description;
		run_ = true;
		servType_ = GClass2.GEnum2.flag_0;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = ServiceStartType;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name, string DisplayName, string Description, GClass2.GEnum2 ServiceType)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = Description;
		run_ = true;
		servType_ = ServiceType;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = GClass2.GEnum4.const_2;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name, string DisplayName, string Description, bool Run, GClass2.GEnum2 ServiceType)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = Description;
		run_ = Run;
		servType_ = ServiceType;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = GClass2.GEnum4.const_2;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name, string DisplayName, string Description, bool Run)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = Description;
		run_ = Run;
		servType_ = GClass2.GEnum2.flag_0;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = GClass2.GEnum4.const_2;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name, string DisplayName, string Description)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = Description;
		run_ = true;
		servType_ = GClass2.GEnum2.flag_0;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = GClass2.GEnum4.const_2;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name, string DisplayName)
	{
		name_ = Name;
		displayName_ = DisplayName;
		description_ = "";
		run_ = true;
		servType_ = GClass2.GEnum2.flag_0;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = GClass2.GEnum4.const_2;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}

	public ServiceAttribute(string Name)
	{
		name_ = Name;
		displayName_ = Name;
		description_ = "";
		run_ = true;
		servType_ = GClass2.GEnum2.flag_0;
		servAccessType_ = GClass2.GEnum1.flag_10;
		servStartType_ = GClass2.GEnum4.const_2;
		servErrorControl_ = GClass2.GEnum5.const_1;
		servControls_ = GClass2.GEnum3.flag_0;
		logName_ = "Services";
	}
}
