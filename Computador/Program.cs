using System;
using System.IO.Ports;
using System.Threading;

namespace SerialTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;

            Thread t = new Thread(readKeyboard);
            t.Start();

            while (true)
            {
                Console.WriteLine(counter);
                counter = (counter + 1) % 100;
                Thread.Sleep(100);
            }
        }

        static void readKeyboard()
        {

            SerialPort _serialPort = new SerialPort(); ;
            _serialPort.PortName = "/dev/ttyACM0";
            _serialPort.BaudRate = 115200;
            _serialPort.DtrEnable = true;
            _serialPort.Open();

            byte[] data = { 0x31 };

            while (true) {
                if (Console.KeyAvailable == true)
                {
                    Console.ReadKey(true);
                    _serialPort.Write(data, 0, 1);
                    string message = _serialPort.ReadLine();
                    Console.WriteLine(message);
                }
            }
        }
    }
}