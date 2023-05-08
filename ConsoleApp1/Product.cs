using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Product
    {
        public int id;
        public string name;
        public double price;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        { get => name;
        set => name = value;}

        public double Price
        { get => price;
        set => price = value;}

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

    }
}
