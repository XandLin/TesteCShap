using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, media;
            nota1 = Convert.ToDouble(textNota1.Text);
            nota2 = Convert.ToDouble(textNota2.Text);
            nota3 = Convert.ToDouble(textNota3.Text);
            nota4 = Convert.ToDouble(textNota4.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            textMedia.Text = media.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNota1.Text = "";
            textNota2.Text = "";
            textNota3.Text = "";
            textNota4.Text = "";
            textMedia.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
