using System;
using System.Diagnostics;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _Transactions = 0;
        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        public static void SetTrans()
        {
            _Transactions++;
        }
        public static int GetTrans()
        {
            return _Transactions;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.SetId(1);
            book1.SetTitle("The Drifter");
            book1.SetAuthor("Nick Petrie");
            book.SetTrans();

            book book2 = new book();
            Console.WriteLine("Please enter your book's ID");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your book's title");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter your book's author");
            book2.SetAuthor(Console.ReadLine());
            book.SetTrans();

            book book3 = new book(3, "Burning Bright", "Nick Petrie");
            book.SetTrans();
            Console.WriteLine("Please enter your book's ID");
            int tempId = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your book's title");
            string tempTitle = (Console.ReadLine());
            Console.WriteLine("Please enter your book's author");
            string tempAuthor = (Console.ReadLine());
            book book4 = new book(tempId, tempTitle, tempAuthor);
            book.SetTrans();

            Console.WriteLine($"The book store has {book.GetTrans()} transactions.");
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }
        static void displayBooks(book book)
        {
            Console.WriteLine("Here is all off your books' information");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
        }



    }

}