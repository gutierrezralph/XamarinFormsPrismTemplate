using XamarinFormsPrismTemplate.Entities;
using XamarinFormsPrismTemplate.Repository.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsPrismTemplate.Common.Mapper.Profile
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
