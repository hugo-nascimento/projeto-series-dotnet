using System.Collections.Generic;

namespace Projeto_Series___Dot_Net.interfaces
{
    public interface iRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}