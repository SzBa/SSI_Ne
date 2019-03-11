using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2
{
    public interface INeuron
    {
        double PreviousPartialDerivate { get;set;}
        Guid Id { get;  }
        List<ISynapse> Inputs { get; set; }
        List<ISynapse> Outputs { get; set; }
        double CalculateOutput();

        void AddInputNeuron(INeuron input);
        void AddOutputNeuron(INeuron output);
        void AddInputSynapse(double val);
        void PushValueOnInput(double val);

    }
}
