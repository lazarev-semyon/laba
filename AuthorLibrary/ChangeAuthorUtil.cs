
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorLibrary
{
    /// <summary>
    /// Класс содержит методы для работы с библиотекой
    /// </summary>
    public class ChangeAuthorUtil
    {
        /// <summary>
        /// Изменяет автора
        /// </summary>
        /// <param name="book">книга, в которой будет заменен автор</param>
        /// <param name="authorName">имя автора книги</param>
        /// <param name="authorSurname">фамилия автора книги</param>
        public static void ChangeAuthor(Book book, string authorName, string authorSurname)
        {
            Author author = new Author(authorName, authorSurname);
            book.SetAuthor(author);
        }

        
    }
}
