public class Bibliotek
{//method to create a list of books
    public List<Bok> Books { get; set; } = new List<Bok>();
	//method to add a book to the library
	public void AddBook(Bok book)
	{
		Books.Add(book);
	}
	// Method to borrow a book
public void LanaBok(string titel)
{
    // Find the first book with the given title
    Bok? book = Books.Find(b => b.Titel == titel);

    // Check if the book exists and is available
    if (book != null && !book.ArUtlanad)
    {
        // Mark the book as borrowed
        book.ArUtlanad = true;

        Console.WriteLine($"Boken '{titel}' har lånats ut.");
    }
    // Check if the book exists but is already borrowed
    else if (book != null && book.ArUtlanad)
    {
        Console.WriteLine($"Boken '{titel}' är redan utlånad.");
    }
    // The book was not found
    else
    {
        Console.WriteLine($"Boken '{titel}' finns inte i biblioteket.");
    }}
// Method to return a book
	public void LämnaTillbakaBok(string titel)
	{
		// Find the first book with the given title
		Bok? book = Books.Find(b => b.Titel == titel);

		// Check if the book exists and is currently borrowed
		if (book != null && book.ArUtlanad)
		{
			// Mark the book as returned
			book.ArUtlanad = false;

			Console.WriteLine($"Boken '{titel}' har lämnats tillbaka.");
		}
		// Check if the book exists but is not borrowed
		else if (book != null && !book.ArUtlanad)
		{
			Console.WriteLine($"Boken '{titel}' är inte utlånad.");
		}
		// The book was not found
		else
		{
			Console.WriteLine($"Boken '{titel}' finns inte i biblioteket.");
		}
}
// Method to search for books by title or author
public void SearchBooks(string search)
	{// Search for books by title or author
		 List<Bok> results = Books.FindAll(
        b => b.Titel == search || b.Författare == search
	);
		// Display the search results
		if (results.Count > 0)
		{
			Console.WriteLine($"Sökresultat för '{search}':");
			foreach (Bok book in results)
			{
				Console.WriteLine($"Titel: {book.Titel}, Författare: {book.Författare}, Utgivningsår: {book.Utgivningsar}, Utlånad: {book.ArUtlanad}");
			}
		}
		else
		{
			Console.WriteLine($"Inga böcker hittades för '{search}'.");
		}
		
	}
	// Method to show all available books
public void VisaTillgangligaBocker()
{
    // Find all books that are not borrowed
    List<Bok> availableBooks = Books.FindAll(
        b => !b.ArUtlanad
    );

    // Check if there are available books
    if (availableBooks.Count > 0)
    {
        foreach (Bok book in availableBooks)
        {
            Console.WriteLine(
                $"Titel: {book.Titel}, Författare: {book.Författare}"
            );
        }
    }
    else
    {
        Console.WriteLine("Inga tillgängliga böcker.");
    }
}
	


	}