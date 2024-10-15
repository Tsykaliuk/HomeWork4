using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._4
{
    internal class Product
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PackagingDate { get; set; }
        public string CountryOfOrigin { get; set; }
        public Product(string name, int price, string countryOfOrigin, DateTime packagingDate, string description)
        {
            Name = name;
            Price = price;
            CountryOfOrigin = countryOfOrigin;
            PackagingDate = packagingDate;
            Description = description;
        }
    }
}
