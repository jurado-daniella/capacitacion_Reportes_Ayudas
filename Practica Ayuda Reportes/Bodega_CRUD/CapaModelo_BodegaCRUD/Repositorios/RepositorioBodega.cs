using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using CapaModelo_BodegaCRUD.Contratos;
using CapaModelo_BodegaCRUD.Entidades;

namespace CapaModelo_BodegaCRUD.Repositorios
{
    // Implementa el CRUD real para la tabla "bodega", apoyandose en los
    // dos metodos genericos que ya trae RepositorioMaestro.
    public class RepositorioBodega : RepositorioMaestro, IRepositorioBodega
    {
        private readonly string selectAll;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;

        public RepositorioBodega()
        {
            selectAll = "SELECT id_bodega, id_sucursal, nombre_bodega, id_direccion, " +
                        "capacidad_bodega, telefono_bodega FROM bodega";

            insert = "INSERT INTO bodega (id_sucursal, nombre_bodega, id_direccion, " +
                     "capacidad_bodega, telefono_bodega) VALUES (?, ?, ?, ?, ?)";

            update = "UPDATE bodega SET id_sucursal = ?, nombre_bodega = ?, id_direccion = ?, " +
                     "capacidad_bodega = ?, telefono_bodega = ? WHERE id_bodega = ?";

            delete = "DELETE FROM bodega WHERE id_bodega = ?";
        }

        public int Agregar(Bodega entidad)
        {
            List<OdbcParameter> parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_IdSucursal", entidad.IdSucursal),
                new OdbcParameter("p_NombreBodega", entidad.NombreBodega),
                new OdbcParameter("p_IdDireccion", entidad.IdDireccion),
                new OdbcParameter("p_CapacidadBodega", entidad.CapacidadBodega),
                new OdbcParameter("p_TelefonoBodega", entidad.TelefonoBodega)
            };
            return EjecucionNonQuery(insert, parametros, CommandType.Text);
        }

        public int Editar(Bodega entidad)
        {
            List<OdbcParameter> parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_IdSucursal", entidad.IdSucursal),
                new OdbcParameter("p_NombreBodega", entidad.NombreBodega),
                new OdbcParameter("p_IdDireccion", entidad.IdDireccion),
                new OdbcParameter("p_CapacidadBodega", entidad.CapacidadBodega),
                new OdbcParameter("p_TelefonoBodega", entidad.TelefonoBodega),
                new OdbcParameter("p_IdBodega", entidad.IdBodega)
            };
            return EjecucionNonQuery(update, parametros, CommandType.Text);
        }

        public int Eliminar(Bodega entidad)
        {
            List<OdbcParameter> parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_IdBodega", entidad.IdBodega)
            };
            return EjecucionNonQuery(delete, parametros, CommandType.Text);
        }

        public IEnumerable<Bodega> ObtenerTodos()
        {
            List<Bodega> lstBodega = new List<Bodega>();
            DataTable tblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in tblTabla.Rows)
            {
                Bodega bodega = new Bodega();
                bodega.IdBodega = Convert.ToInt32(row["id_bodega"]);
                bodega.IdSucursal = Convert.ToInt32(row["id_sucursal"]);
                bodega.NombreBodega = row["nombre_bodega"].ToString();
                bodega.IdDireccion = Convert.ToInt32(row["id_direccion"]);
                bodega.CapacidadBodega = Convert.ToInt32(row["capacidad_bodega"]);
                bodega.TelefonoBodega = row["telefono_bodega"].ToString();
                lstBodega.Add(bodega);
            }
            tblTabla.Clear();
            return lstBodega;
        }
    }
}
