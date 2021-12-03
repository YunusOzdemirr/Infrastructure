using System;
namespace Entities.Concrete
{
    public class UserToken
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Token { get; set; }
        public DateTime TokenExpiration { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
        public string IpAddress { get; set; }
    }
}

