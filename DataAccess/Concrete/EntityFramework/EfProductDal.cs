using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //IProductDal'a ne gerek var dediğimizde business IProducctdal'a bağımlıydı dolayısı ile dataaccessTE ef çalışıyoruz yarın başka bir şeyde çalışabiliriz 
    //buraya ürüne ait özel operasyonları koyucaz. yani ortak crudları efentityRepositoryBase'e koyucaz. producta özel operasyonları da IProductdal interfaceine yazıp implemenete edicez.
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList(); 
            }
        }
    }
}
