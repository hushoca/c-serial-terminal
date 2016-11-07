using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace HocaWatchSerialDecoder
{
    class Program
    {

        static SerialPort sp = new SerialPort();
        static bool isComFound = false;

        static void Main(string[] args)
        {
            String[] ports = SerialPort.GetPortNames();
            foreach (String s in ports) {
                if(s == "COM3")
                {
                    isComFound = true;
                }
            }

            if (isComFound)
            {
                sp.BaudRate = 9600;
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;
                sp.PortName = "COM3";
                sp.Parity = Parity.None;

                sp.Open();

                if (!sp.IsOpen)
                {
                    Environment.Exit(0);
                }

                Thread listenThread = new Thread(new ThreadStart(listenThreadFunc));
                listenThread.IsBackground = true; 
                listenThread.Start();

                Console.WriteLine("Serial connection established...");

                while (true) {
                    string line = Console.ReadLine();
                    if (line == "clear") {
                        Console.Clear();
                    }
                    sp.WriteLine(line);
                }
            }
        }

        static void listenThreadFunc()
        {
            while (true)
            {

                int b = sp.ReadByte();
                if (b == 255)
                {
                    Console.WriteLine();
                }else
                {
                    Console.Write(b);
                    Console.Write(" ");
                }
            }
        }
    }
}
