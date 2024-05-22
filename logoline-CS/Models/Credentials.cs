using System;
using System.Collections.Generic;
using System.Text;

namespace logoline_CS.Models
{
    /// <summary>
    /// Credentials for use with LogoLine's WebAPI 
    /// </summary>
    public class Credentials
    {
        private Guid id = Guid.Empty;
        private Guid key = Guid.Empty;

        /// <summary>
        /// GUID id of user
        /// </summary>
        public Guid Id { get => id; set => id = value; }

        /// <summary>
        /// GUID key of user
        /// </summary>
        public Guid Key { get => key; set => key = value; }
    }
}
