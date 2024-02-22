using Projeto_Controle_Vendas.br.com.ControlSale.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.br.com.ControlSale.DAO
{
    public class CustomerDAO
    {
        #region cadastrarCliente
        public void cadastrarCliente(Customer obj)
        {
            try
            {
                string sql = @"insert into tb_clientes (name,rg,cpf,email,phone,cellPhone,zipCode,street,number,district,complement,city,state)
                             values (@name,@rg,@cpf,@email,@phone,@cellPhone,@zipCode,@street,@number,@district,@complement,@city,@state)";

            }
            catch (Exception erro)
            {

                throw;
            }
        }
        #endregion

        //Metodo AlterarCliente

        //Metodo excluirCliente

        //Metodo listarCliente

        //Matodo buscarClientePorCpf
    }
}
