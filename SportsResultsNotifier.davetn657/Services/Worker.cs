namespace SportsResultsNotifier.davetn657.Services;

public class Worker : BackgroundService
{
    private readonly IWebService _webService;
    private readonly ILogger _logger;

    public Worker(ILogger<Worker> logger, IWebService webService)
    {
        _logger = logger;
        _webService = webService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                _webService.GetTitle();
                var games = _webService.GetAllGameData();
            }


            await Task.Delay(60000, stoppingToken);
        }
    }
}