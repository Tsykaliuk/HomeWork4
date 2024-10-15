using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._4
{
    internal class FoodProduct : Product
    {
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public FoodProduct(string name, int price, string countryOfOrigin, DateTime packagingDate, string description, DateTime expiryDate, int quantity, string unit)
                        : base(name, price, countryOfOrigin, packagingDate, description)
        {
            ExpiryDate = expiryDate;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
