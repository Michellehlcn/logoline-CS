using System;
using System.Collections.Generic;
using System.Text;

namespace logoline_CS.Models
{
    /// <summary>
    /// Response Model for use with LogoLine's WebAPI
    /// </summary>
    public class ResponseToken
    {
        private string code = "";
        private string message = "";
        private bool authenticated = false;
        private string ipAddress = "";
        private bool isTest = false;
        private DateTime date = DateTime.Now;
        private decimal? version;
        private object data = null; // The object returned changes based on function called.

        /// <summary>
        /// The Code associated with the status of your request. 1 is success.
        /// </summary>
        public string Code { get => code; set => code = value; }

        /// <summary>
        /// Text Message associated with the status of your request.
        /// </summary>
        public string Message { get => message; set => message = value; }

        /// <summary>
        /// Did your request pass authentication.   
        /// </summary>
        public bool Authenticated { get => authenticated; set => authenticated = value; }

        /// <summary>
        /// Ip address your request was called from. 
        /// </summary>
        public string IpAddress { get => ipAddress; set => ipAddress = value; }

        /// <summary>
        /// Is the returned repsonse test data.
        /// </summary>
        public bool IsTest { get => isTest; set => isTest = value; }

        /// <summary>
        /// Datetime of request.
        /// </summary>
        public DateTime Date { get => date; set => date = value; }

        /// <summary>
        /// The api version number.
        /// </summary>
        public decimal? Version { get => version; set => version = value; }

        /// <summary>
        /// The resulting data of the given request. This will be a json formatted text of the relevant data model.
        /// </summary>
        public object Data { get => data; set => data = value; }

    }
}
