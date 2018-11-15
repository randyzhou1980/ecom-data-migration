using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DMService.Neto.Repo;
using DMService.WooCommerce.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WooCommerce.DM.API.Model;

namespace WooCommerce.DM.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Constructor
        private readonly IWCommServiceRepo _wcommRepo;
        private readonly INetoServiceRepo _netoRepo;
        public CustomerController(IWCommServiceRepo wcommRepo, INetoServiceRepo netoRepo)
        {
            _wcommRepo = wcommRepo;
            _netoRepo = netoRepo;
        }
        #endregion

        [HttpPost]
        [Route("customersToNeto")]
        [ProducesResponseType(typeof(WooCommerceResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ConvertCustomersToNetoAsync()
        {
            try
            {
                var wcommCustomers = await _wcommRepo.CustomerService.GetCustomersAsync();

                //var netoCustomers = new List<DMEntity.Neto.Customer>();

                //foreach (var magentoCustomer in magentoCustomers)
                //{
                //    //bcommCustomer.CustomerAddresses = await _bCommRepo.CustomerService.GetCustomerAddressesAsync(bcommCustomer.Id);

                //    //bcommCustomer.CustomerGroups = await _bCommRepo.CustomerService.GetCustomerGroupByIdAsync(bcommCustomer.Customer_group_id);

                //    //netoCustomers.Add(_netoRepo.CustomerConverter.ConvertToCustomer(bcommCustomer));
                //}

                ////var response = await _netoRepo.CustomerService.AddCustomersAsync(netoCustomers);

                ////var result = new BigCommerceResponse();
                ////result.Status = response.Status == "Success";
                ////result.TotalProcessed = bcommCustomers.Count();
                ////result.Succeed = response.UserNames != null ? response.UserNames.Count() : 0;
                ////result.Errors = response.Errors;

                ////return Ok(result);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}