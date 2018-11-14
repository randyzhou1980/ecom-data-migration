using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DMService.Neto.Repo;
using DMService.Shopify.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopify.DM.API.Model;

namespace Shopify.DM.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Constructor
        private readonly IShopifyServiceRepo _shopifyRepo;
        private readonly INetoServiceRepo _netoRepo;
        public CustomerController(IShopifyServiceRepo shopifyRepo, INetoServiceRepo netoRepo)
        {
            _shopifyRepo = shopifyRepo;
            _netoRepo = netoRepo;
        }
        #endregion

        [HttpPost]
        [Route("customersToNeto")]
        [ProducesResponseType(typeof(ShopifyResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ConvertCustomersToNetoAsync()
        {
            try
            {
                var shopifyCustomers = await _shopifyRepo.CustomerService.GetCustomersAsync();

                var netoCustomers = _netoRepo.CustomerConverter.ConvertToCustomers(shopifyCustomers);

                var response = await _netoRepo.CustomerService.AddCustomersAsync(netoCustomers);

                var result = new ShopifyResponse();
                result.Status = response.Status == "Success";
                result.TotalProcessed = shopifyCustomers.Count();
                result.Succeed = response.UserNames != null ? response.UserNames.Count() : 0;
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