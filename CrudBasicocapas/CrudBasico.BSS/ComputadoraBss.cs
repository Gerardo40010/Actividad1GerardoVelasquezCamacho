using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudBasico.DAL;
using CrudBasico.Modelos;
namespace CrudBasico.BSS
{
    public class ComputadoraBss
    {
        ComputadoraDal dal = new ComputadoraDal();

        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadoraDal();
        }

        public void InsertarComputadoraBss(Computadora computadora)
        {
            dal.InsertarComputadoraDal(computadora);
        }

        public Computadora ObtenerComputadoraIdBss(int id)
        {
            return dal.ObtenerComputadoraIdDal(id);
        }

        public void EditarComputadoraBss(Computadora computadora)
        {
            dal.ActualizarComputadoraDal(computadora);
        }

        public void EliminarComputadoraBss(int id)
        {
            dal.EliminarComputadoraDal(id);
        }
    }
}
