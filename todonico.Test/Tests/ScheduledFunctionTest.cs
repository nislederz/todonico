using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using todonico.Functions.Functions;
using todonico.Test.Helpers;
using Xunit;

namespace todonico.Test.Tests
{
    public class ScheduledFunctionTest
    { 
        [Fact]
        public void ScheduledFunction_Should_Log_Message() 
        {
            //Arrenge
            MockCloudTableTodos mockTodo = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreaccount1/reports"));
            ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);

            //Act
            ScheduledFunction.Run(null, mockTodo, logger);
            string message = logger.Logs[0];

            //Assert
            Assert.Contains("Deleting complete", message);
        }
    }
}
