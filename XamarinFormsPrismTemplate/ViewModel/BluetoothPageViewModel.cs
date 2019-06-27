using XamarinFormsPrismTemplate.Entities;
using XamarinFormsPrismTemplate.Managers.Bluetooth;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsPrismTemplate.ViewModel
{
    public class BluetoothPageViewModel
    {
        private IBluetoothManager _bluetoothManager;
        public List<BluetoothEntity> BluetoothDevices { get; set; } = new List<BluetoothEntity>();
        public BluetoothPageViewModel(IBluetoothManager bluetoothManager)
        {
            _bluetoothManager = bluetoothManager;
            BluetoothDevices = _bluetoothManager.GetListOfPairedDevices();
        }
    }
}
