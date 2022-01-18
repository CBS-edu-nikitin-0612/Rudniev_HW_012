using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Book
    {
        Title title;
        Author author;
        Content content;

        public Book() { }
        public Book(string title, string author, string content)
        {
            this.title = new Title();
            this.title.Text = title;
            this.author = new Author();
            this.author.Text = author;
            this.content = new Content();
            this.content.Text = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            title.Show();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            content.Show();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
