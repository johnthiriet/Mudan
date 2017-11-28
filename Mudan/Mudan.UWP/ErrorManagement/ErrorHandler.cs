using System;
using System.Diagnostics;
using Mudan.ErrorManagement;

namespace Mudan.UWP.ErrorManagement
{
    /// <inheritdoc />
    public class ErrorHandler : IErrorHandler
    {
        /// <inheritdoc />
        public void Handle(Exception exception)
        {
            Debug.WriteLine($"ErrorHandler : {exception}");
        }
    }
}
