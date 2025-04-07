using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Calculator
{
    public class InputProcessor
    {
        private readonly State _state;
        private readonly DM _displayManager;

        public InputProcessor(State state, DM displayManager)
        {
            _state = state;
            _displayManager = displayManager;
        }
        public string ProcessDigit(string display, string digit)
        {
            string result = _displayManager.AddDigit(display, digit, _state.IsNewNumber);
            _state.IsNewNumber = false;
            return result;
        }
     
        public string ProcessDecimalPoint(string display)
        {
            string result = _displayManager.AddDecimalPoint(display, _state.IsNewNumber);
            _state.IsNewNumber = false;
            return result;
        }

        public string ProcessOperator(string display, string operation)
        {
            
            double displayValue = Convert.ToDouble(display);

           
            if (!_state.IsNewNumber && _state.CurrentOperation != "")
            {
                Operation op = OperationFactory.CreateOperation(_state.CurrentOperation);
                _state.CurrentValue = op.Execute(_state.CurrentValue, displayValue);
                _state.IsNewNumber = true;
                _state.CurrentOperation = operation;
                return _displayManager.FormatDisplay(_state.CurrentValue);
            }
            else
            {
                
                _state.CurrentValue = displayValue;
                _state.CurrentOperation = operation;
                _state.IsNewNumber = true;
                return display;
            }
        }
    
        public string ProcessEquals(string display)
        {
            double displayValue = Convert.ToDouble(display);

            
            if (_state.CurrentOperation != "")
            {
                Operation op = OperationFactory.CreateOperation(_state.CurrentOperation);
                double result = op.Execute(_state.CurrentValue, displayValue);
                _state.CurrentValue = result;
                _state.CurrentOperation = "";
                _state.IsNewNumber = true;
                return _displayManager.FormatDisplay(result);
            }
            else
            {
                
                return display;
            }
        }
  
        public string ProcessClear()
        {
            _state.Reset();
            return "0";
        }

        public string ProcessClearEntry()
        {
            _state.ClearEntry();
            return "0";
        }
    }
}
