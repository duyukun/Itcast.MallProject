using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcast.Models
{
    public class Register
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Login
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Mobile
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Nickname
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public int Status { get; set; }

    }
}