﻿using XamarinForms.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Managers.User
{
    public interface IUserManager
    {
        void SaveUser(UserEntity user);
        List<UserEntity> RetrieveAllUser();
    }
}
