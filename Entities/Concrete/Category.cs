using System;
using System.Collections.Generic;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Category:EntityBase<int>,IEntity
    {
        public string Name { get; set; }
        public ICollection<CategoryAndPost> CategoryAndPosts{ get; set; }
    }
}

