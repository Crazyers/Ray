﻿using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Ray.MongoDB
{
    public class CollectionInfo
    {
        [BsonId]
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
