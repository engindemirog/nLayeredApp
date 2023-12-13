using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IProductService
{
    Task<IPaginate<GetListProductResponse>> GetListAsync(PageRequest pageRequest);
    Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest);
}