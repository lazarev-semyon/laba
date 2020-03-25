using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorLibrary
{
    /// <summary>
    /// Класс содержит методы для работы с библиотекой
    /// </summary>
    public class ChangeBookNameUtil
    {
        /// <summary>
        /// Изменяет название книги
        /// </summary>
        /// <param name="book">книга, в которой будет изменено название</param>
        /// <param name="name">новое название книги</param>
        public static void ChangeBookName(Book book, string name)
        {
            book.SetName(name);
        }

        
    }
}
