using SLP.Common.GuidGenerator;
using System;

namespace SMP.ApplicationContext
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            Id = SequentialGuid.Create(SequentialGuidType.SequentialAtEnd);
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }
        public Guid Id { get; protected set; }
        public DateTime? CreateDate { get; protected set; }
        public DateTime? UpdateDate { get; protected set; }
    }
}
