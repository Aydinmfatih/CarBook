using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.Repositories;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.EntitiyFramework
{
    public class EfCarDetailDal : GenericRepository<CarDetail>, ICarDetailDal
    {
        public CarDetail GetCarDetailByCarId(int id)
        {
            var context = new CarBookContext();
            var values = context.CarDetails.Where(x => x.CarId == id).FirstOrDefault();
            return values;
        }

        public CarDetail GetCarDetailWithAuthor(int id)
        {
            var context = new CarBookContext();
            var values = context.CarDetails.Include(x=>x.AppUser).Where(y=>y.CarId == id).FirstOrDefault();
            return values;
        }
    }
}
