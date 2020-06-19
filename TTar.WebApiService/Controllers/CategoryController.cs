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
            if (allCategories == null)
                return Problem(statusCode: 500);
            else
            {
                if (allCategories.Length > 0)
                    return Ok(allCategories);
                else
                    return NoContent();
            }
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetById(int id)
        {
            var category = categoryManager.GetSingleCategory(id);
            if (category != null && category.Id > 0)
                return Ok(category);
            else
                return BadRequest();
        }

        [HttpPost]
        public IActionResult Post(Category category)
        {
            try
            {
                Category addedCategory = categoryManager.AddCategory(category);
                return CreatedAtAction("Post", new { id = addedCategory.Id });
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

        [HttpPut]
        public IActionResult Update(Category category)
        {
            var updatedCategory = categoryManager.UpdateCategory(category);
            if (updatedCategory != null)
                return Ok();

            return BadRequest();
        }
    }
}