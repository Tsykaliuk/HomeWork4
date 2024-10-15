using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._4
{
    internal class Book : Product
    {
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public List<string> Authors { get; set; }
        public Book(string name, int price, string countryOfOrigin, DateTime packagingDate, string description,
                    int numberOfPages, string publisher, List<string> authors)
                    : base(name, price, countryOfOrigin, packagingDate, description)
        {
            NumberOfPages = numberOfPages;
            Publisher = publisher;
            Authors = authors;
        }
    }
}
