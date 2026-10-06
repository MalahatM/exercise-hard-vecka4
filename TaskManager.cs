public class TaskManager
{
    public List<Task> Tasks { get; set; } = new List<Task>();
	// Method to add a task to the task manager
	public void AddTask(Task task)
	{
		Tasks.Add(task);
	}
}