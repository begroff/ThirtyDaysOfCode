using System;
using System.Collections.Generic;
using System.IO;

namespace Sandbox.ThirtyDaysOfCode
{
    public class MyBook : Book
    {
        private int price = 0;

        public MyBook(string title, string author, int price) : base(title, author) {
            this.price = price;
        }

        public override void display() {
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Author: {this.author}");
            Console.WriteLine($"Price: {this.price}");
        }
    }
}