using System.Threading.Tasks;
using Abp.Application.Services;
using ABP.Test.Sessions.Dto;

namespace ABP.Test.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
