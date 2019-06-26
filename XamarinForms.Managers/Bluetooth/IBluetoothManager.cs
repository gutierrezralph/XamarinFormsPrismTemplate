using XamarinForms.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Managers.Bluetooth
{
    public interface IBluetoothManager
    {
        List<BluetoothEntity> GetListOfPairedDevices();
    }
}
