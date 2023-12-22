﻿using Microsoft.AspNetCore.Mvc;
using Services;

namespace Presentation.Controllers;

[ApiController]
[Route("api/books")]
public class BooksV4Controller : ControllerBase
{
    private readonly IServiceManager _manager;

    public BooksV4Controller(IServiceManager manager)
    {
        _manager = manager;
    }
}
