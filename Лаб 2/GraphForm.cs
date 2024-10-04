using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_2
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
            cbGraphType.SelectedIndex = 0;
            cbTraversalMethod.SelectedIndex = 0;
            cbVertice.SelectedIndex = 0;
        }

        private bool isDirected()
        {
            return Convert.ToBoolean(cbGraphType.SelectedIndex);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Adj_matrix adj_mat = createAdjMatrix();
            if (isDirected())
            {
                pbResult.Load(Environment.CurrentDirectory + "\\images\\directed.png");
            } else
            {
                pbResult.Load(Environment.CurrentDirectory + "\\images\\undirected.png");
            }
        }

        private void btnTraverse_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = String.Empty;
            Adj_matrix adj_mat = createAdjMatrix();
            textBoxOutput.Text = adj_mat.Print();
            if (cbTraversalMethod.SelectedIndex != -1)
            {
                textBoxOutput.AppendText(adj_mat.DepthFirstSearch(cbVertice.SelectedIndex));
            }
            else
            {
                textBoxOutput.AppendText(adj_mat.BreadthFirstSearch(cbVertice.SelectedIndex));
            }
        }

        private Adj_matrix createAdjMatrix()
        {
            int[,] edge_list = select_edge_list(isDirected());
            Adj_matrix adj_matrix = new Adj_matrix(getVertecies().GetLength(0), isDirected(), getVertecies());
            for (int i = 0; i < edge_list.GetLength(0); i++)
            {
                adj_matrix.AddEdge(edge_list[i, 0], edge_list[i, 1]);
            }
            return adj_matrix;
        }

        static string[] getVertecies()
        {
            return new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
            //                     0    1    2    3    4    5    6    7 
        }

        static int[,] select_edge_list(bool isDirected)
        {
            int[,] directedEdges = { { 0, 1 }, { 0, 2 }, { 0, 4 }, { 1, 3 }, { 1, 4 }, { 2, 4 }, { 2, 5 },
                { 3, 4 }, { 4, 7 }, { 5, 4 }, { 5, 7 }, { 6, 3 }, { 6, 4 }, { 6, 7 } };
            int[,] notDirectedEdges = { { 0, 1 }, { 0, 2 }, { 0, 4 }, { 1, 3 }, { 1, 4 }, { 2, 7 }, { 2, 5 },
                { 3, 5 }, { 3, 6 }, { 7, 4 }, { 7, 5 }, { 6, 4 }, { 6, 7 } };
            if (isDirected)
            {
                return directedEdges;
            }
            else
            {
                return notDirectedEdges;
            }
        }


    }
}


