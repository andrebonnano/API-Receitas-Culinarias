using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    internal class CategoryDto
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string CategoryId { get; set; } = Guid.NewGuid().ToString();
        public bool Active { get; set; } = true;
        public string Name { get; set; }
        public string? Parent { get; set; }
    }
}
