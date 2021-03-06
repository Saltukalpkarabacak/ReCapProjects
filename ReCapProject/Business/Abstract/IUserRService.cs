using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserRService
    {
        List<OperationClaim> GetClaims(UserR user);
        void Add(UserR user);
        UserR GetByMail(string email);
    }
}
