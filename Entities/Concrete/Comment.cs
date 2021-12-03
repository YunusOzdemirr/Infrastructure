using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Comment:EntityBase<int>,IEntity
    {
        public string Content { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}

