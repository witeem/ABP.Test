using System.Threading.Tasks;
using ABP.Test.Configuration.Dto;

namespace ABP.Test.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
