using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class CategoryAndPost:IEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}

