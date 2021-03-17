using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfUserRDal : EfEntityRepositoryBase<UserR, NorthWindContext>, IUserRDal
    {
        public List<OperationClaim> GetClaims(UserR user)
        {
            using (var context = new NorthWindContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationsClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim {
                                 Id = operationClaim.Id, 
                                 Name = operationClaim.Name 
                             };
                return result.ToList();

            }
        }
    }
}
