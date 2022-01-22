using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CadastroDeVeiculos
{
    public class CarroPasseioRepositorio : IRepositorioCarroPasseio<CarroPasseio>
    {
        private List<CarroPasseio> ListaCarro = new List<CarroPasseio>();//SUBSTITUI O BANCO DE DADOS

        public void Atualiza(int id, CarroPasseio entidade)
        {
            ListaCarro[id] = entidade;
        }

        public void Exclui(int id)
        {
            ListaCarro[id].Exclui();
        }

        public void Insere(CarroPasseio entidade)
        {
            ListaCarro.Add(entidade);
        }

        public List<CarroPasseio> Lista()
        {
            return ListaCarro;
        }

        public int ProximoId()
        {
            return ListaCarro.Count;
        }

        public CarroPasseio RetornaPorId(int id)
        {
            return ListaCarro[id];
        }
    }
}
