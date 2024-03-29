﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using TinyERP4Fun.Data;
using TinyERP4Fun.ModelServises;

namespace TinyERP4Fun.Scheduler
{
    public sealed class TimedHostedServiceUpdateCurrencies : IHostedService, IDisposable
    {
        private readonly ILogger _logger;
        private Timer _timer;


        public TimedHostedServiceUpdateCurrencies(ILogger<TimedHostedServiceUpdateCurrencies> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is starting.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromMinutes(60));

            return Task.CompletedTask;
        }

         private void DoWork(object state)
        {
            _logger.LogInformation("Timed Background Service is working.");
            var options = DefaultContextOptions.GetOptions();
            using (var context = new DefaultContext(options))
            {
                var _updateCurrencyRatesService = new UpdateCurrencyRatesService(context);
                Task updateRates = _updateCurrencyRatesService.UpdateBYNVoid();
                Task.WaitAll(updateRates);
            }


        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Background Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
