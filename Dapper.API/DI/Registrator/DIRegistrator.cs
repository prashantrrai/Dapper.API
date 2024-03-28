
using Dapper.API.Data.Implementations.Base;
using Dapper.API.Data.Implementations.CompanyRepository;
using Dapper.API.Data.Interfaces.Base;
using Dapper.API.Data.Interfaces.CompanyRepository;
using Dapper.API.Service.Implementations;
using Dapper.API.Service.Interfaces;
using DryIoc;

namespace Dapper.API.DI.Registrator
{
    public class DIRegistrator
    {
        public DIRegistrator(IRegistrator registrator)
        {
            // Services
            registrator.Register<ICompanyService, CompanyService>();

            //Repositories
            registrator.Register<IBaseRepository, BaseRepository>();
            registrator.Register<ICompanyRepository, CompanyRepository>();
        }
    }
}
