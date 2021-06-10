using HomeAccounting.BusinessLogic;
using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.Datasource;
using HomeAccounting.Datasource.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.CompositionRoot
{
    public class AspNetApplicationBuilder : AbstractApplicationBuilder
    {
        //public AspNetApplicationBuilder(IServiceColletion service) : base(service)
        //{

        //}

        protected override void RegisterBusinessLogic()
        {
            //_services.AddTransient<IAccounting, AccountingService>();
        }

        protected override void RegisterDataSource()
        {
            //_services.AddTransient<IRepository, RepositoryBasePostgre>();
        }

        protected override void RegisterInfrastructure()
        {
            throw new NotImplementedException();
        }
    }
}
