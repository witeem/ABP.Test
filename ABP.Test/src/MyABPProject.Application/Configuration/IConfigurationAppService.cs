using System.Threading.Tasks;
using MyABPProject.Configuration.Dto;

namespace MyABPProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
