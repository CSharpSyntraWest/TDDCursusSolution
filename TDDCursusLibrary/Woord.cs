using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDCursusLibrary
{
    public class Woord
    {
        public string Text { get; set; }
        public Woord(string woord)
        {
            Text = woord;
        }
        public bool IsPalindroom()
        {
            string textOmgekeerd = new string(Text.ToCharArray().Reverse().ToArray());
            return Text.Equals(textOmgekeerd);
            //throw new NotImplementedException();
        }
        public bool IsPalindroomv2()
        {
            for (int teller = 0; teller < Text.Length / 2; teller++)
            {
                if (Text[teller] != Text[Text.Length - 1 - teller]) return false;
            }
            return true;
        }

        public bool IsPalindroomv3()
        {
            return Text == new string(Text.ToArray().Reverse().ToArray());
        }
    }
}
