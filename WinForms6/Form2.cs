using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int[] temp = new int[2];

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                temp[0] = Int32.Parse(textBox1.Text);
                temp[1] = Int32.Parse(textBox2.Text);

                // this.Close();
                label3.Text = temp[0].ToString() + " " + temp[1].ToString();
            }
      
        }

        public int[] funcTemp // возвращает количество вершин графа
        {
            get { return temp; }
        }
    }
}
