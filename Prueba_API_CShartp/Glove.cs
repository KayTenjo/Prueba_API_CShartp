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
            string message = messageGenerator.InitializeMotor(pinArray);
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
            return value_string;
        }

        public string digitalRead(int pin)
        {
            string message = messageGenerator.DigitalRead(pin);
            communication.Write(message);
            string value_string = communication.ReadLine();
            return value_string;
        }

        public void InitializeDigitalInput(int[] pinArray)
        {
            string message = messageGenerator.InitializeDigitalInput(pinArray);
            communication.Write(message);
        }


    }
}
