using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public class Veiling
    {
        private decimal hoogsteBod = 0m;
        public void DoeBod(decimal bedrag)
        {
            if (bedrag > hoogsteBod)
                hoogsteBod = bedrag;
            //throw new NotImplementedException();
        }
        public decimal HoogsteBod
        {
            get {
                //throw new NotImplementedException();
                return hoogsteBod;
            }
        }
    }
}
