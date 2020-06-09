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
        public IActionResult Get()
        {
            var allCategories = categoryManager.GetAllCategory().ToArray();
            return Ok(allCategories);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetById(int id)
        {
            var category = categoryManager.GetSingleCategory(id);
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Post(Category category)
        {
            try
            {
                return Ok(categoryManager.AddCategory(category));
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(Category category)
        {
            var result = categoryManager.DeleteCategory(category);
            if (result)
                return Ok();
            else return BadRequest();
        }
    }
}