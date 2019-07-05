using GiecomQR.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GiecomQR.Views.PublicViews
{
    public partial class ConsultarQR : System.Web.UI.Page
    {
        ModelQR Modelo_QR = new ModelQR();
        DataTable DT_CONS, DT_Archivo = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Btn_ConsQr_Click(object sender, EventArgs e)
        {
            DT_CONS = Modelo_QR.ConsultarQR_ID(TextQR.Text);
            
            using (MemoryStream ms = new MemoryStream())
            {
                ImgCons.ImageUrl = "data:image/png;base64," + Convert.ToBase64String((byte[])DT_CONS.Rows[0]["ARCHIVO"]) ;
                ImgCons.Height = 200;
                ImgCons.Width = 200;

            }
        }
    }
}