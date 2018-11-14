using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BigCommerce.DM.API.Model;
using DMService.BigCommerce.Repo;
using DMService.Neto.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigCommerce.DM.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region Constructor
        private readonly IBCommServiceRepo _bCommRepo;
        private readonly INetoServiceRepo _netoRepo;
        public CategoryController(IBCommServiceRepo bCommRepo, INetoServiceRepo netoRepo)
        {
            _bCommRepo = bCommRepo;
            _netoRepo = netoRepo;
        }
        #endregion

        [HttpPost]
        [Route("categoriesToNeto")]
        [ProducesResponseType(typeof(BigCommerceResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ConvertCategoriesToNetoAsync()
        {
            try
            {
                var bcommCategories = await _bCommRepo.CategoryService.GetCategoriesAsync();

                var netoCategories = _netoRepo.CategoryConverter.ConvertToCategory(bcommCategories);

                var response = await _netoRepo.CategoryService.AddCategoriesAsync(netoCategories);

                var result = new BigCommerceResponse();
                result.Status = response.Status == "Success";
                result.TotalProcessed = bcommCategories.Count();
                result.Succeed = response.CategoryIDs != null ? response.CategoryIDs.Count() : 0;
                result.Errors = response.Errors;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}