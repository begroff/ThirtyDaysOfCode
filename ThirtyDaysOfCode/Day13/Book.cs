using System;
using System.Collections.Generic;
using System.IO;

namespace ThirtyDaysOfCode.Day13
{
    public abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String title, String author)
        {
            this.title = title;
            this.author = author;
        }
        public abstract void display();
    }
}