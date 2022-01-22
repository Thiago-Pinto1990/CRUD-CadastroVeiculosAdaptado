using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CadastroDeVeiculos
{
    public class CaminhaoRepositorio : IRepositorioCaminhao<Caminhao>
    {
        private List<Caminhao> ListaCaminhao = new List<Caminhao>();
        
        public void Atualiza(int id, Caminhao entidade)
        {
            ListaCaminhao[id] = entidade;
        }

        public void Exclui(int id)
        {
            ListaCaminhao[id].Exclui();
        }

        public void Insere(Caminhao entidade)
        {
            ListaCaminhao.Add(entidade);
        }

        public List<Caminhao> Lista()
        {
            return ListaCaminhao;
        }

        public int ProximoId()
        {
            return ListaCaminhao.Count;
        }

        public Caminhao RetornaPorId(int id)
        {
            return ListaCaminhao[id];
        }
    }
}
