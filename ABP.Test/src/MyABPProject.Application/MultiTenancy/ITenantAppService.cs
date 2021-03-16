using Abp.Application.Services;
using MyABPProject.MultiTenancy.Dto;

namespace MyABPProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

