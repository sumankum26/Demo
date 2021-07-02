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
        private static readonly List<Demo.Model.User> Data = new List<Model.User>
        {            
                new Model.User{ UserId = "1", FirstName ="Tom", LastName="Cruise",Role="Actor",Location="New York",IsActive=true}
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IList<Demo.Model.User> Get()
        {
            return Data;
        }


    }
}
