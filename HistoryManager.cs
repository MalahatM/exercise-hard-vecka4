public class HistoryManager
{
    // List for storing history
    public List<string> History { get; set; } = new List<string>();

    // Stack for storing undone actions
    public Stack<string> UndoneActions { get; set; } = new Stack<string>();

    // Add text to history
    public void AddText(string text)
    {
        History.Add(text);
    }
// Method to undo/Remove the last action
	public void Undo()
	{
		if (History.Count > 0)
		{
			string lastText = History[History.Count - 1];
			History.RemoveAt(History.Count - 1);
			UndoneActions.Push(lastText);
		}
		else
		{
			Console.WriteLine("Inga åtgärder att ångra.");
		}
	}

	// Method to redo the last undone action
	public void Redo()
	{
		if (UndoneActions.Count > 0)
		{
			string lastUndoneText = UndoneActions.Pop();
			History.Add(lastUndoneText);
		}
		// If there are no undone actions, inform the user
		else
		{
			Console.WriteLine("Inga åtgärder att göra om.");
		}
	}
}