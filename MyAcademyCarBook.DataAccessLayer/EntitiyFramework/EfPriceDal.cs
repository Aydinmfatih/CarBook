using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.Repositories;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.EntitiyFramework
{
    public class EfPriceDal : GenericRepository<Price>, IPriceDal
    {
        public List<Price> GetPricesWithCar()
        {
            var context = new CarBookContext();
            var values = context.Prices.Include(x => x.Car).ThenInclude(y=>y.Brand).ToList();
            return values;
        }
    }
}
