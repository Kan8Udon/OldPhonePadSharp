using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string pressNum;
            
            Console.WriteLine("Press pad combination");
            pressNum = Console.ReadLine();




            //Pad OldPhonePad(pressNum); 
            Console.WriteLine(typePad(pressNum));
            Console.ReadLine();
        }

        public static string typePad(string input)
        {
            string oLetter, output = "";                                     // store character
            var oNum1 = "";
            var oNum2 = "";
            // string oNum2, output = "";


            for (int i = 0; i < input.Length; i++)              // Loop to insert letter
            {
                if (input[i] == '*')                            // check * to delete charater
                {
                    output = output.Substring(0, output.Length - 1);
                }
                else if (input[i] == '#')                       // check # to send
                {
                    break;
                }
                else if (input[i] == input[i + 1])              // store iteration number
                {
                    oNum1 = oNum1 + input[i];
                }
                else if (input[i] != input[i + 1] || input[i] == ' ')              // store letter when iteration change
                {
                    oNum2 = oNum1 + input[i];
                    oLetter = Pad.OldPhonePad(oNum2);
                    oNum1 = string.Empty;                        // reset for new iteration
                    output = output + oLetter;                  // store letters
                }



            }

            return output;
        }
    }
}