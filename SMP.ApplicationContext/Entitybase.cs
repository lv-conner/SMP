using SLP.Common.GuidGenerator;
using System;

namespace SMP.ApplicationContext
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Id = SequentialGuid.Create(SequentialGuidType.SequentialAtEnd);
        }
        public Guid Id { get; protected set; }
        public DateTime? CreateDate { get; protected set; }
        public DateTime? UpdateDate { get; protected set; }
    }
}
