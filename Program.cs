// Create a library object
Bibliotek bibliotek = new Bibliotek();

// Variable for the user's menu choice
int choice = 0;

// Keep showing the menu until the user chooses to exit
while (choice != 6)
{
    // Display the menu
    Console.WriteLine("\n--- Bibliotekssystem ---");
    Console.WriteLine("1. Lägg till bok");
    Console.WriteLine("2. Låna bok");
    Console.WriteLine("3. Lämna tillbaka bok");
    Console.WriteLine("4. Sök efter bok");
    Console.WriteLine("5. Visa tillgängliga böcker");
    Console.WriteLine("6. Avsluta");
    Console.Write("Välj ett alternativ: ");

    // Read the user's choice
    choice = Convert.ToInt32(Console.ReadLine());

    // Perform an action based on the user's choice
    switch (choice)
    {
        case 1:
            // Ask the user for the book information
            Console.Write("Ange titel: ");
            string newTitel = Console.ReadLine()!;

            Console.Write("Ange författare: ");
            string newForfattare = Console.ReadLine()!;

            Console.Write("Ange utgivningsår: ");
            int newUtgivningsar = Convert.ToInt32(Console.ReadLine());

            // Create a new book object
            Bok newBook = new Bok
            {
                Titel = newTitel,
                Författare = newForfattare,
                Utgivningsar = newUtgivningsar,
                ArUtlanad = false
            };

            // Add the new book to the library
            bibliotek.AddBook(newBook);

            Console.WriteLine("Boken har lagts till.");
            break;

        case 2:
            // Ask which book the user wants to borrow
            Console.Write("Ange titeln på boken du vill låna: ");
            string borrowTitel = Console.ReadLine()!;

            // Borrow the book
            bibliotek.LanaBok(borrowTitel);
            break;

        case 3:
            // Ask which book the user wants to return
            Console.Write("Ange titeln på boken du vill lämna tillbaka: ");
            string returnTitel = Console.ReadLine()!;

            // Return the book
            bibliotek.LämnaTillbakaBok(returnTitel);
            break;

        case 4:
            // Ask the user to search by title or author
            Console.Write("Sök efter titel eller författare: ");
            string search = Console.ReadLine()!;

            // Search for matching books
            bibliotek.SearchBooks(search);
            break;

        case 5:
            // Show all books that are currently available
            bibliotek.VisaTillgangligaBocker();
            break;

        case 6:
            // Exit the program
            Console.WriteLine("Programmet avslutas.");
            break;

        default:
            // Handle an invalid menu choice
            Console.WriteLine("Ogiltigt val.");
            break;
    }
}

//uppgift 2
TaskManager taskManager = new TaskManager();

int taskChoice = 0;

while (taskChoice != 5)
{
    // Show menu
    Console.WriteLine("\n--- Uppgiftshanterare ---");
    Console.WriteLine("1. Lägg till uppgift");
    Console.WriteLine("2. Visa nästa uppgift");
    Console.WriteLine("3. Visa alla uppgifter");
    Console.WriteLine("4. Slutför uppgift");
    Console.WriteLine("5. Avsluta");
    Console.Write("Välj ett alternativ: ");

    taskChoice = Convert.ToInt32(Console.ReadLine());

    switch (taskChoice)
    {
        case 1:
            // Ask the user for the task information
            Console.Write("Ange titel: ");
            string newTitel = Console.ReadLine()!;

            Console.Write("Ange prioritet (1 = hög, 2 = medel, 3 = låg): ");
            int newPrioritet = Convert.ToInt32(Console.ReadLine());

            // Create a new task object
            Task newTask = new Task
            {
                Titel = newTitel,
                Prioritet = newPrioritet
            };

            // Add the new task
            taskManager.AddTask(newTask);

            Console.WriteLine("Uppgiften har lagts till.");
            break;

			case 2:
			// Show the next task
			taskManager.NextTask();
			break;

		case 3:
			// Show all tasks
			taskManager.ShowAllTasks();
			break;

		case 4:
			// Ask which task the user wants to complete
			Console.Write("Ange titeln på uppgiften du vill slutföra: ");
			string completeTitel = Console.ReadLine()!;

			// Complete the task
			taskManager.CompleteTask(completeTitel);
			break;

		case 5:
			// Exit the program
			Console.WriteLine("Programmet avslutas.");
			break;

		default:
			// Handle an invalid menu choice
			Console.WriteLine("Ogiltigt val.");
			break;

		
    }

	//uppgift 3
	HistoryManager historyManager = new HistoryManager();
	// Variable for the user's menu choice
	int historyChoice = 0;
	// Keep showing the menu until the user chooses to exit
	while (historyChoice != 7)
	{
		    Console.WriteLine("\n--- Text Editor ---");
    Console.WriteLine("1. Add text");
    Console.WriteLine("2. Undo");
    Console.WriteLine("3. Redo");
    Console.WriteLine("4. Show history");
    Console.WriteLine("5. Show undone actions");
    Console.WriteLine("6. Clear");
    Console.WriteLine("7. Exit");
    Console.Write("Enter your choice: ");
    historyChoice = Convert.ToInt32(Console.ReadLine());
	switch (historyChoice)
	{
		case 1:
			Console.Write("Enter text to add: ");
			string textToAdd = Console.ReadLine()!;
			historyManager.AddText(textToAdd);
			break;

			case 2:
			Console.WriteLine("Undoing last action...");
			historyManager.Undo();
			break;
			case 3:
			Console.WriteLine("Redoing last undone action...");
			historyManager.Redo();
			break;
			case 4:
			Console.WriteLine("History:");
			historyManager.ShowHistory();
			break;
			case 5:
			Console.WriteLine("Undone actions:");
			historyManager.ShowUndoneActions();
			break;
			case 6:
			Console.WriteLine("Clearing history and undone actions...");
			historyManager.Clear();
			break;
			case 7:
           Console.WriteLine("Exiting...");
           break;

          default:
         Console.WriteLine("Invalid choice. Please try again.");
          break;


	}
}
}