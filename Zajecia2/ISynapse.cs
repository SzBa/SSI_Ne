using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2
{
    public interface ISynapse
    {
        double Weight { get;set; }
        double PreviousWeight { get; set; }

        double GetOutput();
        bool IsFromNeuron(Guid id);
        void UpdateWeight(double learningRate, double delta);
    }
}
