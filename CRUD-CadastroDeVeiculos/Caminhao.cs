using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CadastroDeVeiculos
{
    public class Caminhao : Veiculo
    {
        //ATRIBUTO EXCLUSIVO DE CAMINHÃO
        private int Toneladas { get; set; }

        //CRIANDO CONSTRUTOR
        public Caminhao(int id = 0, string modelo = null, string marca = null, int ano = 0, double preco = 0,int toneladas = 0)
        {
            this.Id = id;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Ano = ano;
            this.Preco = preco;
            this.Excluido = false;
            this.Toneladas = toneladas;
        }

        //MÉTODO ToString
        public override string ToString()
        {
            string retorno = "";
            retorno += "Id: " + this.Id + Environment.NewLine;
            retorno += "Modelo: " + this.Modelo + Environment.NewLine;
            retorno += "Marca: " + this.Marca + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Preço: " + this.Preco + Environment.NewLine;
            retorno += "Toneladas: " + this.Toneladas + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        public string RetornaModelo()
        {
            return this.Modelo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }
    }
}
