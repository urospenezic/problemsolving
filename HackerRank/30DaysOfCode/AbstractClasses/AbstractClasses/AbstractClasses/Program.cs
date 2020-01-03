using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}

class MyBook : Book
{
    public int Price { get; set; }
    public MyBook(string t, string a, int p) : base(t, a)
    {
        Price = p;
    }

    public override void display()
    {
        Console.WriteLine("Title: {0}",title);
        Console.WriteLine("Author: {0}",author);
        Console.WriteLine("Price: {0}",Price);
    }
}

class Solution
{
    static void Main(String[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}