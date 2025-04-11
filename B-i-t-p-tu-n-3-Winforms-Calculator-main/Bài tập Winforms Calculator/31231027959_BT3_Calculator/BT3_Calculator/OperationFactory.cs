using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Calculator
{
    public static class OperationFactory
    {
        public static Operation CreateOperation(string operatorSymbol)
        {
            switch (operatorSymbol)
            {
                case "+":
                    return new AddOperation();
                case "-":
                    return new SubtractOperation();
                case "*":
                    return new MultiplyOperation();
                case "/":
                    return new DivideOperation();
                default:
                    throw new ArgumentException($"Không hỗ trợ toán tử: {operatorSymbol}");
            }
        }
    }
}
