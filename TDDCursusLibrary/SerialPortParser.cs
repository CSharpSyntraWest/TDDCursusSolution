using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public class SerialPortParser
    {
        private const int defaultPortNr = 3;
        private const string poortPrefix = "COM";
        public static int ParsePort(string port)
        {
            if (!port.StartsWith(poortPrefix))
            {
                throw new FormatException("Poort is niet in correct formaat - Moet beginnen met 'COM'");
            }
            else
            {
                int portNumber = int.Parse(port.Replace(poortPrefix, ""));
                return portNumber;
            }
        }
    }
}
