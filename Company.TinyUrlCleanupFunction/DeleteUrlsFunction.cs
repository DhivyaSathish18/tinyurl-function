using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using TinyUrlCleanupFunction.Data;

namespace Company.TinyUrlCleanupFunction;

public class DeleteUrlsFunction
{
    private readonly ILogger _logger;
    private readonly AppDbContext _db;

    public DeleteUrlsFunction(ILoggerFactory loggerFactory, AppDbContext db)
    {
        _logger = loggerFactory.CreateLogger<DeleteUrlsFunction>();
        _db = db;
    }

    [Function("DeleteUrls")]
    public async Task Run(
            [TimerTrigger("0 0 * * * *")] TimerInfo timer)
    {
        _logger.LogInformation("Cleanup job started");

        var oldUrls = await _db.ShortUrls
            .Where(x =>
                x.IsPrivate &&
                x.CreatedAt < DateTime.UtcNow.AddHours(-1))
            .ToListAsync();

        if (oldUrls.Any())
        {
            _db.ShortUrls.RemoveRange(oldUrls);
            await _db.SaveChangesAsync();
        }

        _logger.LogInformation($"Deleted {oldUrls.Count} URLs");
    }
}