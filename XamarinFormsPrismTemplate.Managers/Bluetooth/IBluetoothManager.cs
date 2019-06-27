using XamarinFormsPrismTemplate.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsPrismTemplate.Managers.Bluetooth
{
    public interface IBluetoothManager
    {
        List<BluetoothEntity> GetListOfPairedDevices();
    }
}
