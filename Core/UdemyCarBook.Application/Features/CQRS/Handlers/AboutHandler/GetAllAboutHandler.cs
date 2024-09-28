using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Results.AboutResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandler;

public class GetAllAboutHandler
{
    private readonly IRepository<About> _repository;

    public GetAllAboutHandler(IRepository<About> repository)
    {
        _repository = repository;
    }
    public async Task<List<GetAllAboutQueryResult>> Handle()
    {
       var value= await _repository.GetAllAsync();
        return  value.Select(x=>new GetAllAboutQueryResult { AboutID=x.AboutID,Title = x.Title,Description=x.Description,
            ImageUrl=x.ImageUrl})
            .ToList();
    }
}
