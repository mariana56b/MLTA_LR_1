namespace MLTA_LR_1
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBox = new System.Windows.Forms.PictureBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.rbOrientedGraph = new System.Windows.Forms.RadioButton();
            this.rbUndirectedGraph = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdjacencyList = new System.Windows.Forms.Button();
            this.btnEdgeList = new System.Windows.Forms.Button();
            this.btnIncidentMatrix = new System.Windows.Forms.Button();
            this.btnAdjacencyMatrix = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdjacencyListByIncidentMatrix = new System.Windows.Forms.Button();
            this.btnListOfEdgesByAdjacencyMatrix = new System.Windows.Forms.Button();
            this.btnAdjacencyMatrixByIncidentMatrix = new System.Windows.Forms.Button();
            this.btnAdjacencyListByAdjacencyMatrix = new System.Windows.Forms.Button();
            this.btnListOfEdgesByIncidentMatrix = new System.Windows.Forms.Button();
            this.btnIncidentMatrixByAdjacencyMatrix = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(242, 31);
            this.pBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(260, 242);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplay.Location = new System.Drawing.Point(510, 13);
            this.tbDisplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(466, 516);
            this.tbDisplay.TabIndex = 1;
            // 
            // rbOrientedGraph
            // 
            this.rbOrientedGraph.AutoSize = true;
            this.rbOrientedGraph.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrientedGraph.Location = new System.Drawing.Point(6, 24);
            this.rbOrientedGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbOrientedGraph.Name = "rbOrientedGraph";
            this.rbOrientedGraph.Size = new System.Drawing.Size(195, 26);
            this.rbOrientedGraph.TabIndex = 2;
            this.rbOrientedGraph.TabStop = true;
            this.rbOrientedGraph.Text = "Орієнтований граф";
            this.rbOrientedGraph.UseVisualStyleBackColor = true;
            this.rbOrientedGraph.CheckedChanged += new System.EventHandler(this.rbOrientedGraph_CheckedChanged);
            // 
            // rbUndirectedGraph
            // 
            this.rbUndirectedGraph.AutoSize = true;
            this.rbUndirectedGraph.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUndirectedGraph.Location = new System.Drawing.Point(6, 52);
            this.rbUndirectedGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbUndirectedGraph.Name = "rbUndirectedGraph";
            this.rbUndirectedGraph.Size = new System.Drawing.Size(215, 26);
            this.rbUndirectedGraph.TabIndex = 3;
            this.rbUndirectedGraph.TabStop = true;
            this.rbUndirectedGraph.Text = "Неорієнтований граф";
            this.rbUndirectedGraph.UseVisualStyleBackColor = true;
            this.rbUndirectedGraph.CheckedChanged += new System.EventHandler(this.rbUndirectedGraph_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdjacencyList);
            this.groupBox1.Controls.Add(this.btnEdgeList);
            this.groupBox1.Controls.Add(this.btnIncidentMatrix);
            this.groupBox1.Controls.Add(this.btnAdjacencyMatrix);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оберіть вивід";
            // 
            // btnAdjacencyList
            // 
            this.btnAdjacencyList.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjacencyList.Location = new System.Drawing.Point(6, 139);
            this.btnAdjacencyList.Name = "btnAdjacencyList";
            this.btnAdjacencyList.Size = new System.Drawing.Size(201, 31);
            this.btnAdjacencyList.TabIndex = 3;
            this.btnAdjacencyList.Text = "Список суміжності";
            this.btnAdjacencyList.UseVisualStyleBackColor = true;
            this.btnAdjacencyList.Click += new System.EventHandler(this.btnAdjacencyList_Click_1);
            // 
            // btnEdgeList
            // 
            this.btnEdgeList.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdgeList.Location = new System.Drawing.Point(5, 101);
            this.btnEdgeList.Name = "btnEdgeList";
            this.btnEdgeList.Size = new System.Drawing.Size(202, 31);
            this.btnEdgeList.TabIndex = 2;
            this.btnEdgeList.Text = "Список ребер";
            this.btnEdgeList.UseVisualStyleBackColor = true;
            this.btnEdgeList.Click += new System.EventHandler(this.btnEdgeList_Click_1);
            // 
            // btnIncidentMatrix
            // 
            this.btnIncidentMatrix.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentMatrix.Location = new System.Drawing.Point(5, 64);
            this.btnIncidentMatrix.Name = "btnIncidentMatrix";
            this.btnIncidentMatrix.Size = new System.Drawing.Size(202, 31);
            this.btnIncidentMatrix.TabIndex = 1;
            this.btnIncidentMatrix.Text = "Матриця інцидентності";
            this.btnIncidentMatrix.UseVisualStyleBackColor = true;
            this.btnIncidentMatrix.Click += new System.EventHandler(this.btnIncidentMatrix_Click_1);
            // 
            // btnAdjacencyMatrix
            // 
            this.btnAdjacencyMatrix.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjacencyMatrix.Location = new System.Drawing.Point(6, 25);
            this.btnAdjacencyMatrix.Name = "btnAdjacencyMatrix";
            this.btnAdjacencyMatrix.Size = new System.Drawing.Size(201, 31);
            this.btnAdjacencyMatrix.TabIndex = 0;
            this.btnAdjacencyMatrix.Text = "Матриця суміжності";
            this.btnAdjacencyMatrix.UseVisualStyleBackColor = true;
            this.btnAdjacencyMatrix.Click += new System.EventHandler(this.btnAdjacencyMatrix_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdjacencyListByIncidentMatrix);
            this.groupBox2.Controls.Add(this.btnListOfEdgesByAdjacencyMatrix);
            this.groupBox2.Controls.Add(this.btnAdjacencyMatrixByIncidentMatrix);
            this.groupBox2.Controls.Add(this.btnAdjacencyListByAdjacencyMatrix);
            this.groupBox2.Controls.Add(this.btnListOfEdgesByIncidentMatrix);
            this.groupBox2.Controls.Add(this.btnIncidentMatrixByAdjacencyMatrix);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 260);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оберіть перетворення";
            // 
            // btnAdjacencyListByIncidentMatrix
            // 
            this.btnAdjacencyListByIncidentMatrix.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjacencyListByIncidentMatrix.Location = new System.Drawing.Point(6, 215);
            this.btnAdjacencyListByIncidentMatrix.Name = "btnAdjacencyListByIncidentMatrix";
            this.btnAdjacencyListByIncidentMatrix.Size = new System.Drawing.Size(433, 32);
            this.btnAdjacencyListByIncidentMatrix.TabIndex = 9;
            this.btnAdjacencyListByIncidentMatrix.Text = "Побудувати список суміжності за матрицею інцидентності\r\n";
            this.btnAdjacencyListByIncidentMatrix.UseVisualStyleBackColor = true;
            this.btnAdjacencyListByIncidentMatrix.Click += new System.EventHandler(this.btnAdjacencyListByIncidentMatrix_Click);
            // 
            // btnListOfEdgesByAdjacencyMatrix
            // 
            this.btnListOfEdgesByAdjacencyMatrix.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOfEdgesByAdjacencyMatrix.Location = new System.Drawing.Point(6, 100);
            this.btnListOfEdgesByAdjacencyMatrix.Name = "btnListOfEdgesByAdjacencyMatrix";
            this.btnListOfEdgesByAdjacencyMatrix.Size = new System.Drawing.Size(433, 31);
            this.btnListOfEdgesByAdjacencyMatrix.TabIndex = 8;
            this.btnListOfEdgesByAdjacencyMatrix.Text = "Побудувати список ребер за матрицею суміжності \r\n";
            this.btnListOfEdgesByAdjacencyMatrix.UseVisualStyleBackColor = true;
            this.btnListOfEdgesByAdjacencyMatrix.Click += new System.EventHandler(this.btnListOfEdgesByAdjacencyMatrix_Click);
            // 
            // btnAdjacencyMatrixByIncidentMatrix
            // 
            this.btnAdjacencyMatrixByIncidentMatrix.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjacencyMatrixByIncidentMatrix.Location = new System.Drawing.Point(5, 63);
            this.btnAdjacencyMatrixByIncidentMatrix.Name = "btnAdjacencyMatrixByIncidentMatrix";
            this.btnAdjacencyMatrixByIncidentMatrix.Size = new System.Drawing.Size(433, 31);
            this.btnAdjacencyMatrixByIncidentMatrix.TabIndex = 7;
            this.btnAdjacencyMatrixByIncidentMatrix.Text = "Побудувати матрицю суміжності за матрицею інцидентності\r\n";
            this.btnAdjacencyMatrixByIncidentMatrix.UseVisualStyleBackColor = true;
            this.btnAdjacencyMatrixByIncidentMatrix.Click += new System.EventHandler(this.btnAdjacencyMatrixByIncidentMatrix_Click);
            // 
            // btnAdjacencyListByAdjacencyMatrix
            // 
            this.btnAdjacencyListByAdjacencyMatrix.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjacencyListByAdjacencyMatrix.Location = new System.Drawing.Point(5, 178);
            this.btnAdjacencyListByAdjacencyMatrix.Name = "btnAdjacencyListByAdjacencyMatrix";
            this.btnAdjacencyListByAdjacencyMatrix.Size = new System.Drawing.Size(433, 31);
            this.btnAdjacencyListByAdjacencyMatrix.TabIndex = 6;
            this.btnAdjacencyListByAdjacencyMatrix.Text = "Побудувати список суміжності за матрицею суміжності\r\n";
            this.btnAdjacencyListByAdjacencyMatrix.UseVisualStyleBackColor = true;
            this.btnAdjacencyListByAdjacencyMatrix.Click += new System.EventHandler(this.btnAdjacencyListByAdjacencyMatrix_Click);
            // 
            // btnListOfEdgesByIncidentMatrix
            // 
            this.btnListOfEdgesByIncidentMatrix.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOfEdgesByIncidentMatrix.Location = new System.Drawing.Point(6, 137);
            this.btnListOfEdgesByIncidentMatrix.Name = "btnListOfEdgesByIncidentMatrix";
            this.btnListOfEdgesByIncidentMatrix.Size = new System.Drawing.Size(433, 35);
            this.btnListOfEdgesByIncidentMatrix.TabIndex = 5;
            this.btnListOfEdgesByIncidentMatrix.Text = "Побудувати список ребер за матрицею інцидентності ";
            this.btnListOfEdgesByIncidentMatrix.UseVisualStyleBackColor = true;
            this.btnListOfEdgesByIncidentMatrix.Click += new System.EventHandler(this.btnListOfEdgesByIncidentMatrix_Click);
            // 
            // btnIncidentMatrixByAdjacencyMatrix
            // 
            this.btnIncidentMatrixByAdjacencyMatrix.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentMatrixByAdjacencyMatrix.Location = new System.Drawing.Point(6, 24);
            this.btnIncidentMatrixByAdjacencyMatrix.Name = "btnIncidentMatrixByAdjacencyMatrix";
            this.btnIncidentMatrixByAdjacencyMatrix.Size = new System.Drawing.Size(433, 33);
            this.btnIncidentMatrixByAdjacencyMatrix.TabIndex = 4;
            this.btnIncidentMatrixByAdjacencyMatrix.Text = "Побудувати матрицю інцидентності за матрицею суміжності\r\n";
            this.btnIncidentMatrixByAdjacencyMatrix.UseVisualStyleBackColor = true;
            this.btnIncidentMatrixByAdjacencyMatrix.Click += new System.EventHandler(this.btnIncidentMatrixByAdjacencyMatrix_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOrientedGraph);
            this.groupBox3.Controls.Add(this.rbUndirectedGraph);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оберіть тип графа";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.pBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.RadioButton rbOrientedGraph;
        private System.Windows.Forms.RadioButton rbUndirectedGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdjacencyList;
        private System.Windows.Forms.Button btnEdgeList;
        private System.Windows.Forms.Button btnIncidentMatrix;
        private System.Windows.Forms.Button btnAdjacencyMatrix;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIncidentMatrixByAdjacencyMatrix;
        private System.Windows.Forms.Button btnListOfEdgesByIncidentMatrix;
        private System.Windows.Forms.Button btnAdjacencyMatrixByIncidentMatrix;
        private System.Windows.Forms.Button btnAdjacencyListByAdjacencyMatrix;
        private System.Windows.Forms.Button btnAdjacencyListByIncidentMatrix;
        private System.Windows.Forms.Button btnListOfEdgesByAdjacencyMatrix;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}