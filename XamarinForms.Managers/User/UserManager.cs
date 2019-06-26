using System;
using System.Collections.Generic;
using System.Text;
using XamarinForms.Common.Mapper.Mapper;
using XamarinForms.Entities;
using XamarinForms.Repository.DataTransferObject;
using XamarinForms.Repository.Repository;

namespace XamarinForms.Managers.User
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapperService _mapperService;
        public UserManager(IUserRepository userRepository, IMapperService mapperService)
        {
            _userRepository = userRepository;
            _mapperService = mapperService;
        }
        public List<UserEntity> RetrieveAllUser()
        {
            var result = _userRepository.RetrieveUsers();
            return _mapperService.Map<List<UserEntity>>(result); 
        }

        public void SaveUser(UserEntity user)
        {
            var result = _mapperService.Map<UserDTO>(user);
            _userRepository.SaveUser(result);
        }
    }
}
