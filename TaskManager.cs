public class TaskManager
{
    public List<Task> Tasks { get; set; } = new List<Task>();
	// Method to add a task to the task manager
	public void AddTask(Task task)
	{
		Tasks.Add(task);
	}
	public void NextTask()
	{
		if (Tasks.Count > 0)
		{
			// Find the task with the highest priority (lowest number)
			Task nextTask = Tasks.OrderBy(t => t.Prioritet).First();

			Console.WriteLine($"Nästa uppgift: {nextTask.Titel} (Prioritet: {nextTask.Prioritet})");
		}
		else
		{
			Console.WriteLine("Inga uppgifter finns.");
		}
	}
	public void ShowAllTasks()
{
    // Sort tasks by priority (lowest number = highest priority)
    var sortedTasks = Tasks.OrderBy(t => t.Prioritet);

    // Show all tasks
    foreach (Task task in sortedTasks)
    {
        Console.WriteLine($"Titel: {task.Titel}, Prioritet: {task.Prioritet}");
    }
}
}