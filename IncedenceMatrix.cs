using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTA_LR_1
{
    public class IncidenceMatrix
    {
        private int[,] matrix;
        private int verticesCount;
        private int edgesCount; // Лічильник для кількості ребер
        private bool isDirected;
        private string[] vertices;
        private List<string> edges = new List<string>();

        public IncidenceMatrix(int vertices, int edges, bool isDirected, string[] verticesNames)
        {
            this.isDirected = isDirected;
            verticesCount = vertices;
            edgesCount = edges; // Ініціалізуємо лічильник кількості ребер
            matrix = new int[vertices, edges]; // Ініціалізація матриці
            this.vertices = verticesNames;
        }

        // Властивість для отримання кількості вершин
        public int VertexCount => verticesCount;

        // Властивість для отримання кількості ребер
        public int EdgeCount => edgesCount; // Повертає кількість ребер

        // Метод для отримання значення матриці
        public int GetValue(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return 0; // або інше значення за замовчуванням
            }

            return matrix[row, col];
        }

        public void AddEdge(int source, int destination)
        {
            if (edgesCount >= matrix.GetLength(1))
            {
                Console.WriteLine("Неможливо додати більше ребер, ніж дозволено.");
                return;
            }

            if (isDirected)
            {
                matrix[source, edgesCount] = 1;
                matrix[destination, edgesCount] = -1;
            }
            else
            {
                matrix[source, edgesCount] = 1;
                matrix[destination, edgesCount] = 1;
            }
            edgesCount++;
            edges.Add($"{vertices[source]}-{vertices[destination]}");
        }

        public string GetIncidenceMatrixAsString()
        {
            string result = "Матриця інцидентності:\r\n   ";

            foreach (var edge in edges)
            {
                result += edge.PadRight(4);
            }
            result += "\r\n";

            for (int i = 0; i < verticesCount; i++)
            {
                result += vertices[i] + "  ";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += matrix[i, j].ToString().PadRight(4);
                }
                result += "\r\n";
            }

            return result;
        }

        // Для виведення списку ребер
        public string ToEdgeListString()
        {
            var edgeList = ToEdgeList();
            string result = "Список ребер:\r\n";

            foreach (var edge in edgeList.GetEdges())
            {
                result += $"{vertices[edge.Item1]} - {vertices[edge.Item2]}\r\n";
            }

            return result;
        }

        // Для виведення матриці суміжності
        public string ToAdjMatrixString()
        {
            var adjMatrix = ToAdjMatrix();
            string result = "Матриця суміжності:\r\n";

            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = 0; j < verticesCount; j++)
                {
                    result += adjMatrix.GetValue(i, j) + " ";
                }
                result += "\r\n";
            }

            return result;
        }

        // Для виведення списку суміжності
        public string ToAdjListString()
        {
            var adjList = ToAdjList();
            string result = "Список суміжності:\r\n";

            foreach (var vertexEdges in adjList.GetEdges())
            {
                result += $"{vertices[vertexEdges.Item1]} -> {vertices[vertexEdges.Item2]}\r\n";
            }

            return result;
        }

        // Перетворення в список ребер
        private EdgesList ToEdgeList()
        {
            var edgeList = new EdgesList(verticesCount, isDirected, vertices);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int source = -1;
                int destination = -1;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 1 && source == -1)
                    {
                        source = i;
                    }
                    else if ((matrix[i, j] == -1 && isDirected) || (matrix[i, j] == 1 && !isDirected && source != i))
                    {
                        destination = i;
                    }
                }

                if (source != -1 && destination != -1)
                {
                    edgeList.AddEdge(source, destination);
                }
            }
            return edgeList;
        }

        // Перетворення в матрицю суміжності
        private AdjacencyMatrix ToAdjMatrix()
        {
            int[,] adjMatrix = new int[verticesCount, verticesCount];

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int source = -1;
                int destination = -1;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 1 && source == -1)
                    {
                        source = i;
                    }
                    else if ((matrix[i, j] == -1 && isDirected) || (matrix[i, j] == 1 && !isDirected && source != i))
                    {
                        destination = i;
                    }
                }

                if (source != -1 && destination != -1)
                {
                    adjMatrix[source, destination] = 1;
                    if (!isDirected)
                    {
                        adjMatrix[destination, source] = 1;
                    }
                }
            }

            var adjMatrixClass = new AdjacencyMatrix(verticesCount, isDirected, vertices);

            // Записуємо значення в кожну клітинку матриці
            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = 0; j < verticesCount; j++)
                {
                    adjMatrixClass.SetMatrix(i, j, adjMatrix[i, j]);
                }
            }

            return adjMatrixClass;
        }

        // Перетворення в список суміжності
        private AdjacencyList ToAdjList()
        {
            var adjList = new AdjacencyList(verticesCount, isDirected, vertices);

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int source = -1;
                int destination = -1;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == 1 && source == -1)
                    {
                        source = i;
                    }
                    else if ((matrix[i, j] == -1 && isDirected) || (matrix[i, j] == 1 && !isDirected && source != i))
                    {
                        destination = i;
                    }
                }

                if (source != -1 && destination != -1)
                {
                    adjList.AddEdge(source, destination);
                    if (!isDirected)
                    {
                        adjList.AddEdge(destination, source);
                    }
                }
            }

            return adjList;
        }
    }


}
