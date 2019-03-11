using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2
{
    class Synapse : ISynapse
    {
        internal INeuron from, to;
        private Neuron neuron;
        private double val;

        public Synapse(INeuron from, INeuron to, double weight)
        {
            this.from = from;
            this.to = to;
            this.Weight = weight;
            PreviousWeight = 0;
        }

        public Synapse(INeuron from, INeuron to)
        {
            Random rnd = new Random();
            this.from = from;
            this.to = to;
            Weight = rnd.NextDouble();
            PreviousWeight = 0;
        }

        public Synapse(Neuron neuron, double val)
        {
            this.neuron = neuron;
            this.val = val;
        }

        public double Weight { get;set; }
        public double PreviousWeight { get; set; }

        public double GetOutput()
        {
            return from.CalculateOutput();
        }

        public bool IsFromNeuron(Guid id)
        {
            return from.Id.Equals(id);
        }

        public void UpdateWeight(double learningRate, double delta)
        {
            PreviousWeight = Weight;
            Weight += learningRate * delta;
        }
    }
}
