using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ttar.Business.Abstract;
using Ttar.Entities.Concrete;

namespace Ttar.WebApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryManager categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            this.categoryManager = categoryManager;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return categoryManager.GetAllCategory().ToArray();
        }
    }
}