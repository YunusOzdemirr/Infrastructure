using System;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class PostPicture:EntityBase<int>,IEntity
    {
        public byte[] File { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}

