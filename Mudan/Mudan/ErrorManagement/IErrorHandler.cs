using System;

namespace Mudan.ErrorManagement
{
    /// <summary>
    /// Uncaught exception handler
    /// </summary>
    public interface IErrorHandler
    {
        /// <summary>
        /// Handles an exception.
        /// </summary>
        /// <param name="exception">The exception to handle.</param>
        void Handle(Exception exception);
    }
}
