using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserRManager : IUserRService
    {
        IUserRDal _userDal;

        public UserRManager(IUserRDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(UserR user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(UserR user)
        {
            _userDal.Add(user);
        }

        public UserR GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
