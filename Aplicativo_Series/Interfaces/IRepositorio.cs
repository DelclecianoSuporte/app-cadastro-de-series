using System;
using System.Collections.Generic;

namespace Aplicativo_Series
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(Serie objeto);
        void Exclui(int id);
        void Atualiza(int id, Serie objeto);
        int ProximoId();
    }
}
