using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.Datasource.Contract
{
    public interface IRepository
    {
        void AddAccount(DBAccount account);

        void GetAccountById(DBAccount account);
    }
}
