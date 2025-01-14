﻿using System;
using Microsoft.Extensions.Logging;
using Moq;
using Vehicles.ComponentTests.Core.LightBDD;

namespace OrderService.ComponentTests.Core.LightBDD;

public class LightBDDTestLogger<TCategoryName> : ILogger<TCategoryName>
{
    public IDisposable BeginScope<TState>(TState state) => new Mock<IDisposable>().Object;

    public bool IsEnabled(LogLevel logLevel) => false;

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
    {
        var message = formatter(state, exception);
        message.Log();
    }
}
