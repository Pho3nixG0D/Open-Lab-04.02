using System;
using System.Linq;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string doubledd = "";
            {
                foreach (char c in original)
                {
                    doubledd = doubledd + c + c;
                } 
            }
            return doubledd;
        }
    }
}
