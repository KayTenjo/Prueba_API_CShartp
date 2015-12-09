using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_API_CShartp
{
    class Glove
    {
        Communication communication = new Communication();
        MessagesGenerator messageGenerator = new MessagesGenerator();

        public void InitializeSerialPort(string portName, int baudRate)
        {
            communication.InitializeSerialPort(portName,baudRate);
        }

        public string[] GetPortNames()
        {
            return communication.GetPortNames();
        }

        public void InitializeActuators(int[] pinArray)
        {
            string message = messageGenerator.InitializeActuators(pinArray);
            communication.Write(message);
        }

        public void ActivateActuators(int[] pins, string[] values)
        {
            string message = messageGenerator.ActivateActuators(pins,values);
            communication.Write(message);
        }
    }
}
