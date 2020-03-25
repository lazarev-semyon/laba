using System;
using System.Collections.Generic;

namespace AuthorLibrary
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            string userInput = "";
            while (userInput != "5")
            {
                Console.WriteLine("1. Добавить новую книгу");
                Console.WriteLine("2. Вывести книги по автору");
                Console.WriteLine("3. Удалить книгу по названию");
                Console.WriteLine("4. Удалить все книги по автору");
                Console.WriteLine("5. Выход");
                userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    Console.WriteLine("Введите название книги");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите жанр книги");
                    string bookType = Console.ReadLine();
                    Console.WriteLine("Введите фамилию автора");
                    string authorSurname = Console.ReadLine();
                    Console.WriteLine("Введите имя автора");
                    string authorName = Console.ReadLine();
                    Book book = Util.CreateBook(name, bookType, authorName, authorSurname);
                    library.Add(book);
                }else if(userInput == "2")
                {
                    Console.WriteLine("Введите фамилию автора");
                    string authorSurname = Console.ReadLine();
                    Console.WriteLine("Введите имя автора");
                    string authorName = Console.ReadLine();
                    
                    List<Book> foundedBookList = Util.GetBookListByAuthor(authorName, authorSurname, library.GetBooks());
                    if (foundedBookList.Count == 0)
                    {
                        Console.WriteLine("По данному автору книг не найдено");

                    }
                    else
                    {
                        Console.WriteLine("По данному автора найдены книги:");
                        foreach (Book book in foundedBookList)
                        {
                            Console.WriteLine(book);
                        }
                    }
                }else if(userInput == "3")
                {
                    Console.WriteLine("Введите название книги для удаления");
                    string name = Console.ReadLine();
                    if (Util.RemoveBookByName(name, library.GetBooks()))
                    {
                        Console.WriteLine("Книга успешно удалена");
                    }
                    else
                    {
                        Console.WriteLine("Книга не удалена");
                    }
                }
                else if (userInput == "4")
                {
                    Console.WriteLine("Введите фамилию автора");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Введите имя автора");
                    string name = Console.ReadLine();
                    
                    if (Util.RemoveBooksByAuthor(name, surname, library.GetBooks()))
                    {
                        Console.WriteLine("Книги удалены");
                    }
                    else
                    {
                        Console.WriteLine("Книги не удалены");
                    }
                }else if (userInput != "5")
                {
                    Console.WriteLine("Выбран неверный пункт меню");
                }
            }
        }
    }
}

