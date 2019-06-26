using XamarinForms.Repository.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Repository.Repository
{
    public interface IUserRepository
    {
        void SaveUser(UserDTO user);
        IEnumerable<UserDTO> RetrieveUsers();
    }
}
