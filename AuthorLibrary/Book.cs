using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorLibrary
{
    /// <summary>
    /// Класс представляет книгу автора
    /// </summary>
    public class Book
    {
        string name; //название книги
        Author author; //автор книги
        string bookType; //жанр книги

        /// <summary>
        /// Конструктор инициализирует поля класса Book
        /// </summary>
        /// <param name="name">название книги</param>
        /// <param name="bookType">жанр книги</param>
        /// <param name="author">автор книги</param>
        public Book(string name, string bookType, Author author)
        {
            this.name = name;
            this.author = author;
            this.bookType = bookType;
        }

        /// <summary>
        /// Геттер для поля name
        /// </summary>
        /// <returns>возвращает название книги</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Геттер для поля bookType
        /// </summary>
        /// <returns>Возвращает жанр книги</returns>
        public string GetBookType()
        {
            return bookType;
        }

        /// <summary>
        /// Геттер для поля author
        /// </summary>
        /// <returns>возвращает автора книги</returns>
        public Author GetAuthor()
        {
            return author;
        }
        /// <summary>
        /// Проверяет на равенство две книги
        /// </summary>
        /// <param name="obj">Книга для сравнения</param>
        /// <returns>возвращает true, если у обоих книг совпадают название, жанр и авторы</returns>
        public override bool Equals(object obj)
        {
            if(obj == this)
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
                return false;

            Book book = (Book)obj;
            return name == book.GetName() && bookType == book.GetBookType() && author.Equals(book.GetAuthor());
        }

        /// <summary>
        /// Формирует строковое описание книги, включающую название книги, жанр и автора
        /// </summary>
        /// <returns>возвращает сформированную строку</returns>
        public override string ToString()
        {
            return "Книга: " + name + ", Жанр: " + bookType + ", " + author.ToString();
        }

    }
}
