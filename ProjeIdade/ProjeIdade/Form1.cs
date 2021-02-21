using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia, mes, ano, diah, mesh, anoh, result;

            dia = Convert.ToInt32(textDia.Text);
            mes = Convert.ToInt32(textMes.Text);
            ano = Convert.ToInt32(textAno.Text);
            diah = Convert.ToInt32(textHojeDia.Text);
            mesh = Convert.ToInt32(textHojeMes.Text);
            anoh = Convert.ToInt32(textHojeAno.Text);


            result = ano - anoh;

            if (result <= 17)
            {
                result = 0;
                textResult.Text = result.ToString("Menor De Idade");
            }
            else if (result > 18)
                textResult.Text = result.ToString("Maior De Idade");
            else
            {
                result = 0;
                result = mes - mesh;
            }
            if (result < 0)
            {
                result = 0;
                result = dia - diah;
            }
            else
            {
                result = 0;
                textResult.Text = result.ToString("Maior De Idade");
            }
            if (result < 0 && result != 0)
            {
                result = 0;
                textResult.Text = result.ToString("Menor De Idade");
        }
            else
                textResult.Text = result.ToString("Feliz Aniversario");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDia.Text = "";
            textMes.Text = "";
            textAno.Text = "";
            textHojeDia.Text = "";
            textHojeMes.Text = "";
            textHojeAno.Text = "";
            textResult.Text = "";
        }
    }
}
