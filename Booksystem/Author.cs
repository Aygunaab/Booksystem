using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksystem
{
    class Author
    {
        static int counter = 0;
        public Author()
        {
            this.Id = ++counter;
        }
        public Author(string name, string surname)
            :this()
        {
            this.Name = name;
            this.SurName = surname;
        }
        public int Id { get;private set; }
        public  string Name { get; set; }
        public string SurName { get; set; }
        public override string ToString()
        {
            return $"{Name} {SurName}";
        }



    }
}
