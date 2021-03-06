﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_API_CShartp
{
    class Communication
    {
        private SerialPort port = new SerialPort();

        public Communication()
        {
        }
        public Communication(string portName, int baudRate)  
        {
            port.PortName = portName;
            port.BaudRate = baudRate;
        }

        public string[] GetPortNames() {

            return SerialPort.GetPortNames();       
        }

        public void OpenPort(string portName, int baudRate)
        {
            this.port.Close();
            this.port.PortName = portName;
            this.port.BaudRate = baudRate;
            this.port.Open();
        }

        public void Write(string data)
        {
            port.Write(data);
        }

        public string ReadLine()
        {
            return port.ReadLine();
        }

        public void ClosePort()
        {
            this.port.Close();
        }




    }
}
