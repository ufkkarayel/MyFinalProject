﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<ProductDetailDto> GetProductDetails();
        List<Product> GetByUnitPrice(decimal min, decimal max);
        Product GetById(int productId);
        IResult Add(Product product);
    }
}
