using XamarinForms.Entities;
using XamarinForms.Repository.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Common.Mapper.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<UserEntity, UserDTO>();
            CreateMap<UserDTO, UserEntity>();
        }
    }
}
