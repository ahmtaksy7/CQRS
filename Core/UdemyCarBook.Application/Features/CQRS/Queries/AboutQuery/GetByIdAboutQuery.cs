﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Queries.AboutQuery;

public class GetByIdAboutQuery
{
    public int Id { get; set; }

    public GetByIdAboutQuery(int ıd)
    {
        Id = ıd;
    }

}
