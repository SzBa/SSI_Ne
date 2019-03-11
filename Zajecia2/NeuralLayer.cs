using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2
{
    class NeuralLayer
    {
        public List<INeuron> Neurons;
        public NeuralLayer()
        {
            Neurons = new List<INeuron>();
        }

        public void ConncerTwoLayers(NeuralLayer secondOne)
        {
            //LINQ
            var val = Neurons.SelectMany(neuron => secondOne.Neurons, (neuron, input) => new { neuron, input });
            val.ToList().ForEach(x => x.neuron.AddInputNeuron(x.input));
        }
    }
}
