using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace MLTA_LR_1
{
    public partial class fMain : Form
    {
        private bool isDirected;
        static string[] getVertecies()
        {
            return new string[] { "a", "b", "c", "d", "e", "f" };
            //                    0    1    2    3    4    5                      
        }

        static int[,] select_edge_list(bool isDirected)
        {
            int[,] directedEdges = { { 0, 0 }, { 0, 5 }, { 1, 1 }, { 1, 0 }, { 1, 5 }, {  1, 3 }, 
                { 2, 0 }, { 2, 4 }, { 2, 3 }, { 3, 4 }  };
            int[,] notDirectedEdges = { { 0, 1 }, { 0, 2 }, { 0, 4 }, { 1, 4 }, { 1, 3 }, { 2, 2 },
                { 2, 3 }, { 2, 5 }, { 3, 5 }, { 3, 3 } };
            if (isDirected)
            {
                return directedEdges;
            }
            else
            {
                return notDirectedEdges;
            }
        }
        public AdjacencyList create_Adj_List(bool isDirected)
        {
            int[,] edge_list = select_edge_list(isDirected);
            string[] ver = getVertecies();
            AdjacencyList adj_list = new AdjacencyList(ver.GetLength(0), isDirected, ver);
            for (int i = 0; i < edge_list.GetLength(0); i++)
            {
                adj_list.AddEdge(edge_list[i, 0], edge_list[i, 1]);
            }
            return adj_list;

        }

        public EdgesList create_Edge_List(bool isDirected)
        {
            string[] ver = getVertecies();
            int[,] list = select_edge_list(isDirected);

            // Припускаємо, що verticesCount це кількість вершин
            EdgesList edge_list = new EdgesList(ver.Length, isDirected, ver);

            for (int i = 0; i < list.GetLength(0); i++)
            {
                edge_list.AddEdge(list[i, 0], list[i, 1]);
            }

            return edge_list;
        }

        public AdjacencyMatrix create_adj_Matrix(bool isDirected)
        {
            string[] ver = getVertecies();
            int[,] edge_list = select_edge_list(isDirected);
            AdjacencyMatrix adj_matrix = new AdjacencyMatrix(ver.GetLength(0), isDirected, ver);
            for (int i = 0; i < edge_list.GetLength(0); i++)
            {
                adj_matrix.AddEdge(edge_list[i, 0], edge_list[i, 1]);
            }
            return adj_matrix;
        }
        public IncidenceMatrix create_inc_Matrix(bool isDirected)
        {
            string[] ver = getVertecies();
            int[,] edge_list = select_edge_list(isDirected);
            IncidenceMatrix inc_Matrix = new IncidenceMatrix(ver.GetLength(0), edge_list.GetLength(0), isDirected, ver);
            for (int i = 0; i < edge_list.GetLength(0); i++)
            {
                inc_Matrix.AddEdge(edge_list[i, 0], edge_list[i, 1]);
            }
            return inc_Matrix;

        }
        public fMain()
        {
            InitializeComponent();
        }
        private void DisplayAdjList(bool isDirectedGraph)
        {
            var adjList = create_Adj_List(isDirectedGraph);
            tbDisplay.Clear();
            tbDisplay.AppendText("Список суміжності:\r\n");
            foreach (var edge in adjList.GetEdges())
            {
                tbDisplay.AppendText($"{edge.Item1} -> {edge.Item2}\r\n");
            }
        }

        private void DisplayEdgeList(bool isDirectedGraph)
        {
            var edgeList = create_Edge_List(isDirectedGraph);
            tbDisplay.Clear();
            tbDisplay.AppendText("Список ребер:\r\n");
            foreach (var edge in edgeList.GetEdges())
            {
                tbDisplay.AppendText($"{edge.Item1} - {edge.Item2}\r\n");
            }
        }
        private void DisplayAdjMatrix(bool isDirectedGraph)
        {
            var adjMatrix = create_adj_Matrix(isDirectedGraph);
            tbDisplay.Clear();
            tbDisplay.AppendText("Матриця суміжності:\r\n");

            // Перебір рядків і стовпців матриці
            for (int i = 0; i < adjMatrix.Size; i++)
            {
                string row = "";
                for (int j = 0; j < adjMatrix.Size; j++)
                {
                    row += adjMatrix.GetValue(i, j) + " ";
                }
                tbDisplay.AppendText(row.Trim() + "\r\n");
            }
        }

        private void DisplayIncMatrix(bool isDirectedGraph)
        {
            var incMatrix = create_inc_Matrix(isDirectedGraph);
            tbDisplay.Clear();
            tbDisplay.AppendText("Матриця інцидентності:\r\n");

            // Виведення матриці для кожного ряду
            for (int i = 0; i < incMatrix.EdgeCount; i++)
            {
                string row = "";
                for (int j = 0; j < incMatrix.VertexCount; j++)
                {
                    row += incMatrix.GetValue(j, i) + " ";  // Оновлено індекси
                }
                tbDisplay.AppendText(row.Trim() + "\r\n");
            }
        }


        private bool IsOrientedGraphSelected()
        {
            return rbOrientedGraph.Checked;
        }
        private void rbOrientedGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrientedGraph.Checked)
            {
                pBox.Image = Properties.Resources.orientedGraph;
                isDirected = true;
                tbDisplay.Clear();
            }
        }
        private void rbUndirectedGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUndirectedGraph.Checked)
            {
                pBox.Image = Properties.Resources.undirectedGraph;
                isDirected = false;
                tbDisplay.Clear();
            }
        }

        private void btnAdjacencyMatrix_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();

            // Додаємо заголовок перед викликом методу
            if (IsOrientedGraphSelected())
            {
                tbDisplay.AppendText("Матриця суміжності (Орієнтований граф)\r\n");
            }
            else
            {
                tbDisplay.AppendText("Матриця суміжності (Неорієнтований граф)\r\n");
            }

            // Тепер викликаємо метод без другого параметра
            DisplayAdjMatrix(isDirected);
        }

        private void btnIncidentMatrixByAdjacencyMatrix_Click_1(object sender, EventArgs e)
        {
            //if (IsOrientedGraphSelected())
            //{
            //    int[,] result = ConvertIncidenceToAdjacencyDirected(directedIncidenceMatrix);
            //    tbDisplay.Text = DisplayMatrix(result, "Перетворення матриці інцидентності в матрицю суміжності (Орієнтований граф)");
            //}
            //else
            //{
            //    int[,] result = ConvertIncidenceToAdjacency(incidenceMatrix);
            //    tbDisplay.Text = DisplayMatrix(result, "Перетворення матриці інцидентності в матрицю суміжності (Неорієнтований граф)");
            //}
        }

        private void btnIncidentMatrix_Click_1(object sender, EventArgs e)
        {
            tbDisplay.Clear();

            // Додаємо заголовок перед викликом методу
            if (IsOrientedGraphSelected())
            {
                tbDisplay.AppendText("Матриця інцидентності. Орієнтований граф\r\n");
            }
            else
            {
                tbDisplay.AppendText("Матриця інцидентності. Неорієнтований граф\r\n");
            }
            DisplayIncMatrix(isDirected);
        }

        private void btnEdgeList_Click_1(object sender, EventArgs e)
        {
            tbDisplay.Clear();

            // Додаємо заголовок перед викликом методу
            if (IsOrientedGraphSelected())
            {
                tbDisplay.AppendText("Список ребер. Орієнтований граф:\n");
            }
            else
            {
                tbDisplay.AppendText("Список ребер. Неорієнтований граф:\n");
            }

            // Тепер викликаємо метод без другого параметра
            DisplayEdgeList(isDirected);
        }

        private void btnAdjacencyList_Click_1(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();

            //if (IsOrientedGraphSelected())
            //{
            //    sb.AppendLine("Список суміжності. Орієнтований граф:");
            //    foreach (var vertex in directedAdjacencyList)
            //    {
            //        sb.AppendLine($"{vertex.Key}: {string.Join(", ", vertex.Value)}");
            //    }
            //}
            //else
            //{
            //    sb.AppendLine("Список суміжності. Неорієнтований граф:");
            //    foreach (var vertex in adjacencyList)
            //    {
            //        sb.AppendLine($"{vertex.Key}: {string.Join(", ", vertex.Value)}");
            //    }
            //}

            //tbDisplay.Text = sb.ToString();
        }

        private void btnAdjacencyMatrixByIncidentMatrix_Click(object sender, EventArgs e)
        {
            //if (IsDirectedGraphSelected())
            //{
            //    int[,] result = ConvertAdjacencyToIncidence(adjacencyMatrix, IsDirectedGraphSelected);
            //    tbDisplay.Text = DisplayMatrix(result, "Перетворення матриці суміжності в матрицю інцидентності (Орієнтований граф)");
            //}
            //else
            //{
            //    int[,] result = ConvertAdjacencyToIncidence(adjacencyMatrix, IsDirectedGraphSelected);
            //    tbDisplay.Text = DisplayMatrix(result, "Перетворення матриці суміжності в матрицю інцидентності (Неорієнтований граф)");
            //}
        }

        private void btnListOfEdgesByAdjacencyMatrix_Click(object sender, EventArgs e)
        {
            //if (IsDirectedGraphSelected())
            //{
            //    List<Tuple<int, int>> result = ConvertAdjacencyToEdgeList(directedAdjacencyMatrix);
            //    DisplayEdgeList(result, "Перетворення матриці суміжності в список ребер (Орієнтований граф)");
            //}
            //else
            //{
            //    List<Tuple<int, int>> result = ConvertAdjacencyToEdgeList(adjacencyMatrix);
            //    DisplayEdgeList(result, "Перетворення матриці суміжності в список ребер (Неорієнтований граф)");
            //}
        }

        private void btnListOfEdgesByIncidentMatrix_Click(object sender, EventArgs e)
        {
            //if (IsDirectedGraphSelected())
            //{
            //    List<Tuple<int, int>> result = ConvertIncidenceToEdgeList(directedIncidenceMatrix);
            //    DisplayEdgeList(result, "Перетворення матриці інцидентності в список ребер (Орієнтований граф)");
            //}
            //else
            //{
            //    List<Tuple<int, int>> result = ConvertIncidenceToEdgeList(incidenceMatrix);
            //    DisplayEdgeList(result, "Перетворення матриці інцидентності в список ребер (Неорієнтований граф)");
            //}
        }

        private void btnAdjacencyListByAdjacencyMatrix_Click(object sender, EventArgs e)
        {
            //if (IsDirectedGraphSelected())
            //{
            //    Dictionary<int, List<int>> result = ConvertAdjacencyToAdjacencyList(directedAdjacencyMatrix);
            //    DisplayAdjacencyList(result, "Перетворення матриці суміжності в список суміжності (Орієнтований граф)");
            //}
            //else
            //{
            //    Dictionary<int, List<int>> result = ConvertAdjacencyToAdjacencyList(adjacencyMatrix);
            //    DisplayAdjacencyList(result, "Перетворення матриці суміжності в список суміжності (Неорієнтований граф)");
            //}
        }

        private void btnAdjacencyListByIncidentMatrix_Click(object sender, EventArgs e)
        {
            //if (IsDirectedGraphSelected())
            //{
            //    Dictionary<int, List<int>> result = ConvertIncidenceToAdjacencyList(directedIncidenceMatrix);
            //    DisplayAdjacencyList(result, "Перетворення матриці інцидентності в список суміжності (Орієнтований граф)");
            //}
            //else
            //{
            //    Dictionary<int, List<int>> result = ConvertIncidenceToAdjacencyList(incidenceMatrix);
            //    DisplayAdjacencyList(result, "Перетворення матриці інцидентності в список суміжності (Неорієнтований граф)");
            //}
        }
    }



}
