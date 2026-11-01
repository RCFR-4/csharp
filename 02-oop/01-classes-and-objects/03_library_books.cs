// Create two books with predefined information and manage their borrowing, returning, and availability.

Book b1 = new Book("Dom Casmurro", "Machado de Assis");
Book b2 = new Book("The Hobbit", "J. R. R. Tolkien");

Console.WriteLine($"\n{b1.Borrow()}");
Console.WriteLine($"{b1.Borrow()}");
Console.WriteLine($"{b2.Borrow()}");
Console.WriteLine($"{b1.ReturnBook()}");

Console.WriteLine("\nBook Status:");

Console.WriteLine($"Title: {b1.Title}");
Console.WriteLine($"Author: {b1.Author}");
Console.WriteLine($"Available: {(b1.Available ? "Yes" : "No")}");

Console.WriteLine($"\nTitle: {b2.Title}");
Console.WriteLine($"Author: {b2.Author}");
Console.WriteLine($"Available: {(b2.Available ? "Yes" : "No")}");

class Book(string title, string author)
{
    public string Title = title;
    public string Author = author;
    public bool Available = true;

    public string Borrow()
    {
        string result = "";

        if (Available == true)
        {
            Available = false;
            result = "Book borrowed successfully";
        }
        else
        {
            result = "Book unavailable. It has already been borrowed";
        }

        return result;
    }

    public string ReturnBook()
    {
        Available = true;

        return "Book returned successfully";
    }
}
