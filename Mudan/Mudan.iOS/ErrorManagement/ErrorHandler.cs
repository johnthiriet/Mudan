using System;
using Mudan.ErrorManagement;

namespace Mudan.iOS.ErrorManagement
{
    /// <inheritdoc />
    public class ErrorHandler : IErrorHandler
    {
        /// <inheritdoc />
        public void Handle(Exception exception)
        {
            Console.WriteLine($"ErrorHandler : {exception.Message}");
        }
    }
}