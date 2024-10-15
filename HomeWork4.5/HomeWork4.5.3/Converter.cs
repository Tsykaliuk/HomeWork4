using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._2
{
    public class Converter
    {
        public decimal EurToUah { get; set; }
        public decimal UsdToUah { get; set; }

        public Converter(decimal EurToUah, decimal UsdToUah)
        {
            this.EurToUah = EurToUah;
            this.UsdToUah = UsdToUah;
        }
        public decimal ConvertHrnToDollar(decimal hryvnia)
        {
            return hryvnia / UsdToUah;
        }
        public decimal ConvertDollarToHrn(decimal hryvnia)
        {
            return hryvnia * UsdToUah;
        }
        public decimal ConvertHrnToEuro(decimal hryvnia)
        {
            return hryvnia / EurToUah;
        }
        public decimal ConvertEuroToHrn(decimal hryvnia)
        {
            return hryvnia * EurToUah;
        }

    }
}
