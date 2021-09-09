using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1._31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int matrixSize = Convert.ToInt32(InputSize.Value);
            TableInput.Columns.Clear();
            for (int i = 0; i < matrixSize; i++)
            {
                DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
                dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
                TableInput.Columns.Add(dataGridViewColumn);
            }

            int[,] matrix = generateMatrix(matrixSize);
            showMatrix(matrix, TableInput);
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            int[,] matrix = transformMatrix();
            TableOutput.Columns.Clear();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
                dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
                TableOutput.Columns.Add(dataGridViewColumn);
            }
            showMatrix(matrix,TableOutput);
        }

        private int[,] generateMatrix(int size)
        {
            Random random = new Random();
            int[,] matrix = new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }
            return matrix;
        }

        private void showMatrix(int[,] matrix,DataGridView table)
        {
            string[] values = new string[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    string value = Convert.ToString(matrix[i, j]);
                    values[j] = value;
                }
                table.Rows.Add(values);
            }
        }

        private int[,] getMatrix()
        {
            int[,] matrix = new int[TableInput.ColumnCount, TableInput.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(TableInput[j, i].Value);
                }
            }
            return matrix;
        }

        private int[,] transformMatrix()
        {
            int[,] matrix = getMatrix();
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                        matrix[i, j] -= matrix[matrix.GetLength(0) - 1, j]; 
                }
            }
            return matrix;
        }
    }

}
