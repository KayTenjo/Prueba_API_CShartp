using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_API_CShartp
{
    class MessageGenerator
    {

        private string separator = ",";
        private string terminal = "s";
        private string initializeMotorFunctionNumber = "1";
        private string activateMotorFunctionNumber = "2";
        private string analogReadFunctionNumber = "3";
        private string digitialReadFunctionNumber = "4";
        private string initializeDigitialInputFunctionNumber = "5";
        private string pinModeInputFunctionNumber = "6";
        private string digitalWriteInputFunctionNumber = "7";
        private string analogWriteInputFunctionNumber = "8";

        public string InitializeMotor(IEnumerable<int> pins)
        {
            if (pins.Count() == 0)
            {
                throw new System.ArgumentException("Array must have at least one element");
            }
            var initializeMessage = new StringBuilder();

            initializeMessage.Append(initializeMotorFunctionNumber + separator + pins.Count());

            foreach(int pin in pins)
            {
                var message = separator + pin;
                initializeMessage.Append(message);
            }

            initializeMessage.Append(terminal);


            return initializeMessage.ToString();

        }

        public string ActivateMotor(IEnumerable<int> pins, IEnumerable<string> values)
        {

            if (pins.Count() != values.Count())
            {
                throw new System.ArgumentException("Lists length must be equal");
            }

            var activateMessage = new StringBuilder();

            activateMessage.Append(activateMotorFunctionNumber + separator + pins.Count());

            for (var i = 0; i < pins.Count(); i++)
            {
                var value = "";

                if (values.ElementAt(i) == "HIGH")
                {
                    value = "-1";
                }

                else if (values.ElementAt(i) == "LOW")
                {
                    value = "-2";
                }

                else
                {
                    try
                    {

                        var valueAux = Int32.Parse(values.ElementAt(i));
                        // FALTA TRY CATCH PARA QUE SEA UN VALOR;
                        if ((valueAux < 256) && (valueAux >= 0))
                        {
                            value = valueAux.ToString();
                        }

                        else
                        {
                            throw new ArgumentException("Values must be between 0 and 255");
                        }

                    }


                    catch (System.FormatException e)
                    {
                        //return (e.Data.Keys.ToString());
                        throw new ArgumentException("Invalid value " + values.ElementAt(i));
                    }

                }

                var message = separator + pins.ElementAt(i) + separator + value;
                activateMessage.Append(message);
            }

            activateMessage.Append(terminal);

            return activateMessage.ToString();

        }

        public string AnalogRead(int pin)
        {
            string message = analogReadFunctionNumber + separator + pin + terminal;
            return message;
        }

        public string DigitalRead(int pin)
        {
            string message = digitialReadFunctionNumber + separator + pin + terminal;
            return message;
        }

        public string PinMode(int pin, string mode)
        {
            string modeProtocol = "";

            if (mode == "INPUT")
            {
                modeProtocol = "1";
            }

            else if (mode == "OUTPUT")
            {
                modeProtocol = "2";
            }

            else
            {
                throw new System.ArgumentException(mode + " is not a valid mode");
            }
            
            string message = pinModeInputFunctionNumber + separator + "1" + separator + pin + separator 
                + modeProtocol + terminal;
            return message;
        }
        public string PinMode(IEnumerable<int> pins, IEnumerable<string> modes)
        {
            if (pins.Count() != modes.Count())
            {
                throw new System.ArgumentException("Collections length must be equal");
            }

            var pinModeMessage = new StringBuilder();
            pinModeMessage.Append(pinModeInputFunctionNumber + separator + pins.Count());

            for (var i = 0; i < pins.Count(); i++)
            {
                string modeProtocol = "";

                if (modes.ElementAt(i) == "INPUT")
                {
                    modeProtocol = "1";
                }

                else if (modes.ElementAt(i) == "OUTPUT")
                {
                    modeProtocol = "2";
                }

                else
                {
                    throw new System.ArgumentException(modes.ElementAt(i) + " is not a valid mode");
                }

                var message = separator + pins.ElementAt(i) + separator + modeProtocol;
                pinModeMessage.Append(message);

            }

            pinModeMessage.Append(terminal);
            return pinModeMessage.ToString();

    }

        public string DigitalWrite(int pin, string value)
        {
            string valueProtocol = "";

            if (value == "LOW")
            {
                valueProtocol = "0";
            }

            else if (value == "HIGH")
            {
                valueProtocol = "1";
            }

            else
            {
                throw new System.ArgumentException(value + " is not a valid value");
            }

            string message = digitalWriteInputFunctionNumber + separator + "1" + separator +
                pin + separator + valueProtocol + terminal;
            return message;
        }

        public string DigitalWrite(IEnumerable<int> pins, IEnumerable<string> values)
        {
            if (pins.Count() != values.Count())
            {
                throw new System.ArgumentException("Collections length must be equal");
            }

            var digitalWriteMessage = new StringBuilder();
            digitalWriteMessage.Append(digitalWriteInputFunctionNumber + separator + pins.Count());

            for (var i = 0; i < pins.Count(); i++)
            {
                string valueProtocol = "";

                if (values.ElementAt(i) == "LOW")
                {
                    valueProtocol = "0";
                }

                else if (values.ElementAt(i) == "HIGH")
                {
                    valueProtocol = "1";
                }

                else
                {
                    throw new System.ArgumentException(values.ElementAt(i) + " is not a valid value");
                }

                var message = separator + pins.ElementAt(i) + separator + valueProtocol;
                digitalWriteMessage.Append(message);

            }

            digitalWriteMessage.Append(terminal);
            return digitalWriteMessage.ToString();
        }

        public string AnalogWrite(int pin, int value)
        {
            string message = analogWriteInputFunctionNumber + separator + "1" + separator + pin 
                + separator + value + terminal;
            return message;
        }

        public string AnalogWrite(IEnumerable<int> pins, IEnumerable<int> values)
        {
            if (pins.Count() != values.Count())
            {
                throw new System.ArgumentException("Collections length must be equal");
            }

            var analogWriteMessage = new StringBuilder();
            analogWriteMessage.Append(analogWriteInputFunctionNumber + separator + pins.Count());

            for (var i = 0; i < pins.Count(); i++)
            {
               
                var message = separator + pins.ElementAt(i) + separator + values.ElementAt(i);
                analogWriteMessage.Append(message);

            }

            analogWriteMessage.Append(terminal);
            return analogWriteMessage.ToString();

        }

        public string InitializeDigitalInput(int[] pinArray)
        {
            if (pinArray.Length == 0)
            {
                throw new System.ArgumentException("Array must have at least one element");
            }
            var initializeMessage = new StringBuilder();
            initializeMessage.Append(initializeDigitialInputFunctionNumber + separator + pinArray.Length);

            for (var i = 0; i < pinArray.Length; i++)
            {
                var message = separator + pinArray[i];
                initializeMessage.Append(message);
            }

            initializeMessage.Append(terminal);
            return initializeMessage.ToString();

        }

    }
}
