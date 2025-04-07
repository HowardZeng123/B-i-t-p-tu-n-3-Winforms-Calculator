using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_Calculator
{
    public abstract class Operation
    {
        public abstract double Execute(double operand1, double operand2);
    }

    // cộng
    public class AddOperation : Operation
    {
        public override double Execute(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
    }

    // trừ
    public class SubtractOperation : Operation
    {
        public override double Execute(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
    }

    // nhân
    public class MultiplyOperation : Operation
    {
        public override double Execute(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
    }

    // chia
    public class DivideOperation : Operation
    {
        public override double Execute(double operand1, double operand2)
        {
            if (operand2 == 0)
                throw new DivideByZeroException("Không thể chia cho 0");

            return operand1 / operand2;
        }
    }
}
