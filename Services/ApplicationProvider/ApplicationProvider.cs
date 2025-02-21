using AppStore.Models;

namespace AppStore.Services;

public class ApplicationProvider : IApplicationProvider
{
    private List<Application> _applications = new ()
        {
            new Application() { DisplayName = "App Store", Author = "NinjaDesk.App", Version = "0.0.0" },
            new Application() { DisplayName = "Caculator", Author = "NinjaDesk.App", Version = "0.0.0" },
            new Application() { DisplayName = "Settings", Author = "NinjaDesk.App", Version = "0.0.0" },
            new Application() { DisplayName = "News", Author = "NinjaDesk.App", Version = "0.0.0" },
            new Application() { DisplayName = "Game", Author = "NinjaDesk.App", Version = "0.0.0" },
        };

    public Task<IEnumerable<Application>> GetApplicationsAsync(int start, int count)
    {
        var apps = new List<Application>();
        if (start < 20)
        {
            while (apps.Count < count)
            {
                apps.AddRange(_applications);
            }
        }
        else
        {
            count = 0;
        }
        return Task.FromResult(apps.Take(count));
    }
}