﻿#if NETSTANDARD2_0
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Hangfire.Annotations;
using Hangfire.Server;
using Microsoft.Extensions.Hosting;

namespace Hangfire
{
    public class HangfireHostedService : IHostedService, IDisposable
    {
        private readonly BackgroundJobServerOptions _options;
        private readonly JobStorage _storage;
        private readonly IEnumerable<IBackgroundProcess> _additionalProcesses;

        private IBackgroundProcessingServer _processingServer;

        public HangfireHostedService(
            [NotNull] JobStorage storage,
            [NotNull] BackgroundJobServerOptions options,
            [NotNull] IEnumerable<IBackgroundProcess> additionalProcesses)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _storage = storage ?? throw new ArgumentNullException(nameof(storage));
            _additionalProcesses = additionalProcesses;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _processingServer = new BackgroundJobServer(_options, _storage, _additionalProcesses);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _processingServer.Stop(false);
            return _processingServer.WaitAsync(cancellationToken).ContinueWith(StopAbort, CancellationToken.None);
        }

        public void Dispose()
        {
            _processingServer?.Dispose();
        }

        private void StopAbort(Task antecedent)
        {
            _processingServer.Stop(true);
        }
    }
}
#endif