using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2
{
    public class SigmoidFunction : IActivationFunction
    {
        private double value;

        public SigmoidFunction(double value)
        {
            this.value = value;
        }

        public double CalculateOutput(double val)
        {
            return (1 / (1 + Math.Exp(-val * value)));
        }
    }
}
