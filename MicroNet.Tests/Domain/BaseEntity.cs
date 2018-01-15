using System;

namespace  MicroNet.Domain
{
    public class BaseEntity
    {
        public long Id { get; set; }

        public int Version { get; set; }
    }
}
