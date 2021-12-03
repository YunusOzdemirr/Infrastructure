using System;
using System.Collections.Generic;
using Shared.Entities.Abstract;

namespace Entities.Concrete
{
    public class OperationClaim:EntityBase<int>,IEntity
    {
        public string Name { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}

