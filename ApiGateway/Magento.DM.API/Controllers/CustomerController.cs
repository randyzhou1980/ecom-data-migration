using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMService.Magento.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Magento.DM.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Constructor
        private readonly IMagentoServiceRepo _magentoRepo;
        public CustomerController(IMagentoServiceRepo magentoRepo)
        {
            _magentoRepo = magentoRepo;
        }
        #endregion

        [HttpPost]
        [Route("customersToNeto")]
        //[ProducesResponseType(typeof(CustomerResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ConvertCustomersToNetoAsync()
        {
            try
            {
                await _magentoRepo.CustomerService.GetCustomersAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}