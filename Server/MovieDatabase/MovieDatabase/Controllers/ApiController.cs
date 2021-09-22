﻿namespace MovieDatabase.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        protected const string PathSeparator = "/";
        protected const string Id = "{id}";
    }
}
