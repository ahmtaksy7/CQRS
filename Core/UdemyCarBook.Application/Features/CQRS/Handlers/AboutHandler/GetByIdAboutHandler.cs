using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Queries.AboutQuery;
using UdemyCarBook.Application.Features.CQRS.Results.AboutResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandler;

public class GetByIdAboutHandler
{
    private readonly IRepository<About> _repository;

    public GetByIdAboutHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task<GetByIdAboutQueryResult> Handle(GetByIdAboutQuery query)
    {
        var value=await _repository.GetAsync(query.Id);
        return new GetByIdAboutQueryResult { AboutID = value.AboutID, Description = value.Description, ImageUrl = value.ImageUrl, Title = value.Title };

    }
}
