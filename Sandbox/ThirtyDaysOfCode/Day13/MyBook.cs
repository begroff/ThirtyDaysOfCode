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
            Console.Write($"Title: {this.title} Author: {this.author} Price: {this.price}");
        }
    }
}