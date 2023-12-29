using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class Price
    {
        public int PriceId { get; set; }
        public string? PriceType { get; set; }
        public int PriceValue { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
