using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A login identity. Extends the editor identity <see cref="ERPEditor"/> with sign-in
    /// credentials (<see cref="Username"/>, <see cref="Password"/>) and an enabled flag.
    /// </summary>
    public class ERPUser : ERPEditor
    {
        /// <summary>Initialises a new instance with empty credentials, enabled by default.</summary>
        public ERPUser()
        {
            Username = Password = @"";
            Enabled = true;
        }

        /// <summary>Login user name.</summary>
        public String Username { get; set; }
        /// <summary>Login password / credential.</summary>
        public String Password { get; set; }
        /// <summary>Whether the user account is active.</summary>
        public Boolean Enabled { get; set; }
    }
}
