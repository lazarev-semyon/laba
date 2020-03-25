using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorLibrary
{
    /// <summary>
    /// Класс содержит методы для работы с библиотекой
    /// </summary>
    public class Util
    {
        /// <summary>
        /// Создает новую книгу
        /// </summary>
        /// <param name="name">название книги</param>
        /// <param name="bookType">жанр книги</param>
        /// <param name="authorName">имя автора книги</param>
        /// <param name="authorSurname">фамилия автора книги</param>
        /// <returns>возвращает объект созданной книги</returns>
        public static Book CreateBook(string name, string bookType, string authorName, string authorSurname)
        {
            Author author = new Author(authorName, authorSurname);
            Book book = new Book(name, bookType, author);
            return book;
        }

        /// <summary>
        /// Ищет список книг по автору
        /// </summary>
        /// <param name="authorName">имя автора</param>
        /// <param name="authorSurname">фамилия автора</param>
        /// <param name="books">список имеющихся книг</param>
        /// <returns>возвращает список книг по автору</returns>
        public static List<Book> GetBookListByAuthor(string authorName, string authorSurname, List<Book> books)
        {
            List<Book> resultList = new List<Book>();
            
            Author author = new Author(authorName, authorSurname);
            foreach(Book book in books)
            {
                if (book.GetAuthor().Equals(author))
                {
                    resultList.Add(book);
                }
            }
            return resultList;
        }

        /// <summary>
        /// Удаляет книгу по названию
        /// </summary>
        /// <param name="name">название удаляемой книги</param>
        /// <param name="books">список книг в библиотеке</param>
        /// <returns>возвращает true при успешном удалении</returns>
        public static bool RemoveBookByName(string name, List<Book> books)
        {
            
            int initSize = books.Count;
            for (int i=0; i<books.Count; )
            {
                if(books[i].GetName() == name)
                {
                    books.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            if (initSize != books.Count)
                return true;
            return false;

        }

        /// <summary>
        /// Удаляет все книги по автору
        /// </summary>
        /// <param name="name">имя автора</param>
        /// <param name="surname">фамилия автора</param>
        /// <param name="books">список книг в библиотеке</param>
        /// <returns>возвращает true при успешном удалении</returns>
        public static bool RemoveBooksByAuthor(string name, string surname, List<Book> books)
        {
            
            Author author = new Author(name, surname);
            int initSize = books.Count;
            for(int i=0; i<books.Count; )
            {
                if (books[i].GetAuthor().Equals(author))
                {
                    books.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            if (initSize != books.Count)
            {
                return true;
            }
            return false;
        }
    }
}
