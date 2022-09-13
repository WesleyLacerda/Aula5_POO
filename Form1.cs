using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Time obj = new Time();
        Time[] v= new Time[10];
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
           //Time timinho=new Time("Brasil", "São Paulo"); //Declaração da classe = Chamando os valores do Construtor
           // MessageBox.Show("Nome: " + timinho.Nome + "\nPais: " + timinho.Pais + "\nEstado: " + timinho.Estado+
           //    "\nTitulos: " + timinho.Titulo);
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if(i < 10)
            {
                obj = new Time();
                obj.Nome = txtNome.Text;
                obj.Pais = txtPais.Text;
                obj.Estado = txtEstado.Text;
                obj.Titulo = Convert.ToInt32(txtTitulo.Text);
                v[i] = obj;
                i++;
            }
            else
            {
                MessageBox.Show("Não é possivel graver");
            }
        
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
          for(int j=0; j<10; j++)
            {
                if (v[j].Nome.Equals(txtNome.Text))
                {
                    txtEstado.Text = v[j].Estado;
                    txtPais.Text = v[j].Pais;
                    txtTitulo.Text = v[j].Titulo.ToString();
                    j = 9;
                }
                else
                {
                    if (j == 9) MessageBox.Show("Time não encontrado!");
                }
               
            }
        }
    }
}
