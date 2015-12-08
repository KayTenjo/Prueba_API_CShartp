using System;
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

        public Communication(string portName, int baudRate)  
        {
            port.PortName = portName;
            port.BaudRate = baudRate;
        }

        public string[] getPortNames() {

            return SerialPort.GetPortNames();       
        }

        public void initializeSerialPort(string portName, int baudRate)
        {
            port.PortName = portName;
            port.BaudRate = baudRate;
        }




    }
}
