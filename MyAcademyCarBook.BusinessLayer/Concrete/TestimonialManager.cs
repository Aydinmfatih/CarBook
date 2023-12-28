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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonailDal;

        public TestimonialManager(ITestimonialDal testimonailDal)
        {
            _testimonailDal = testimonailDal;
        }

        public void TDelete(Testimonial entity)
        {
            _testimonailDal.Delete(entity);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonailDal.GetById(id);
        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonailDal.GetListAll();
        }

        public void TInsert(Testimonial entity)
        {
            _testimonailDal.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonailDal.Update(entity);
        }
    }
}
