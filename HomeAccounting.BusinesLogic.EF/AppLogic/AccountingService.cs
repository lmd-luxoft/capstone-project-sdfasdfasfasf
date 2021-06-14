using HomeAccounting.BusinesLogic.EF.Domain;
using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.BusinessLogic.Contract.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.BusinesLogic.EF.AppLogic
{
    public class AccountingService : IAccountingService
    {
        DomainContext _ctx;

        public AccountingService(DomainContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateAccount(AccountModel account)
        {
            Domain.Account newAccount = null;

            switch(account.Type)
            {
                case AccountType.Simple:
                    newAccount = CreateSimpleAccount(account);
                    break;
                case AccountType.Cash:
                    newAccount = CreateCash(account);
                    break;
                case AccountType.Deposit:
                    CreateDeposit(account);
                    break;
                case AccountType.Property:
                    CreateProperty(account);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("bal type account");
            }
        }

        private void CreateProperty(AccountModel account)
        {
            Property p = new Property()
            {
                Balance = account.Amount,
                CreationDate = DateTime.Now,
                Location = "Moscow",
                Title = (PropertyType)account.Params[0]
            };

            _ctx.Properties.Add(p);
        }
        private void CreateDeposit(AccountModel account)
        {
            Bank b = _ctx.Banks.Where(p => p.BIK == (String)account.Params[0]).FirstOrDefault();
            Deposit d = new Deposit()
            {
                Balance = account.Amount,
                CreationDate = DateTime.Now,
                Bank = new Bank()
                {
                    BIK = (String)account.Params[0],
                    CorrespondedAccount = (String)account.Params[1],
                    Title = (String)account.Params[2]
                },
                Title = account.Title,
                Persent = (decimal)account.Params[3]
            };

            _ctx.Deposites.Add(d);
        }

        private Domain.Account CreateCash(AccountModel account)
        {
            throw new NotImplementedException();
        }

        private Domain.Account CreateSimpleAccount(AccountModel account)
        {
            throw new NotImplementedException();
        }
    }
}
