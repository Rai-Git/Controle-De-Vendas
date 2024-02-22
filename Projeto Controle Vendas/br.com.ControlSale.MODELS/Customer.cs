using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.br.com.ControlSale.MODELS
{
    public class Customer
    {
        //Atributos e os Getter / Setter
        // São necessários para pegar os dados da tela.

        public int code { get; set; }
        public string name { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string cellPhone { get; set; }
        public  string zipCode { get; set; }
        public string street { get; set; }
        public int number { get; set; }
        public string district { get; set; }
        public string complement { get; set; }
        public string city { get; set; }
        public string state { get; set; }


    }
}
