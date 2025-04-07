using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Calculator
{
    public class Engine
    {
        private readonly State _state;
        private readonly DM _displayManager;
        private readonly InputProcessor _inputProcessor;

        public Engine()
        {
            _state = new State();
            _displayManager = new DM();
            _inputProcessor = new InputProcessor(_state, _displayManager);
        }

        public string ProcessDigit(string display, string digit)
        {
            return _inputProcessor.ProcessDigit(display, digit);
        }
      
        public string ProcessDecimalPoint(string display)
        {
            return _inputProcessor.ProcessDecimalPoint(display);
        }
    
        public string ProcessOperator(string display, string operation)
        {
            return _inputProcessor.ProcessOperator(display, operation);
        }
    
        public string ProcessEquals(string display)
        {
            return _inputProcessor.ProcessEquals(display);
        }
 
        public string ProcessClear()
        {
            return _inputProcessor.ProcessClear();
        }
   
        public string ProcessClearEntry()
        {
            return _inputProcessor.ProcessClearEntry();
        }
    }
}
