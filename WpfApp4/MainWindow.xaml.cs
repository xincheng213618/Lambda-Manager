using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            combox1.ItemsSource = list;
        }
        List<string> list = new List<string>();
        private static BleCore bleCore = null;

        private static List<GattCharacteristic> characteristics = new List<GattCharacteristic>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bleCore = new BleCore();
            bleCore.DeviceWatcherChanged += DeviceWatcherChanged;
            bleCore.CharacteristicAdded += CharacteristicAdded;
            bleCore.CharacteristicFinish += CharacteristicFinish;
            bleCore.Recdate += Recdata;
            bleCore.StartBleDeviceWatcher();

            //Console.ReadKey(true);

            //bleCore.Dispose();
            //bleCore = null;
        }

        private static void CharacteristicFinish(int size)
        {
            if (size <= 0)
            {
                Console.WriteLine("设备未连上");
                return;
            }
        }

        private static void Recdata(GattCharacteristic sender, byte[] data)
        {
            string str = BitConverter.ToString(data);
            Console.WriteLine(sender.Uuid + "             " + str);
        }

        private static void CharacteristicAdded(GattCharacteristic gatt)
        {
            Console.WriteLine(
                "handle:[0x{0}]  char properties:[{1}]  UUID:[{2}]",
                gatt.AttributeHandle.ToString("X4"),
                gatt.CharacteristicProperties.ToString(),
                gatt.Uuid);
            characteristics.Add(gatt);
        }

        private  void DeviceWatcherChanged(BluetoothLEDevice currentDevice)
        {
            byte[] _Bytes1 = BitConverter.GetBytes(currentDevice.BluetoothAddress);
            Array.Reverse(_Bytes1);
            string address = BitConverter.ToString(_Bytes1, 2, 6).Replace('-', ':').ToLower();
            Console.WriteLine("发现设备：<" + currentDevice.Name + ">  address:<" + address + ">");
            list.Add(currentDevice.Name+ address);
            //指定一个对象，使用下面方法去连接设备
            //ConnectDevice(currentDevice);
        }

        private static void ConnectDevice(BluetoothLEDevice Device)
        {
            characteristics.Clear();
            bleCore.StopBleDeviceWatcher();
            bleCore.StartMatching(Device);
            bleCore.FindService();
        }
    }
}
