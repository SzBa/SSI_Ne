using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2
{
    class Neuron : INeuron
    {
        private IActivationFunction activation;

        public Neuron(IActivationFunction funkcja)
        {
            activation=funkcja;
            Inputs = new List<ISynapse>();
            Outputs = new List<ISynapse>();
            Id = Guid.NewGuid();
        }
        public double PreviousPartialDerivate { get; set; }
        public Guid Id { get; }
        public List<ISynapse> Inputs { get; set; }
        public List<ISynapse> Outputs { get; set; }
        public double CalculateOutput()
        {
            //oblicz funkcje aktywacji
            return 0;
        }

        public void AddInputNeuron(INeuron input)
        {
            var synapse = new Synapse(input, this);
            Inputs.Add(synapse);
            input.Outputs.Add(synapse);
        }
        public void AddOutputNeuron(INeuron output)
        {
            var synapse = new Synapse(output, this);
            Outputs.Add(synapse);
            output.Inputs.Add(synapse);
        }
        public void AddInputSynapse(double val)
        {
            var synapse = new Synapse(this, val);
            Inputs.Add(synapse);
        }
        public void PushValueOnInput(double val)
        {
            ((InputSynapse)Inputs.First()).Outputs = val;
        }

    }
}
