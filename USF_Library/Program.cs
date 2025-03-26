using System;
namespace USF_Library
{
    class Program
    {
        static void Main()
        {
            Library usfLibrary = new Library();
            var book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            var book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            var book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            usfLibrary.AddBook(book1);
            usfLibrary.AddBook(book2);
            usfLibrary.AddBook(book3);
            var student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            var student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            var staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

            usfLibrary.AddPatron(student1);
            usfLibrary.AddPatron(student2);
            usfLibrary.AddPatron(staff1);
            usfLibrary.DisplayBooks();
            usfLibrary.DisplayPatrons();

            Console.WriteLine("Borrowing Books...");
            if (usfLibrary.FindBookByTitle("Business Insights with AI").BorrowBooks())
                Console.WriteLine("Sandeep borrowed 'Business Insights with AI'");
            if (usfLibrary.FindBookByTitle("Analytics in Action").BorrowBooks())
                Console.WriteLine("Akhil borrowed 'Analytics in Action'");

            Console.WriteLine();
            Console.WriteLine("Books after borrowing:");
            usfLibrary.DisplayBooks();
        }
    }
}