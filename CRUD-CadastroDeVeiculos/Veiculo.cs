using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CadastroDeVeiculos
{
    public abstract class Veiculo
    {
        //ATRIBUTOS QUE SERÃO HERDADOS POR TODOS
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public bool Excluido { get; set; }

    }
}
