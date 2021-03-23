using System;
using System.Windows.Forms;

using Calculos;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(textBox1.Text);
            int v2 = int.Parse(textBox2.Text);
            

            

            textBox3.Text = Operacoes.Soma(v1,v2).ToString();

            //MessageBox.Show("2+3=5");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(textBox1.Text);
            textBox3.Text = Operacoes.MySqrt(v1).ToString();

            
        }




        //public int Soma(int x, int y)
        //{
        //    return (x + y);
        //}
    }

    public class X : Operacoes
    {

        public X()
        {
            
        }
    }
}
