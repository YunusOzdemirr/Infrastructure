using System;
namespace Entities.Concrete
{
    public class UserOperationClaim
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int OperationClaimId { get; set; }
        public OperationClaim OperationClaim { get; set; }
    }
}

