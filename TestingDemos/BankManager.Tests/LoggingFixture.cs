using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankManager.Tests
{
    public class LoggingFixture : IDisposable
    {
        public Mock<ILogger> LoggerFake { get; private set; }
        public LoggingFixture()
        {
            var logger = Mock.Of<ILogger>();
            LoggerFake = Mock.Get(logger);
            Logging.Logger = logger;
        }

        public void Dispose()
        {
            //Dispose logger
            Logging.Logger = null;
        }
    }

    [CollectionDefinition("Logging collection")]
    public class LoggingCollection : ICollectionFixture<LoggingFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
