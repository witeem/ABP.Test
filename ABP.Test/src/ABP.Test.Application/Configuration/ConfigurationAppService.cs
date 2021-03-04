using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABP.Test.Configuration.Dto;

namespace ABP.Test.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
