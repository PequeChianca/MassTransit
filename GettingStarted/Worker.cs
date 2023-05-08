using System;
using Microsoft.Extensions.Hosting;


namespace GettingStarted
{
    public class Worker : BackgroundService
    {
        readonly IBus _bus;

        protected override Task ExecuteAsync(CancellationToken cancellationToken)
        {

        }

    }
}
