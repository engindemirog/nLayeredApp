using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfCategoryDal : EfRepositoryBase<Category, int, NorthwindContext>, ICategoryDal
{
    public EfCategoryDal(NorthwindContext context) : base(context)
    {
    }
}
