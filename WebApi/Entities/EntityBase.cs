﻿using System;

namespace WebApi.Entities
{
    public abstract class EntityBase
    {
        public virtual int? Id { get; set; }
        public virtual DateTime? CreatedAt { get; set; }
        public virtual DateTime? UpdatedAt { get; set; }
        public virtual DateTime? DeletedAt { get; set; }
    }
}
