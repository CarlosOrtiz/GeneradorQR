using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Proyecto.AccesoDatos;
using Proyecto.AccesoDatos.Conection;
using Proyecto.AccesoDatos.Interface;

namespace GiecomQR.Modelos
{
    public class ModelQR
    {
        string USU_CORREO { set; get; }
        string USU_CONTRASENA { set; get; }
        private IDatos dat = new Datos();


        public ModelQR()
        {
            USU_CONTRASENA = null;
            USU_CORREO = null;
        }

        public ModelQR(string con, string correo)
        {
            USU_CONTRASENA = con;
            USU_CORREO = correo;
        }

        public DataTable ConsultarUsuarios_ALL()
        {
            try
            {
                return dat.ConsultarDatos("CALL CONS_USUARIOS_ALL2 ()");
            }
            catch (Exception io)
            {
                Estructura err = new Estructura();
                return err.GetError(io.Message);
            }
        }


        //public DataTable SaveQrUser(string qr)
        //{
        //    try
        //    {
        //        return dat.OperarProcedimiento("CALL INSE_QR ('" + qr + "');");
        //    }
        //    catch (Exception io)
        //    {
        //        Estructura err = new Estructura();
        //        return err.GetError(io.Message);
        //    }
        //}

        public DataTable SaveQrUser(byte[] imagen)
        {
            try
            {
                List<Parametro> p = new List<Parametro>();
                p.Add(new Parametro("@VALOR", imagen, "MEDIUMBLOB", ParameterDirection.Input));
                return dat.ExecuteProcedure(" INSE_QR", p);
            }
            catch (Exception io)
            {
                Estructura err = new Estructura();
                return err.GetError(io.Message);
            }
        }
        public DataTable ConsultarQR_ID(string ID)
        {
            try
            {
                return dat.ConsultarDatos("CALL CONS_QR ('" + ID + "');");
            }
            catch (Exception io)
            {
                Estructura err = new Estructura();
                return err.GetError(io.Message);
            }
        }
    }
}