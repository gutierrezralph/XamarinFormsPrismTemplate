using XamarinFormsPrismTemplate.Contract;
using XamarinFormsPrismTemplate.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsPrismTemplate.Common.Mapper.Profile
{
    public class BluetoothProfile : AutoMapper.Profile
    {
        public BluetoothProfile()
        {
            CreateMap<BluetoothEntity, BluetoothContract>();
            CreateMap<BluetoothContract, BluetoothEntity>();
        }
    }
}
