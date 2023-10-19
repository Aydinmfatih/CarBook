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
    public class CarStatusManager : ICarStatusService
    {
        private readonly ICarStatusDal _carStatusDal;
        
        public CarStatusManager(ICarStatusDal carStatusDal)
        {
            _carStatusDal = carStatusDal;
        }

        public void TDelete(CarStatus entity)
        {
           _carStatusDal.Delete(entity);
        }

        public CarStatus TGetById(int id)
        {
            return _carStatusDal.GetById(id);   
        }

        public List<CarStatus> TGetListAll()
        {
            return _carStatusDal.GetListAll();
        }

        public void TInsert(CarStatus entity)
        {
            _carStatusDal.Insert(entity);
        }

        public void TUpdate(CarStatus entity)
        {
            _carStatusDal.Update(entity);
        }
    }
}
