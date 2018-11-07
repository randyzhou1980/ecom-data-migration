using BigCommerce.DM.API.Model;
using DMService.BigCommerce.Repo;
using DMService.Neto.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BigCommerce.DM.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Constructor
        private readonly IBCommServiceRepo _bCommRepo;
        private readonly INetoServiceRepo _netoRepo;
        public CustomerController(IBCommServiceRepo bCommRepo, INetoServiceRepo netoRepo)
        {
            _bCommRepo = bCommRepo;
            _netoRepo = netoRepo;
        }
        #endregion

        [HttpPost]
        [Route("customersToNeto")]
        [ProducesResponseType(typeof(CustomerResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ConvertCustomersToNetoAsync()
        {
            try
            {
                var bcommCustomers = await _bCommRepo.CustomerService.GetCustomersAsync();

                var netoCustomers = new List<DMEntity.Neto.Customer>();

                foreach(var bcommCustomer in bcommCustomers)
                {
                    bcommCustomer.CustomerAddresses = await _bCommRepo.CustomerService.GetCustomerAddressesAsync(bcommCustomer.Id);

                    bcommCustomer.CustomerGroups = await _bCommRepo.CustomerService.GetCustomerGroupByIdAsync(bcommCustomer.Customer_group_id);

                    netoCustomers.Add(_netoRepo.CustomerConverter.ConvertToCustomer(bcommCustomer));
                }

                var response = await _netoRepo.CustomerService.AddCustomersAsync(netoCustomers);

                var result = new CustomerResponse();
                result.Status = response.Status == "Success";
                result.TotalProcessed = bcommCustomers.Count();
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