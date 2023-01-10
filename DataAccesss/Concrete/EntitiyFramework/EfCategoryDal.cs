using Core.DataAccess.EntitiyFramework;
using DataAccesss.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccesss.Concrete.EntitiyFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal 
    {
    }
}
