using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_2
{
    public class Adj_matrix
    {
        private int[,] matrix;
        private int verticesCount;
        private bool isDirected;
        private string[] verteceis;
        

        public Adj_matrix(int vertices, bool isDirected, string[] verteceis)
        {
            this.isDirected = isDirected;
            verticesCount = vertices;
            matrix = new int[vertices, vertices];
            this.verteceis = verteceis;
        }

        public void AddEdge(int source, int destination)
        {
            matrix[source, destination] = 1;
            if (!isDirected)
            {
                matrix[destination, source] = 1;
            }
        }
        public string Print()
        {
            string result = string.Empty;
            // Виведення заголовка з назвами вершин
            result += "   ";
            for (int i = 0; i < verticesCount; i++)
            {
                result += $"{verteceis[i]} ".PadRight(4);
            }
            result += Environment.NewLine;

            // Виведення матриці суміжності з назвами вершин
            for (int i = 0; i < verticesCount; i++)
            {
                result += verteceis[i] + "  ";  // Виведення назви вершини
                for (int j = 0; j < verticesCount; j++)
                {
                    result += matrix[i, j].ToString().PadRight(4);
                }
                result += Environment.NewLine;
            }
            return result;
        }

        public string DepthFirstSearch(int src)
        {
            if (src < 0 || src >= verticesCount) return string.Empty;

            bool[] visited = new bool[verticesCount];
            StringBuilder result = new StringBuilder();
            DFSHelper(src, visited, result);

            return result.ToString();
        }

        private void DFSHelper(int src, bool[] visited, StringBuilder result)
        {
            if (visited[src])
            {
                return;
            }
            else
            {
                visited[src] = true;
                result.AppendLine($"{verteceis[src]} = visited");
            }

            for (int i = 0; i < verticesCount; i++)
            {
                if (matrix[src, i] == 1 && !visited[i])
                {
                    DFSHelper(i, visited, result);
                }
            }
        }

        public string BreadthFirstSearch(int src)
        {
            if (src < 0 || src >= verticesCount) return string.Empty;

            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[verticesCount];
            StringBuilder result = new StringBuilder();

            queue.Enqueue(src);
            visited[src] = true;

            while (queue.Count != 0)
            {
                src = queue.Dequeue();
                result.AppendLine($"{verteceis[src]} = visited");

                for (int i = 0; i < verticesCount; i++)
                {
                    if (matrix[src, i] == 1 && !visited[i])
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
            return result.ToString();
        }
    }
}
