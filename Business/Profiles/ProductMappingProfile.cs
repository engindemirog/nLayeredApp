using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles;

public class ProductMappingProfile:Profile
{
    public ProductMappingProfile()
    {
        CreateMap<Product, GetListProductResponse>()
            .ForMember(destinationMember: p => p.CategoryName,
                       memberOptions: opt => opt.MapFrom(p => p.Category.Name))
            .ReverseMap();

        CreateMap<IPaginate<Product>, Paginate<GetListProductResponse>>();
        CreateMap<Product, CreateProductRequest>().ReverseMap();
        CreateMap<Product, CreatedProductResponse>().ReverseMap();
    }
    
}
