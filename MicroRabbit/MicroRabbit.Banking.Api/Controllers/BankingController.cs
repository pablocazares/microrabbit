using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ILogger<BankingController> _logger;

        public BankingController(IAccountService acccountService, ILogger<BankingController> logger)
        {
            _accountService = acccountService;
            _logger = logger;
        }

        // GET api/banking
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            var accounts = _accountService.GetAccounts();
            return accounts;
        }
    }
}
