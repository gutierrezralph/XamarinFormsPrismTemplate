using XamarinForms.Contract;
using XamarinForms.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Common.Mapper.Profile
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
