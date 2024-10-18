using HomeWork.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        double TotalInCome = 0;

        public Book(string authorName, int pageCount, string name, double price, int count) : base(name, price, count)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void Sell()
        {
            
            if (Count <= 0)
            {
                throw new ProductCountIsZeroException("Kitab bitib...");
            }
            Count--;
            TotalInCome += Price;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id : {Id} Name : {Name} Price : {Price} Count : {Count} TotalInCome : {TotalInCome} AuthorName : {AuthorName} PageCount : {PageCount}");
        }


    }
}
