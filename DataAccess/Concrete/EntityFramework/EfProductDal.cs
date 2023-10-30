using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
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
        
    }
}
