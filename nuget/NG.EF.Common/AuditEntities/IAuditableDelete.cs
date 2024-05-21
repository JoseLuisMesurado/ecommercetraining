﻿namespace NG.EF.Common.AuditEntities
{
    public interface IAuditableDelete
    {
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
