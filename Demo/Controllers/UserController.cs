using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static readonly List<Model.User> Data = new List<Model.User>
        {            
                new Model.User{ UserId = "1", FirstName ="Tom", LastName="Cruise",Role="Actor",Location="New York",IsActive=true},
                new Model.User{ UserId = "2", FirstName ="Chris", LastName="Pratt",Role="Actor",Location="Virginia",IsActive=true},
                new Model.User{ UserId = "3", FirstName ="Jennifer ", LastName="Aniston",Role="Actress",Location="California",IsActive=true},
                new Model.User{ UserId = "4", FirstName ="Ross", LastName="Geller",Role="Actor",Location="New York",IsActive=true},
                new Model.User{ UserId = "5", FirstName ="Rachel", LastName="Green",Role="Actress",Location="New York",IsActive=false}
        };

        //private readonly ILogger<UserController> _logger;

        //public UserController(ILogger<UserController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        public IList<Model.User> Get()
        {
            return Data;
        }

        [HttpPost]
        public Model.User Post(Model.User model)
        {
            Data.Add(model);
            return model;
        }

    }
}
