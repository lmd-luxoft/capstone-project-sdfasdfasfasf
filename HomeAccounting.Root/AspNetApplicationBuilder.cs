using HomeAccounting.BusinessLogic;
using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.Datasource;
using HomeAccounting.Datasource.Contract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using HomeAccounting.BusinesLogic.EF.AppLogic;

namespace HomeAccounting.CompositionRoot
{
    public class AspNetApplicationBuilder : AbstractApplicationBuilder
    {
        public AspNetApplicationBuilder(IServiceCollection service) : base(service)
        {

        }

        protected override void RegisterBusinessLogic()
        {
            _services.AddTransient<IAccounting, BusinessLogic.AccountingService>();
        }

        protected override void RegisterDataSource()
        {
            _services.AddTransient<IRepository, RepositoryBasePostgre>();
            _services.AddDbContext<DomainContext> ();
        }

        protected override void RegisterInfrastructure()
        {
            throw new NotImplementedException();
        }
    }
}
