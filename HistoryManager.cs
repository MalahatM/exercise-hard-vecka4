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
}