namespace DevComponents.DotNetBar;

public interface IOwnerAutoHideSupport
{
	AutoHidePanel LeftAutoHidePanel { get; set; }

	AutoHidePanel RightAutoHidePanel { get; set; }

	AutoHidePanel TopAutoHidePanel { get; set; }

	AutoHidePanel BottomAutoHidePanel { get; set; }

	bool HasLeftAutoHidePanel { get; }

	bool HasRightAutoHidePanel { get; }

	bool HasTopAutoHidePanel { get; }

	bool HasBottomAutoHidePanel { get; }
}
