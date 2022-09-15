namespace DevComponents.DotNetBar;

public interface IPersonalizedMenuItem
{
	eMenuVisibility MenuVisibility { get; set; }

	bool RecentlyUsed { get; set; }
}
