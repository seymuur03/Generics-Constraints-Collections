using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal abstract class Product
    {
        private static int _id;
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        protected double TotalInCome { get; set; }

        public abstract void Sell();
        public abstract void ShowInfo();

        protected Product(string name, double price, int count)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
