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
    
    public partial class BackupFileState
    {
        public BackupFileState()
        {
            this.BackupFiles = new HashSet<BackupFile>();
        }
    
        public int Id { get; set; }
        public string State { get; set; }
    
        public virtual ICollection<BackupFile> BackupFiles { get; set; }
    }
}
