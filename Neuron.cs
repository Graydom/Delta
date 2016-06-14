using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta
{
    public class Neuron
    {
        public static int COUNT;
        public int ID;
        public List<NeighborNeuron> ConnectedNeurons = new List<NeighborNeuron>();
        public Idea content;

        public Neuron()
        {
            ID = COUNT;
            COUNT++;
        }
    }

    public class NeighborNeuron : Neuron
    {
        public float weight;
    }

    public class Idea
    {
        public string Data;

        public void NormalizeData(string input)
        {

        }
        public void NormalizeData(int input)
        {

        }


    }
}
