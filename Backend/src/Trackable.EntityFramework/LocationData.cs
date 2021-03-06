﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Trackable.EntityFramework
{
    [Table("Locations")]
    public class LocationData : EntityBase<int>, ITaggedEntity, INamedEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public DbGeography Location { get; set; }

        public int? MinimumWaitTime { get; set; }

        public int? InterestLevel { get; set; }

        public ICollection<TagData> Tags { get; set; }
    }
}