using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPUser : ERPEditor
    {
        public ERPUser()
        {
            Username = Password = @"";
            Enabled = true;
        }

        public String Username { get; set; }
        public String Password { get; set; }
        public Boolean Enabled { get; set; }
    }
}
