using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTA_LR_1
{
    public class EdgesList
    {
        private List<(int, int)> edges;
        private bool isDirected;
        private string[] vertices;

        public EdgesList(int verticesCount, bool isDirected, string[] vertices)
        {
            this.isDirected = isDirected;
            this.edges = new List<(int, int)>();
            this.vertices = vertices;
            
            // Перевірка на правильність кількості вершин
            if (vertices.Length != verticesCount)
            {
                throw new ArgumentException("Кількість вершин не відповідає заданому числу.");
            }
        }

        public void AddEdge(int source, int destination)
        {
            // Перевірка індексів для наявності помилок
            if (source < 0 || source >= vertices.Length || destination < 0 || destination >= vertices.Length)
            {
                throw new ArgumentException("Невірний індекс вершини.");
            }

            edges.Add((source, destination));
            if (!isDirected)
            {
                edges.Add((destination, source)); // Для неорієнтованого графа додаємо зворотне ребро
            }
        }

        public string GetEdgesListString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Список ребер:");
            foreach (var edge in edges)
            {
                // Форматування ребер для направленого або неорієнтованого графа
                if (isDirected)
                {
                    sb.AppendLine($"{vertices[edge.Item1]} -> {vertices[edge.Item2]}");
                }
                else
                {
                    sb.AppendLine($"{vertices[edge.Item1]} -- {vertices[edge.Item2]}");
                }
            }
            return sb.ToString();
        }
        public List<(int, int)> GetEdges() // Доданий метод GetEdges
        {
            return edges;
        }
    }
}
