public class FilmManager
{
    private List<Film> films = new List<Film>();

    // Method to add a film
    public void AddFilm(Film film)
    {
        films.Add(film);
    }

    // Method to show all films
  // Method to show all films
public void ShowAllFilms()
{
    if (films.Count == 0)
    {
        Console.WriteLine("No films found.");
    }
    else
    {
        foreach (Film film in films)
        {
            Console.WriteLine($"Title: {film.Title}, Genre: {film.Genre}, Rating: {film.Rating}");
        }
    }
}
    // Method to search for films by genre
    public void SearchByGenre(string genre)
    {
        List<Film> foundFilms = films.FindAll(film => film.Genre == genre);
// Display the search results
        if (foundFilms.Count > 0)
        {
            foreach (Film film in foundFilms)
            {
                Console.WriteLine($"Title: {film.Title}, Genre: {film.Genre}, Rating: {film.Rating}");
            }
        }
        else
        {
            Console.WriteLine("No films found.");
        }
    }

    // Method to show the three highest-rated films
    public void ShowTop3Films()
    {
        // Check if there are any films
        if (films.Count == 0)
        {
            Console.WriteLine("No films found.");
        }
        else
        {
            // Sort films by rating and take the top three
            var top3Films = films
                .OrderByDescending(film => film.Rating)
                .Take(3);

            // Display the top three films
            foreach (Film film in top3Films)
            {
                Console.WriteLine($"Title: {film.Title}, Rating: {film.Rating}");
            }
        }
    }

    // Method to remove a film by its title
    public void RemoveFilm(string title)
    {
        // Find the film with the given title
        Film? film = films.Find(f => f.Title == title);

        // Remove the film if it exists
        if (film != null)
        {
            films.Remove(film);
            Console.WriteLine("Film deleted.");
        }
        else
        {
            Console.WriteLine("Film not found.");
        }
    }
}