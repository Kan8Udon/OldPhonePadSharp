using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadSharp
{
    class Pad
    {       
        public static string OldPhonePad(string input)
        {
            string oLetter = "";

            if (input == "1")
            {
                oLetter = "&";
            }
            else if (input == "11")
            {
                oLetter = "'";
            }
            else if (input == "111")
            {
                oLetter = "(";
            }
            else if (input == "2")
            {
                oLetter = "A";
            }
            else if (input == "22")
            {
                oLetter = "B";
            }
            else if (input == "222")
            {
                oLetter = "C";
            }
            else if (input == "3")
            {
                oLetter = "D";
            }
            else if (input == "33")
            {
                oLetter = "E";
            }
            else if (input == "333")
            {
                oLetter = "F";
            }
            else if (input == "4")
            {
                oLetter = "G";
            }
            else if (input == "44")
            {
                oLetter = "H";
            }
            else if (input == "444")
            {
                oLetter = "I";
            }
            else if (input == "5")
            {
                oLetter = "J";
            }
            else if (input == "55")
            {
                oLetter = "K";
            }
            else if (input == "555")
            {
                oLetter = "L";
            }
            else if (input == "6")
            {
                oLetter = "M";
            }
            else if (input == "66")
            {
                oLetter = "N";
            }
            else if (input == "666")
            {
                oLetter = "O";
            }
            else if (input == "7")
            {
                oLetter = "P";
            }
            else if (input == "77")
            {
                oLetter = "Q";
            }
            else if (input == "777")
            {
                oLetter = "R";
            }
            else if (input == "7777")
            {
                oLetter = "S";
            }
            else if (input == "8")
            {
                oLetter = "T";
            }
            else if (input == "88")
            {
                oLetter = "U";
            }
            else if (input == "888")
            {
                oLetter = "V";
            }
            else if (input == "9")
            {
                oLetter = "W";
            }
            else if (input == "99")
            {
                oLetter = "X";
            }
            else if (input == "999")
            {
                oLetter = "Y";
            }
            else if (input == "9999")
            {
                oLetter = "Z";
            }
            else if (input == "0")
            {
                oLetter = " ";
            }
            /*
            else
            {
                oLetter = "Invalid combination";
            }
            */
            return oLetter;
        }

    }
}