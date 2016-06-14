using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Plugins;

namespace Delta
{
    public partial class Form1 : Form
    {
        public List<Neuron> ActiveNeurons = new List<Neuron>();
        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayNeurons()
        {
            NeuronView.Nodes.Clear();
            foreach(Neuron n in ActiveNeurons)
            {
                List<TreeNode> con = new List<TreeNode>();
                foreach(NeighborNeuron NN in n.ConnectedNeurons)
                {
                    con.Add(new TreeNode("Neuron " + NN.ID + " Strength " + NN.weight));
                }
                TreeNode t = new TreeNode("Neuron " + n.ID, con.ToArray());
                TreeNode baseT = new TreeNode("Neuron "+n.ID);
                NeuronView.Nodes.Add(t);

            }
        }
    }
}
