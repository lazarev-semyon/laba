using AuthorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateBookTest()
        {
            Book expectedBook = new Book("book1", "comedy", new Author("name1", "surname1"));
            Book actualBook = Util.CreateBook("book1", "comedy", "name1", "surname1");
            Assert.AreEqual(expectedBook, actualBook);
        }

        [TestMethod]
        public void GetBookListByAuthorTest()
        {
            Library library = new Library();
            library.Add(new Book("book1", "comedy", new Author("name1", "surname1")));
            library.Add(new Book("book2", "comedy", new Author("name1", "surname1")));
            library.Add(new Book("book3", "comedy", new Author("name2", "surname2")));

            List<Book> expectedList = new List<Book>();
            expectedList.Add(new Book("book1", "comedy", new Author("name1", "surname1")));
            expectedList.Add(new Book("book2", "comedy", new Author("name1", "surname1")));

            List<Book> actualList = Util.GetBookListByAuthor("name1", "surname1", library.GetBooks());

            if(expectedList.Count != actualList.Count)
            {
                Assert.Fail();
            }
            for(int i=0; i<actualList.Count; i++)
            {
                Assert.AreEqual(expectedList[i], actualList[i]);
            }
            
            
        }
    }
}
