//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backup.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserAccounts = new HashSet<UserAccount>();
            this.UserLogs = new HashSet<UserLog>();
        }
    
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public string Email { get; set; }
        public int UserTypeId { get; set; }
    
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
        public virtual ICollection<UserLog> UserLogs { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
