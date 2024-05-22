using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace logoline_CS.Models
{
    /// <summary>
    /// Request Model for use with LogoLine's WebAPI.
    /// </summary>
    public class RequestToken
    {

        /// <summary>
        /// Credentials for user calling API
        /// </summary>
        private Credentials credentials = new Credentials();

        /// <summary>
        /// Paramaters of current request.
        /// </summary>
        private Dictionary<string, string> arguments = new Dictionary<string, string>();

        /// <summary>
        /// Credentials for user calling API
        /// </summary>
        public Credentials Credentials { get => credentials; set => credentials = value; }

        /// <summary>
        /// Paramaters of current request.
        /// </summary>
        public Dictionary<string, string> Arguments { get => arguments; set => arguments = value; }

    }
}
