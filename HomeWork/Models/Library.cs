using HomeWork.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Library
    {
        public int BookLimit { get; set; }
        public List<Book> Books { get; set; }

        public Library(int bookLimit)
        {
            BookLimit = bookLimit;  
            Books = new List<Book>(); 
        }

        public void AddBook(Book book)
        {
            if (Books.Count >= BookLimit)
                throw new CapacityLimitException("Limit ashildi.. ");
            Books.Add(book);    
        }

        public Book GetBookById(int? id)
        {
            if (id == null) throw new NullReferenceException("id null ola bilmez...");

            return Books.Find(x => x.Id == id);
        }

        public void RemoveById(int? id)
        {
            if (id == null) throw new NullReferenceException("id null ola bilmez...");

            var x = Books.Find(x => x.Id == id);

            if (x == null) throw new NotFoundException();
            else  Books.Remove(x);
        }

        
    }
}
