using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CrudBasico.Modelos;
using System.Threading.Tasks;

namespace CrudBasico.DAL
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadoraDal()
        {
            string consulta = "SELECT * FROM Computadora";
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            return tabla;
        }

        public void InsertarComputadoraDal(Computadora computadora)
        {
            string consulta = "INSERT INTO Computadora (Nombre, Descripcion, Precio, FechaFabricacion, Estado) " +
              "VALUES ('" + computadora.Nombre + "', '" + computadora.Descripcion + "', " +
            "'" + computadora.Precio.ToString().Replace(",", ".") + "', '" + computadora.FechaFabricacion.ToString("yyyy-MM-dd") + "', 'Activo')";
            Conexion.Ejecutar(consulta);
        }

        public Computadora ObtenerComputadoraIdDal(int id)
        {
            string consulta = "SELECT * FROM Computadora WHERE ID = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Computadora computadora = null;
            if (tabla.Rows.Count > 0)
            {
                computadora = new Computadora();
                computadora.ID = Convert.ToInt32(tabla.Rows[0]["ID"]);
                computadora.Nombre = tabla.Rows[0]["Nombre"].ToString();
                computadora.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
                computadora.Precio = Convert.ToDecimal(tabla.Rows[0]["Precio"]);
                computadora.FechaFabricacion = Convert.ToDateTime(tabla.Rows[0]["FechaFabricacion"]);
            }
            return computadora;
        }

        public void ActualizarComputadoraDal(Computadora computadora)
        {
          string consulta = "UPDATE Computadora SET Nombre = '" + computadora.Nombre + "', " +
                 "Descripcion = '" + computadora.Descripcion + "', " +
                 "Precio = '" + computadora.Precio.ToString().Replace(",", ".") + "', " +
                 "FechaFabricacion = '" + computadora.FechaFabricacion.ToString("yyyy-MM-dd") + "' " +
                 "WHERE ID = " + computadora.ID;
            Conexion.Ejecutar(consulta);
        }

        public void EliminarComputadoraDal(int id)
        {
            string consulta = "DELETE FROM Computadora WHERE ID = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
