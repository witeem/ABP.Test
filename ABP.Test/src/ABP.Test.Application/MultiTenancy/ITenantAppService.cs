using Abp.Application.Services;
using ABP.Test.MultiTenancy.Dto;

namespace ABP.Test.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

