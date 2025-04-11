using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Calculator
{
    public class State
    {
        public double CurrentValue { get; set; } = 0;

        public string CurrentOperation { get; set; } = "";

        public bool IsNewNumber { get; set; } = true;

        public void Reset()
        {
            CurrentValue = 0;
            CurrentOperation = "";
            IsNewNumber = true;
        }

        public void ClearEntry()
        {
            IsNewNumber = true;
        }
    }
}
