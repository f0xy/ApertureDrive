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
    
    public partial class BackupFile
    {
        public int Id { get; set; }
        public int BackupFolderId { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public int BackupFileStateId { get; set; }
    
        public virtual BackupFolder BackupFolder { get; set; }
        public virtual BackupFileState BackupFileState { get; set; }
    }
}
