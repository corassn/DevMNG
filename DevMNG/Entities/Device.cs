using MongoDB.AspNet.Identity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevMNG.Entities
{
    public class Device
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        [JsonProperty("Name")]
        public string DeviceName { get; set; }
        [BsonElement("manufacturer")]
        public string Manufacturer { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("opSys")]
        [JsonProperty("Operating System")]
        public string OperatingSys { get; set; }

        [BsonElement("opSysVers")]
        [JsonProperty("Operating System Version")]
        public string OSVersion { get; set; }
        [BsonElement("processor")]
        public string Processor { get; set; }
        [BsonElement("RAM")]
        public string RAM { get; set; }
    }
}
