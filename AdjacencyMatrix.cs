using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTA_LR_1
{
    public class AdjacencyMatrix
    {
        private int[,] matrix;
        private int verticesCount;
        private bool isDirected;
        private string[] vertices;

        public AdjacencyMatrix(int verticesCount, bool isDirected, string[] vertices)
        {
            this.isDirected = isDirected;
            this.verticesCount = verticesCount;
            matrix = new int[verticesCount, verticesCount];
            this.vertices = vertices;
        }

        public void AddEdge(int source, int destination)
        {
            matrix[source, destination] = 1;
            if (!isDirected)  // Для неорієнтованого графа
            {
                matrix[destination, source] = 1;  // Додаємо зворотній бік
            }
        }

        public int Size => matrix.GetLength(0);

        public IncidenceMatrix ToIncidenceMatrix()
        {
            int edgesCount = 0;
            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = (isDirected ? 0 : i); j < verticesCount; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        edgesCount++;
                    }
                }
            }
            IncidenceMatrix incMatrix = new IncidenceMatrix(verticesCount, edgesCount, isDirected, vertices);
            int edgeIndex = 0;
            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = (isDirected ? 0 : i); j < verticesCount; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        incMatrix.AddEdge(i, j);
                        edgeIndex++;
                    }
                }
            }
            return incMatrix;
        }

        public AdjacencyList ToAdjacencyList()
        {
            var adjList = new AdjacencyList(verticesCount, isDirected, vertices);

            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = 0; j < verticesCount; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        adjList.AddEdge(i, j);
                    }
                }
            }
            return adjList;
        }

        public EdgesList ToEdgesList()
        {
            // Використовуємо масив 'vertices', який вже є в класі
            var edgeList = new EdgesList(verticesCount, isDirected, vertices);

            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = (isDirected ? 0 : i); j < verticesCount; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        edgeList.AddEdge(i, j);
                    }
                }
            }
            return edgeList;
        }


        public string GetMatrixString()
        {
            var sb = new StringBuilder();
            sb.Append("    ");
            for (int i = 0; i < verticesCount; i++)
            {
                sb.Append($"{vertices[i]}  ");
            }
            sb.AppendLine();

            for (int i = 0; i < verticesCount; i++)
            {
                sb.Append($"{vertices[i]} ");
                for (int j = 0; j < verticesCount; j++)
                {
                    sb.Append($"{matrix[i, j],3}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        // Додаткові методи для доступу до елементів матриці
        public int GetValue(int row, int col)
        {
            return matrix[row, col];
        }

        public void SetMatrix(int row, int col, int value)
        {
            matrix[row, col] = value;
        }
    }
}
