using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DMService.Logger.Repo;
using Logging.DM.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Logging.DM.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        #region Constructor
        private readonly DMLogContext _context;
        public LogController(DMLogContext context)
        {
            _context = context;
        }
        #endregion

        [HttpGet]
        [Route("logs")]
        [ProducesResponseType(typeof(IEnumerable<EventLogs>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_context.EventLogs);
        }

        [HttpPost]
        [Route("errors")]
        [ProducesResponseType(typeof(IEnumerable<EventLogs>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetConvertErrors([FromBody]LogParameters parameters)
        {
            return Ok(_context.EventLogs
                .Where(l => l.Level == "Error" && string.IsNullOrWhiteSpace(l.Exception)
                    && (!parameters.StartDate.HasValue || parameters.StartDate.Value <= l.TimeStamp)
                    && (!parameters.EndDate.HasValue || parameters.EndDate.Value >= l.TimeStamp)));
        }
    }
}