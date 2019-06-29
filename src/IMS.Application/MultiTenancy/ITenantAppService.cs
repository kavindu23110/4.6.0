using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IMS.MultiTenancy.Dto;

namespace IMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

