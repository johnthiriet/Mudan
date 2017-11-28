using System;
using Android.Util;
using Mudan.ErrorManagement;

namespace Mudan.Android.ErrorManagement
{
    /// <inheritdoc />
    public class ErrorHandler : IErrorHandler
    {
        /// <inheritdoc />
        public void Handle(Exception exception)
        {
            Log.Debug("ErrorHandler", exception.Message);
        }
    }
}