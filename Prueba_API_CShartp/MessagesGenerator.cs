using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_API_CShartp
{
    class MessagesGenerator
    {

        private string separator = ",";
        private string terminal = "s";
        private string initializeFunctionNumber = "1";
        private string activateFunctionNumber = "2";

        public string InitializeActuators(int[] pinArray)
        {
            if (pinArray.Length == 0)
            {
                throw new System.ArgumentException("Array must have at least one element");
            }
            var initializeMessage = new StringBuilder();

            initializeMessage.Append(initializeFunctionNumber + separator + pinArray.Length);

            for (var i = 0; i < pinArray.Length; i++)
            {
                var message = separator + pinArray[i];
                initializeMessage.Append(message);
            }

            initializeMessage.Append(terminal);


            return initializeMessage.ToString();

        }

        public string ActivateActuators(int[] pins, string[] values)
        {

            if (pins.Length != values.Length)
            {
                throw new System.ArgumentException("Arrays length must be equal");
            }

            var initializeMessage = new StringBuilder();

            initializeMessage.Append(activateFunctionNumber + separator + pins.Length);

            for (var i = 0; i < pins.Length; i++)
            {
                string value = "nada";

                if (values[i] == "HIGH")
                {
                    value = "-1";
                }

                else if (values[i] == "LOW")
                {
                    value = "-2";
                }

                else
                {
                    try
                    {

                        var valueAux = Int32.Parse(values[i]);
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
                        throw new ArgumentException("Invalid value " + values[i]);
                    }

                }

                var message = separator + pins[i] + separator + value;
                initializeMessage.Append(message);
            }

            initializeMessage.Append(terminal);

            return initializeMessage.ToString();

        }




    }
}
