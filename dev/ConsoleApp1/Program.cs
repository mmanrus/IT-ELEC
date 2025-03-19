using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}";
    }
}

class Member
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int MemberId { get; set; }
    private List<Book> BorrowedBooks = new List<Book>();

    public Member(string name, string address, int memberId)
    {
        Name = name;
        Address = address;
        MemberId = memberId;
    }

    public void BorrowBook(Book book)
    {
        BorrowedBooks.Add(book);
        Console.WriteLine($"{Name} borrowed \"{book.Title}\" by {book.Author}");
        Console.WriteLine();
    }

    public void ShowBorrowedBooks()
    {
        Console.WriteLine($"{Name} has borrowed the following books:");
        foreach (var book in BorrowedBooks)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();
    }
     public void ReturnBook(Book book)
    {
          BorrowedBooks.Remove(book);
          Console.WriteLine($"{Name} returned \"{book.Title}\" by {book.Author}");
          Console.WriteLine();
    }
    public void Details(){
          Console.WriteLine($"Name: {Name}");
          Console.WriteLine($"Address: {Address}");
          Console.WriteLine($"Member Id: {MemberId}");
          Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book book2 = new Book("1984", "George Orwell");

        Member member1 = new Member("Alice", "123 Mapple Street", 101);
        
        Member member2 = new Member("Bob", "456 Oak Avenue", 102);
        member1.Details();
        member2.Details();
        member1.BorrowBook(book1);
        member1.BorrowBook(book2);
        member1.ShowBorrowedBooks();

        member2.BorrowBook(book2);
        member2.ShowBorrowedBooks();

        member1.ReturnBook(book1);
        
        member2.ReturnBook(book1);
    }
}
