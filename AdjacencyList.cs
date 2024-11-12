using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTA_LR_1
{
    public class AdjacencyList
    {
        private List<List<int>> adjacencyList;
        private bool isDirected;
        private string[] vertices;
        private int verticesCount;

        public AdjacencyList(int vertexCount, bool isDirected, string[] vertices)
        {
            verticesCount = vertexCount;
            this.isDirected = isDirected;
            adjacencyList = new List<List<int>>(verticesCount);
            for (int i = 0; i < vertexCount; i++)
            {
                adjacencyList.Add(new List<int>());
            }
            this.vertices = vertices;
        }

        public void AddEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
            if (!isDirected)
            {
                adjacencyList[destination].Add(source);
            }
        }

        public string GetAdjacencyListString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Список суміжності:");
            for (int i = 0; i < verticesCount; i++)
            {
                sb.Append(vertices[i] + ": ");
                foreach (var neighbor in adjacencyList[i])
                {
                    sb.Append(vertices[neighbor] + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public List<(int, int)> GetEdges()
        {
            List<(int, int)> edges = new List<(int, int)>();
            for (int i = 0; i < adjacencyList.Count; i++)
            {
                foreach (int neighbor in adjacencyList[i])
                {
                    edges.Add((i, neighbor));
                }
            }
            return edges;
        }
    }
}
