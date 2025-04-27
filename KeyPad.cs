using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class KeyPad
    {
        //I use dictionary char string to keyMap
        private readonly Dictionary<char, string> _keypadMap = new()
        {
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" }
        };

        public string ProcessInput(string input)
        {
            var result = new StringBuilder();
            var sequence = new StringBuilder();
            //Validation if input has # in the string.
            if (input.Contains("#"))
            {
                var intCtr = 0;
                foreach (char val in input)
                {
                    //Every Loop will check if the current character is *
                    if (val == '*')
                    {
                        if (sequence.Length > 0)
                            sequence.Length--;
                    }
                    //Checking if 1st value else will check the last character if the same of current character
                    //if the same will append again until next different character.
                    //if different character, it will get the equivalent value of the combine character
                    //after getting the result of the combine character ,
                    //the sequence will clear the content and add the current character

                    if (intCtr > 0)
                    {
                        if (val == input[intCtr - 1])
                        {
                            sequence.Append(val);
                        }
                        else
                        {
                            //append the return in result variable
                            if (sequence.Length > 0)
                                result.Append(GetValue(sequence));

                            //clear sequence to get the next value
                            sequence.Clear();

                            //Get the current character and append to sequence
                            sequence.Append(val);
                        }
                    }
                    else
                    {
                        //Append the 1st value in sequence
                        sequence.Append(val);
                    }
                    intCtr++;
                }

            }

            return result.ToString();
        }
        public string GetValue(StringBuilder Sequence)
        {
            string KeyPadValue = "";
            char key = Sequence[0];

            //look up the Key Value in the dictionary and will get the correct by using sequence index % character length
            //so it will go back to the first index if the character count > dictionary character.

            //Ex. 2222 => A
            //    222 => C
            if (_keypadMap.TryGetValue(key, out string chars))
            {
                int index = (Sequence.Length - 1) % chars.Length;
                KeyPadValue = chars[index].ToString();
            }
            //will return the value
            return KeyPadValue;
        }
    }

}
