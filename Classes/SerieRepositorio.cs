using System;
using System.Collections.Generic;
using Projeto_DIO.Interfaces;

namespace Projeto_DIO
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> ListaSerie = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            ListaSerie[id] = entidade;
        }

        public void exclui(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere(Series entidade)
        {
            ListaSerie.Add( entidade);
        }

        public List<Series> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}