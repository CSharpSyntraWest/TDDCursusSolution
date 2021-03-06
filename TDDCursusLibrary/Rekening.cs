using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary 
{
    //Demo TDD: Test Driven Development bij Unit Tests
    public class Rekening
    {
        private decimal saldo;
        public void Storten(decimal bedrag)
        {
            if (bedrag <= decimal.Zero)
            {
                throw new ArgumentException();
            }
            saldo += bedrag;
        }
        public decimal Saldo
        {
            get {
                return saldo;
            }
        }
    }
}
