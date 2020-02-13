using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Game.Shared.Types;

namespace REST.Controllers
{
    [ApiController]
    public class SampleController : ControllerBase
    {
        /// <summary>
        /// This is how you write docstrings in .NET, notice
        /// how your editor should be generating a preview for
        /// the endpoint when you hover over it with your mouse.
        /// </summary>
        [HttpGet]
        [Route("api/sample/get_model")]
        public Model GetModel()
        {

        }
    }
}
