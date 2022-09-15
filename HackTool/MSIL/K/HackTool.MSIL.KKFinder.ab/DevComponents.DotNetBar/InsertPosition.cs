namespace DevComponents.DotNetBar;

public class InsertPosition
{
	public int Position;

	public bool Before;

	public IDesignTimeProvider TargetProvider;

	public InsertPosition()
	{
		Position = -1;
		Before = false;
		TargetProvider = null;
	}

	public InsertPosition(int iPosition, bool bBefore, IDesignTimeProvider target)
	{
		Position = iPosition;
		Before = bBefore;
		TargetProvider = target;
	}
}
