using System.ComponentModel;

namespace DevComponents.DotNetBar;

public class RatingChangeEventArgs : CancelEventArgs
{
	public int NewRating;

	public readonly int OldRating;

	public readonly eEventSource EventSource = eEventSource.Code;

	public RatingChangeEventArgs(int newRating, int oldRating, eEventSource eventSource)
	{
		NewRating = newRating;
		OldRating = oldRating;
		EventSource = eventSource;
	}
}
