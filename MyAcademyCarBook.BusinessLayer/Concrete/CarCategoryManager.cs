using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
    public class CarCategoryManager : ICarCategoryService
    {
        private readonly ICarCategoryDal carCategoryDal;

        public CarCategoryManager(ICarCategoryDal carCategoryDal)
        {
            this.carCategoryDal = carCategoryDal;
        }

        public void TDelete(CarCategory entity)
        {
            this.carCategoryDal.Delete(entity);
        }

        public CarCategory TGetById(int id)
        {
            return this.TGetById(id);
        }

        public List<CarCategory> TGetListAll()
        {
            return this.TGetListAll();
        }

        public void TInsert(CarCategory entity)
        {
            this.carCategoryDal.Insert(entity);
        }

        public void TUpdate(CarCategory entity)
        {
            this.carCategoryDal.Update(entity);
        }
    }
}
