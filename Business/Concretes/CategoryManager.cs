using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    IMapper _mapper;
    CategoryBusinessRules _categoryBusinessRules;

    public CategoryManager(ICategoryDal categoryDal, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
        _categoryBusinessRules = categoryBusinessRules;
    }

    public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
    {
        await _categoryBusinessRules.MaximumCategoryCountIsTen();

        Category category = _mapper.Map<Category>(createCategoryRequest);

        var createdCategory = await _categoryDal.AddAsync(category);

        CreatedCategoryResponse result = _mapper.Map<CreatedCategoryResponse>(createdCategory);

        return result;
    }
}
