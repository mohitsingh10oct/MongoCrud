using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoCrud.Data
{
    public class ProductDetails
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id
        {
            get;
            set;
        }
        [BsonElement("ProductName")]
        public string ProductName
        {
            get;
            set;
        }
        public string ProductDescription
        {
            get;
            set;
        }
        public int ProductPrice
        {
            get;
            set;
        }
        public int ProductStock
        {
            get;
            set;
        }
    }
}
