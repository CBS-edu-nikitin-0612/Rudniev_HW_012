using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            Book book = null;
            while (b)
            {
                Console.Write("Что бы добавить новую книгу введите 'W', \nчто бы вывести последнюю добавленную книгу введите 'R', \nчто бы выйти введите любой другой символ: ");
                switch(Console.ReadLine().ToUpper())
                {
                    case "W":
                        Console.WriteLine("Введите название книги: ");
                        var title = Console.ReadLine();
                        Console.WriteLine("Введите имя автора: ");
                        var author = Console.ReadLine();
                        Console.WriteLine("Введите описание книги: ");
                        var content = Console.ReadLine();
                        book = new Book(title, author, content);
                        break;
                    case "R":
                        if (book == null)
                            book = new Book(null, null, null);
                        book.Show();
                        break;
                    default:
                        b = false;
                        break;
                }
            }
        }
    }
}
