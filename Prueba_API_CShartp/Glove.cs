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

        public void InitializeMotor(IEnumerable<int> pins)
        {
            string message = messageGenerator.InitializeMotor(pins);
            communication.Write(message);
        }

        public void ActivateMotor(IEnumerable<int> pins, IEnumerable<string> values)
        {
            string message = messageGenerator.ActivateMotor(pins,values);
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

        public string DigitalRead(int pin)
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
        public void PinMode(int pin, string mode)
        {
            string message = messageGenerator.PinMode(pin,mode);
            communication.Write(message);
        }
        public void PinMode(IEnumerable<int> pins, IEnumerable<string> modes)
        {
            string message = messageGenerator.PinMode(pins, modes);
            communication.Write(message);
        }

        public void DigitalWrite(int pin, string value)
        {
            string message = messageGenerator.DigitalWrite(pin, value);
            communication.Write(message);
        }

        public void DigitalWrite(IEnumerable<int> pins, IEnumerable<string> values)
        {
            string message = messageGenerator.DigitalWrite(pins, values);
            communication.Write(message);
        }

        public void AnalogWrite(int pin, int value)
        {
            string message = messageGenerator.AnalogWrite(pin, value);
            communication.Write(message);
        }

        public void AnalogWrite(IEnumerable<int> pins, IEnumerable<int> values)
        {
            string message = messageGenerator.AnalogWrite(pins, values);
            communication.Write(message);

        }


    }
}
