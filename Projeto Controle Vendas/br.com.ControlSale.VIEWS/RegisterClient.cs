using Projeto_Controle_Vendas.br.com.ControlSale.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.ControlSale.VIEWS
{
    public partial class RegisterClient : Form
    {
        public RegisterClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //1° passo - Armazenar os dados em um objeto model
            //Definir os dados necessários para pegar os atributos
            Customer obj = new Customer();
            obj.setName(txtName.Text);
        }

        private void textCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
