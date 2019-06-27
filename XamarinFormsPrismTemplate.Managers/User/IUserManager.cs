using XamarinFormsPrismTemplate.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsPrismTemplate.Managers.User
{
    public interface IUserManager
    {
        void SaveUser(UserEntity user);
        List<UserEntity> RetrieveAllUser();
    }
}
