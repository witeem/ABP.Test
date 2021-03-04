using System.Threading.Tasks;
using Abp.Application.Services;
using ABP.Test.Authorization.Accounts.Dto;

namespace ABP.Test.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
