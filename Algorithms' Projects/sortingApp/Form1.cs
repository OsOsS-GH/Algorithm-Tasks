using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortingApp
{
    public partial class Form1 : Form
    {
        
        List<int> list = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (string s in textBox1.Text.Split())
            {
                list.Add(Convert.ToInt32(s));
            }

            for (int i = 1; i < list.Count; ++i)
            {
                int key = list[i];
                int j = i - 1;

                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }


            foreach (int i in list)
            {
                listBox1.Items.Add(i);
            }

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            list.Clear();
            listBox1.Items.Clear();
        }
    }
}
