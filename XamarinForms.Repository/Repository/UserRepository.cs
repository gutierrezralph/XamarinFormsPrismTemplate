using System;
using System.Collections.Generic;
using System.Text;
using XamarinForms.Repository.DataTransferObject;

namespace XamarinForms.Repository.Repository
{
    public class UserRepository : DataProvider, IUserRepository
    {
        public UserRepository(IDatabaseFactory databaseFactory):base(databaseFactory)
        {

        }
        public IEnumerable<UserDTO> RetrieveUsers()
        {
            return GetItemList<UserDTO>();
        }

        public void SaveUser(UserDTO user)
        {
            SaveItem<UserDTO>(user);
        }
    }
}
