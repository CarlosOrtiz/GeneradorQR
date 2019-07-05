using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace Proyecto.AccesoDatos.Conection
{
    public class Parametro
    {
        public string nombre { get; set; }
        public object valor { get; set; }
        public MySqlDbType tipo { get; set; }
        public ParameterDirection direccion { get; set; }

        public Parametro(string nombre, object valor, string tipo, ParameterDirection direccion)
        {
            this.nombre = nombre;
            this.valor = valor;
            this.tipo = this.MsyqlConversion(tipo);
            this.direccion = direccion;
        }
        public MySqlDbType MsyqlConversion(string type)
        {
            switch (type)
            {
                case "INTEGER":
                    return MySqlDbType.Int32;
                case "VARCHAR":
                    return MySqlDbType.VarChar;
                case "DATE":
                    return MySqlDbType.Date;
                case "DATETIME":
                    return MySqlDbType.DateTime;
                case "TIME":
                    return MySqlDbType.Time;
                case "CHAR":
                    return MySqlDbType.VarChar;
                case "BLOB":
                    return MySqlDbType.Blob;
                case "MEDIUMBLOB":
                    return MySqlDbType.MediumBlob;
                case "TEXT":
                    return MySqlDbType.Text;
                case "ENUM":
                    return MySqlDbType.Enum;
                default:
                    return MySqlDbType.VarChar;
            }
        }
    }
}