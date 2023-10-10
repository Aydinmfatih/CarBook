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
    public class CarStatusManager : ICarCategoryService
    {
        private readonly ICarCategoryDal _carStatusDal;
        
        public CarStatusManager(ICarCategoryDal carStatusDal)
        {
            _carStatusDal = carStatusDal;
        }

        public void TDelete(CarCategory entity)
        {
           _carStatusDal.Delete(entity);
        }

        public CarCategory TGetById(int id)
        {
            return _carStatusDal.GetById(id);   
        }

        public List<CarCategory> TGetListAll()
        {
            return _carStatusDal.GetListAll();
        }

        public void TInsert(CarCategory entity)
        {
            _carStatusDal.Insert(entity);
        }

        public void TUpdate(CarCategory entity)
        {
            _carStatusDal.Update(entity);
        }
    }
}
