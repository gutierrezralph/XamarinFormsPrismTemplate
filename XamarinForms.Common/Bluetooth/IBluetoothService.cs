using XamarinForms.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Common.Bluetooth
{
    public interface IBluetoothService
    {
        bool CheckBluetooth();
        List<BluetoothContract> QueryDevices();
    }
}
