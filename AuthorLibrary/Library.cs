using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorLibrary
{
    /// <summary>
    /// Класс описывает библиотеку книг
    /// </summary>
    public class Library
    {
        List<Book> books = new List<Book>();

        /// <summary>
        /// Добавляет книгу в библиотеку
        /// </summary>
        /// <param name="book">добавляемая книга</param>
        public void Add(Book book)
        {
            books.Add(book);
        }

        /// <summary>
        /// Геттер для поля books
        /// </summary>
        /// <returns>возвращает список книг библиотеки</returns>
        public List<Book> GetBooks()
        {
            return books;
        }


    }
}
