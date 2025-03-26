using System;

public class Book 
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int AvailableCopies { get; set; }

    public Book(string title, string author, string isbn, int availableCopies)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        AvailableCopies = availableCopies;
    }

    public bool BorrowBooks()
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies = AvailableCopies--;
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Available Copies: {AvailableCopies}";
    }
}