using MySql.Data.MySqlClient;
using Proyecto.AccesoDatos.Conection;
using Proyecto.AccesoDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.AccesoDatos.Conection
{
    public class Datos : Connection, IDatos
    {
        //Realizar operaciones en la base de datos
        public bool OperarDatos(string sql)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, Conectar());
                if (comando.ExecuteNonQuery() > 0)
                {
                    Desconector();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Se crea para ejecutar procedimientos y devolver el mensaje, sin eliminar el metodo OperarDatos() para no generar conflictos
        //en el codigo que ya está hecho. Se podria usar el metodo ConsultarDatos(), pero no se hizo para evitar confusiones. Firma: JCMG
        public DataTable OperarProcedimiento(string sql)
        {
            DataTable datos = new DataTable();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Conectar());
                da.Fill(datos);
                Desconector();
                return datos;
            }
            catch
            {
                return null;
            }
        }

        //Realizar consulta en la base de datos.
        public DataTable ConsultarDatos(string sql)
        {
            DataTable datos = new DataTable();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Conectar());
                da.Fill(datos);
                Desconector();
                return datos;
            }
            catch
            {
                return null;
            }
        }

        public DataTable ExecuteProcedure(string procedure, List<Parametro> parametros)
        {
            MySqlCommand comando = new MySqlCommand(procedure, Conectar());
            comando.CommandType = CommandType.StoredProcedure;
            DataTable datos = new DataTable();
            if (parametros != null)
            {
                foreach (Parametro p in parametros)
                {
                    comando.Parameters.Add(new MySqlParameter(p.nombre, p.tipo));
                    comando.Parameters[p.nombre].Direction = p.direccion;
                    if (p.direccion == ParameterDirection.Input)
                    {
                        comando.Parameters[p.nombre].Value = p.valor;
                    }
                }
            }
            try
            {
                datos.Load(comando.ExecuteReader());
            }
            catch (Exception ex)
            {
                datos = this.ManejadorDeError(ex.Message);
            }
            finally
            {
                Desconector();
            }
            return datos;
        }
        public DataTable ManejadorDeError(string ef)
        {
            DataTable datos = new DataTable();
            datos.Columns.Add("TIPO");
            datos.Columns.Add("MENSAJE");
            datos.Columns.Add("VALORES");
            //dt.Rows.Add("Ha ocurrido un error, por favor verifique e intente nuevamente", "D");
            datos.Rows.Add("D", ef, "");
            return datos;
        }
    }
}