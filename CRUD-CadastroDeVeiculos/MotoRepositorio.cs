using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CadastroDeVeiculos
{
    public class MotoRepositorio : IRepositorioMoto<Moto>
    {
        private List<Moto> ListaMoto = new List<Moto>();
        
        public void Atualiza(int id, Moto entidade)
        {
            ListaMoto[id] = entidade;
        }

        public void Exclui(int id)
        {
            ListaMoto[id].Exclui();
        }

        public void Insere(Moto entidade)
        {
            ListaMoto.Add(entidade);
        }

        public List<Moto> Lista()
        {
            return ListaMoto;
        }

        public int ProximoId()
        {
            return ListaMoto.Count;
        }

        public Moto RetornaPorId(int id)
        {
            return ListaMoto[id];
        }
    }
}
