using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playgui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Green;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string lmao = textBox1.Text;
            string abc = "ABCDEFGHIJKLMNOOPQRSTUVWXYZ";
            for (int i = 0; i < lmao.Length; i++)
            {
                if (i <= lmao.Length - 3)
                {
                    if (lmao[i + 2].ToString() == " ")
                    {
                        label1.BackColor = Color.Red;
                    }
                    else if(!abc.Contains(lmao[i]))
                    {
                        label1.BackColor = Color.Blue;
                    }
                    else if (lmao[i]==lmao[i+1])
                    {
                        label1.BackColor=Color.Magenta;
                    }
                    else
                    {
                        label1.BackColor = Color.Green;
                    }
                }
                
            }
        }
    }
}
