using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksystem
{
    class AppManager
    {
         List<Author> Authors { get; set; } = new List<Author>();
        List<Book> Books { get; set; } = new List<Book>();

        public void AddAuthor(string name ,string surname)
        {
            Author aut = new Author(name, surname);

            this.Authors.Add(aut);
        }
        public void RemoveAuthor(string name)
        {
            Author aut = Authors.FirstOrDefault(a => a.Name == name);
            if (aut!=null)
            {
                this.Authors.Remove(aut);
            }
        }
        public Author GetAuthorById(int id)
        {
            Author aut = Authors.FirstOrDefault(a => a.Id == id);
            return aut;
        }


        public void AddBook(string name, double price, int pageacount, Author author)
        {
            Book book = new Book(name, price, pageacount, author);
            this.Books.Add(book);
        }
        public void RemoveBook(string name)
        {
            Book book = Books.FirstOrDefault(b => b.Name == name);
            if (book != null)
            {
                this.Books.Remove(book);
            }
        }
        public Book GetBookByName(string name)
        {
            Book book = Books.FirstOrDefault(b => b.Name == name);
            return book;
        }
        public List<Book> GetBooks()
        {
            return this.Books;
        }
    }
}
