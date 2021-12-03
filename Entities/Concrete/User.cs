using System;
using System.Collections.Generic;
using Entities.ComplexTypes;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class User:EntityBase<Guid>,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public byte PhoneNumber { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsEmailAddressVerified { get; set; }
        public string VerificationCode { get; set; }
        public int? UserPictureId { get; set; }
        public UserPicture UserPicture { get; set; }
        public DateTime? LastLogin { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
        public ICollection<UserToken> UserTokens { get; set; }
        public ICollection<Post> Articles { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}

