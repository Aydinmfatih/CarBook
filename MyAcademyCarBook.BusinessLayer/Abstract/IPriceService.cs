﻿using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Abstract
{
    public interface IPriceService:IGenericService<Price>
    {
        public List<Price> TGetPricesWithCar();
    }
}
