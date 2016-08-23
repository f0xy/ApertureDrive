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
    
    public partial class UserAccount
    {
        public UserAccount()
        {
            this.BackupFolders = new HashSet<BackupFolder>();
        }
    
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AccountUniqueId { get; set; }
        public Nullable<long> AccountDataQuota { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<BackupFolder> BackupFolders { get; set; }
    }
}
