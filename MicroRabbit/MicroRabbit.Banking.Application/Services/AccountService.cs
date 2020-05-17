using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountrepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountrepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountrepository.GetAccounts();
        }
    }
}
