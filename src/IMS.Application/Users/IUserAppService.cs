using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IMS.Roles.Dto;
using IMS.Users.Dto;

namespace IMS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
