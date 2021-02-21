using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = textUsuario.Text;
            senha = textSenha.Text;
            if (usuario == "admin" && senha == "admin")
            { 
                  Form2 novo = new Form2();
                    novo.Show();
                    this.Visible = false;
               
            }
        }
    }
}
