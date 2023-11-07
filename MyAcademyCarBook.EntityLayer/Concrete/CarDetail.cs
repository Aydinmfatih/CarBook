using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class CarDetail
    {
        public int CarDetailId { get; set; }
        public string Description { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
