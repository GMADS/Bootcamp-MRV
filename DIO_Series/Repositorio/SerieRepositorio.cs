using System.Collections.Generic;
using guilh.OneDrive.Documentos.BootCamp_MRV.DIO_Series.Interfaces;
using guilh.OneDrive.Documentos.BootCamp_MRV.Entidade;

namespace guilh.OneDrive.Documentos.BootCamp_MRV.DIO_Series.Repositorio
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualizar(int id, Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new System.NotImplementedException();
        }

        public int ProximoId()
        {
            throw new System.NotImplementedException();
        }

        public Serie RetornarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}