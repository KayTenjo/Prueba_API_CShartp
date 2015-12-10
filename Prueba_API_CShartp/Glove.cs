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

        public void OpenPort(string portName, int baudRate)
        {
            communication.OpenPort(portName,baudRate);
        }

        public void ClosePort()
        {
            communication.ClosePort();
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

        public string ReadLine()
        {
            return communication.ReadLine();
        }

        public void Write(string message)
        {
            communication.Write(message);
        }

        public string AnalogRead(int pin)
        {
            string message = messageGenerator.AnalogRead(pin);
            communication.Write(message);
            string value_string = communication.ReadLine();
            //int value_int = Int32.Parse(value_string);

            return value_string;
        }
    }
}
