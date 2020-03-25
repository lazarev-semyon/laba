using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorLibrary
{
    /// <summary>
    /// Класс представляет автора книги
    /// </summary>
    public class Author
    {

        string name;
        string surname;

        /// <summary>
        /// Констрктор иницилизирует поля класса
        /// </summary>
        /// <param name="name">имя автора</param>
        /// <param name="surname">фамилия автора</param>
        public Author(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        /// <summary>
        /// Геттер для поля name
        /// </summary>
        /// <returns>возвращает имя автора</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Геттер для поля surname
        /// </summary>
        /// <returns>возвращает фамилию автора</returns>
        public string GetSurname()
        {
            return surname;
        }

        /// <summary>
        /// Проверяет на равенство двух авторов
        /// </summary>
        /// <param name="obj">Автор, который будет сравниваться с первым</param>
        /// <returns>возвращает true, если имя и фамилия авторов совпадает</returns>
        public override bool Equals(object obj)
        {
            if(this == obj)
            {
                return true;
            }
            if(obj.GetType() != this.GetType())
            {
                return false;
            }
            Author author = (Author)obj;
            return name == author.GetName() && surname == author.GetSurname();
            
        }

        /// <summary>
        /// Формирует строку, содержащую информацию об авторе
        /// </summary>
        /// <returns>возвращает сформированную строку</returns>
        public override string ToString()
        {
            return "Автор: " + surname + " " + name;
        }
    }
}
