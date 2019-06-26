using XamarinForms.Common.Mapper.Mapper;
using XamarinForms.Common.Mapper.Profile;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Common.Mapper
{
    public class MapperService : IMapperService
    {
        public MapperService()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<BluetoothProfile>();
                cfg.AddProfile<UserProfile>();
            });
        }

        public TDestination Map<TDestination>(object value)
        {
            return AutoMapper.Mapper.Map<TDestination>(value);
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return AutoMapper.Mapper.Map<TSource, TDestination>(source);
        }
    }
}

