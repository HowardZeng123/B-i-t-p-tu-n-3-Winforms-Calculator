using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Calculator
{
    public class DM
    {
       
        public string FormatDisplay(double value)
        {           
            if (value == Math.Floor(value))
                return value.ToString("0");
  
            return value.ToString();
        }

        
        public string AddDigit(string currentDisplay, string digit, bool isNewNumber)
        {
            
            if (isNewNumber || currentDisplay == "0")
                return digit;
  
            return currentDisplay + digit;
        }

        
        public string AddDecimalPoint(string currentDisplay, bool isNewNumber)
        {
            
            if (currentDisplay.Contains("."))
                return currentDisplay;
  
            if (isNewNumber)
                return "0.";

            return currentDisplay + ".";
        }

    }
}
