// Create two books and manage their borrowing, returning, and availability.

Console.Write("Enter the first book's title: ");
string book1Title = Console.ReadLine()!;

Console.Write("Enter the author's name: ");
string book1Author = Console.ReadLine()!;

Console.Write("Enter the second book's title: ");
string book2Title = Console.ReadLine()!;

Console.Write("Enter the author's name: ");
string book2Author = Console.ReadLine()!;

Book b1 = new Book(book1Title, book1Author);
Book b2 = new Book(book2Title, book2Author);

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