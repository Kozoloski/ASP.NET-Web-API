using Homework2.Models;

namespace Homework2
{
    public static class StaticDb
    {
        public static List<Book> Books = new List<Book>
        {
            new Book()
            {
              Author = "Stephen King",
              Title = "The Shining"
            },
            new Book()
            {
              Author = "Isaac Asimov",
              Title = "Fondation"
            },
             
        };

    }
}
