using System;
using System.Collections.Generic;
using System.IO;

namespace Sandbox.ThirtyDaysOfCode
{
    public abstract class Book
    {
        protected String title;
        protected  String author;

        public Book(String title,String author){
            this.title = title;
            this.author = author;
        }
        public abstract void display();
    }
}