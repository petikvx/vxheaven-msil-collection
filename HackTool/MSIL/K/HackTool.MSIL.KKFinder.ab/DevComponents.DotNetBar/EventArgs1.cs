using System;

namespace DevComponents.DotNetBar;

internal class EventArgs1 : EventArgs
{
	public IntPtr intptr_0 = IntPtr.Zero;

	public IntPtr intptr_1 = IntPtr.Zero;

	public IntPtr intptr_2 = IntPtr.Zero;

	public EventArgs1(IntPtr hwnd, IntPtr wparam, IntPtr lparam)
	{
		intptr_0 = hwnd;
		intptr_1 = wparam;
		intptr_2 = lparam;
	}
}
