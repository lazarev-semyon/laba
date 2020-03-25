using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorLibrary
{
    /// <summary>
    /// Класс содержит методы для работы с библиотекой
    /// </summary>
    public class ChangeBookNameAndTypeUtil
    {
        /// <summary>
        /// Изменяет название и жанр книги
        /// </summary>
        /// <param name="book">книга, в которой будет изменен жанр</param>
        /// <param name="name">новое название книги</param>
        /// <param name="bookType">новый жанр книги</param>
        public static void ChangeBookNameAndType(Book book, string name, string bookType)
        {
            book.SetName(name);
            book.SetBookType(bookType);
        }

        
    }
}
