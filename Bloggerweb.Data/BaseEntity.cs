using System;

namespace Bloggerweb.Data
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string IPAddress { get; set; }
    }
}
