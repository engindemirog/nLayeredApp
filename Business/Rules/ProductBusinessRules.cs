using Business.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;

namespace Business.Rules;

public class ProductBusinessRules : BaseBusinessRules
{
    private readonly IProductDal _productDal;

    public ProductBusinessRules(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public async Task EachCategoryCanContainMax20Products(int categoryId)
    {
        var result = await _productDal.GetListAsync(
            predicate: p => p.CategoryId == categoryId,
            size : 25
            );

        if (result.Count >= 20)
        {
            throw new BusinessException(BusinessMessages.CategoryProductLimit);
        }

    }
}
