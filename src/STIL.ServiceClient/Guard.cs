using System;

namespace STIL.ServiceClient
{
    /// <summary>
    /// Guard class.
    /// </summary>
    internal static class Guard
    {
        /// <summary>
        /// Validates against null or empty.
        /// </summary>
        /// <param name="value">Value to be validated.</param>
        /// <param name="parameterName">Name of parameter.</param>
        /// <param name="message">Message if validation fails.</param>
        /// <exception cref="ArgumentNullException"> if value is null.</exception>
        internal static void AgainstNullOrEmpty(string? value, string parameterName, string message = "")
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(parameterName, BuildMessage(message, parameterName));
            }
        }

        private static string BuildMessage(string message, string parameterName) => !string.IsNullOrEmpty(message) ? message : $"{parameterName} cannot be null or empty.";
    }
}
