using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankManager.Tests
{
    public abstract class BaseTest
    {
        public virtual void SetUpLogger()
        {
            Logging.Logger = Mock.Of<ILogger>();
        }
    }
}
