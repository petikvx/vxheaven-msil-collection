using System;

namespace DevComponents.Editors;

public class InputValidationEventArgs : EventArgs
{
	public readonly string Input = "";

	public bool AcceptInput = true;

	public InputValidationEventArgs(string input)
	{
		Input = input;
	}
}
