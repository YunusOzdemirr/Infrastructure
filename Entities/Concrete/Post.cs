using System;
using System.Collections.Generic;
using Entities.ComplexTypes;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class Post : EntityBase<int>, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public sbyte StarAverage { get; set; }
        public int TotalLikeCount { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<PostPicture> PostPicture { get; set; }
        public ICollection<Guid> IsLikedFromUserId { get; set; }
        public ICollection<CategoryAndPost> CategoryAndPosts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        //Birden fazla beğeni tipi olabilir bu yüzden AdmirationType olarak tanımladım 
        public ICollection<AdmirationType> AdmirationType { get; set; }
    }
}

