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