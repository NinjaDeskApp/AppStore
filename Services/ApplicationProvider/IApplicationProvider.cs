using AppStore.Models;

namespace AppStore.Services;

public interface IApplicationProvider
{
    Task<IEnumerable<Application>> GetApplicationsAsync(int start, int count);
}