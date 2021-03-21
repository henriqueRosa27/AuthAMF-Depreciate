﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Auth.AMF.Web.Models
{
    public class CreatePassword
    {
        [BsonId]
        // standard BSonId generated by MongoDb
        public ObjectId InternalId { get; set; }

        public Guid Id { get; set; }

        public string AuthUserId { get; set; }

        [BsonDateTimeOptions]
        // attribute to gain control on datetime serialization
        public DateTime CreateAt { get; set; }

        public bool IsValid { get; set; }
    }
}
