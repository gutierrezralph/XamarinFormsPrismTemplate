using XamarinFormsPrismTemplate.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsPrismTemplate.Common.Bluetooth
{
    public interface IBluetoothService
    {
        bool CheckBluetooth();
        List<BluetoothContract> QueryDevices();
    }
}
