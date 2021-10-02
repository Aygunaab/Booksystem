using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksystem
{
    class Book
    {
        static int counter = 0;
        public Book()
        {
            this.Id = ++counter;
        }
        public Book(string name,double price,int pageacount,Author author)
            :this()
        {
            this.Name = name;
            this.Price = price;
            this.PageCount = pageacount;
            this.Author = author;

        }
        public int Id { get;private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PageCount { get; set; }
        public Author Author{ get; set; }
        public override string ToString()
        {
            return $"{Id}. {Name}. {PageCount}. {Price}. {Author.Name} {Author.SurName}";
        }
    }
}
