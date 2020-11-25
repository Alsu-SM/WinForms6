using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<Point> LP = new List<Point>();
        Graphics gr;
        Graph g;

        public Graph Initialize(string FileName)
        {
            string[] split;
            StreamReader reader = new StreamReader(FileName);
            string currentString = reader.ReadLine(); // прочитали первую строку, где лежит количество вершин
            int NodesNumber = Int32.Parse(currentString);

            int[,] M = new int[NodesNumber, NodesNumber];

            for (int i = 0; i < NodesNumber; i++)
            {
                currentString = reader.ReadLine();
                split = currentString.Split(' '); //разделяем строку по пробелам
                for (int j = 0; j < NodesNumber; j++)
                    M[i, j] = Int32.Parse(split[j]);
            }

            Graph G = new Graph(NodesNumber, M);
            return G;

        }

        private void DrawGraph(Graph g)
        {
            pictureBox1.Refresh();
            LP.Clear();
            
            Point center = new Point(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2); // устанавливаем точку в центр пикчербокса
            double alpha = 2 * Math.PI / g.funcNodeCount;
            int radius = (int)(Math.Min(pictureBox1.Size.Width, pictureBox1.Size.Height) * 0.75) / 2;


            for (int i = 0;  i < g.funcNodeCount; i++)
            {
                LP.Add(new Point(center.X + (int)(Math.Cos(alpha*i)*radius), center.Y - (int)(Math.Sin(alpha * i) * radius)));
            }

            gr = pictureBox1.CreateGraphics();

            for(int i = 0; i < g.funcNodeCount; i++) // если есть ребро, рисуем линию
            {
                for(int j = 0; j < g.funcNodeCount; j++)
                {
                    if (g.IsEdge(i, j))
                        gr.DrawLine(new Pen(Color.Green), LP[i], LP[j]);
                }
            }

            for (int i = 0; i < g.funcNodeCount; i++) // ставим точки в места вершин
            {
                gr.DrawEllipse(new Pen(Color.Red), LP[i].X - 2, LP[i].Y - 2, 4, 4);
                gr.FillEllipse(new SolidBrush(Color.Red), LP[i].X - 2, LP[i].Y - 2, 4, 4);
            }
        }


        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private void чтениеИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                // label1.Text = openFileDialog1.FileName;
                richTextBox1.Text = sr.ReadToEnd();
                g = Initialize(openFileDialog1.FileName);
                DrawGraph(g);
                if (g.IsBigraph(g.tempBigraph()))
                    label4.Text = "да";
                else
                    label4.Text = "нет";

                if (g.IsEuler())
                    label5.Text = "да";
                else
                    label5.Text = "нет";

                sr.Close();
            }
        }

        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private void сохранениеВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
              
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.Close();
            }
        }

        private void updateTextBox()
        {
            string str = g.funcNodeCount.ToString();
            for (int i = 0; i < g.funcNodeCount; i++)
            {
                str += "\n";
                for (int j = 0; j < g.funcNodeCount; j++)
                    str += g.funcMatrix[i, j].ToString() + " ";
            }
            richTextBox1.Text = str;
            if (g.IsBigraph(g.tempBigraph()))
                label4.Text = "да";
            else
                label4.Text = "нет";

            if (g.IsEuler())
                label5.Text = "да";
            else
                label5.Text = "нет";


        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьВершинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.AddNode();
            DrawGraph(g);
            updateTextBox();
        }

        private void добавитьРеброToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int[] newTemp = new int[2];
                newTemp[0] = Int32.Parse(textBox1.Text);
                newTemp[1] = Int32.Parse(textBox2.Text);

                if (g.IsNode(newTemp[0]) == true && g.IsNode(newTemp[1]) == true)
                {
                    g.AddEdge(newTemp[0], newTemp[1]);
                    DrawGraph(g);
                    updateTextBox();
                }
            }

        }

        private void удалитьВершинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int NodeNum;
                NodeNum = Int32.Parse(textBox3.Text);
                if(g.IsNode(NodeNum))
                {
                    g.RemoveNode(NodeNum);
                    DrawGraph(g);
                    updateTextBox();
                }
            }


        }

        private void удалитьРеброToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int[] newTemp = new int[2];
                newTemp[0] = Int32.Parse(textBox1.Text);
                newTemp[1] = Int32.Parse(textBox2.Text);

                if (g.IsNode(newTemp[0]) == true && g.IsNode(newTemp[1]) == true)
                {
                    g.RemoveEdge(newTemp[0], newTemp[1]);
                    DrawGraph(g);
                    updateTextBox();
                }
            }
        }
    }
}
