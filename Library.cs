using System;
using System.Collections.Generic;
public class Library
{
    public List<Book> Books { get; set; } = new List<Book>();
    public List<Person> Patrons { get; set; } = new List<Person>();

    public void AddBook(Book book) => Books.Add(book);
    public void AddPatron(Person person) => Patrons.Add(person);

    public void DisplayBooks()
    {
        Console.WriteLine("Books in Library:");
        foreach (var book in Books)
            Console.WriteLine(book);
        Console.WriteLine();
    }

    public void DisplayPatrons()
    {
        Console.WriteLine("Patrons in Library:");
        foreach (var patron in Patrons)
            Console.WriteLine(patron);
        Console.WriteLine();
    }
    public Book FindBookByTitle(string title)
    {
        return Books.Find(b => b.Title == title);
    }

}