using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorLibrary
{
    /// <summary>
    /// Класс содержит методы для работы с библиотекой
    /// </summary>
    public class ChangeBookTypeUtil
    {
        /// <summary>
        /// Изменяет жанр книги
        /// </summary>
        /// <param name="book">книга, в которой будет изменен жанр</param>
        /// <param name="bookType">новый жанр книги</param>
        public static void ChangeBookTypeName(Book book, string bookType)
        {
             book.SetBookType(bookType);
        }

        
    }
}
