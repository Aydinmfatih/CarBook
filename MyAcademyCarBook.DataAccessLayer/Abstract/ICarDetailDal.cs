using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.Abstract
{
    public interface ICarDetailDal:IGenericDal<CarDetail>
    {
        CarDetail GetCarDetailByCarId(int id);
    }
}
