using CommunityToolkit.Mvvm.Input;
using GeoCalc.Models;

namespace GeoCalc.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}