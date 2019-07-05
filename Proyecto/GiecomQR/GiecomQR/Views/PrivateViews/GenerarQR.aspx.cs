using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GiecomQR.Modelos;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace GiecomQR.Views.PrivateViews
{
    public partial class GenerarQR : System.Web.UI.Page
    {
        ModelQR Modelo_QR = new ModelQR();
        DataTable DT, DT_AUX = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btn_GenerarQr_Click(object sender, EventArgs e)
        {
            DT = Modelo_QR.ConsultarUsuarios_ALL();

            QRCodeEncoder encoder = new QRCodeEncoder();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                Bitmap imgBit = encoder.Encode(DT.Rows[i]["NOMBRE"].ToString());
                System.Drawing.Image QR = (System.Drawing.Image)imgBit;
                using (MemoryStream ms = new MemoryStream())
                {
                    QR.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();

                    DT_AUX = Modelo_QR.SaveQrUser(imageBytes);

                    var fromAddress = new MailAddress("elcurioso03042018@gmail.com", "CÓDIGO QR DE GIECOM");
                    var toAddress = new MailAddress(DT.Rows[i]["CORREO"].ToString(), "To Name");
                    string fromPassword = "Elcurioso2018";
                    string subject = "Su código QR";
                    string body = String.Format(
                        "Estimado/a  Ingeniero " + DT.Rows[i]["NOMBRE"].ToString() + "{0}{0}{0}{0}{0}{0}{0}{0}" +
                        "Le damos la bienvenida al nuevo software de enventos," +
                        "{0}El presente código QR es para el evento en el cual usted se encuentra inscrito.{0}{0}{0}" +
                        "<div style='text-align:center;padding:5%;'> " +
                        "<img src='data:image/git;base64," + Convert.ToBase64String(imageBytes) + "'/>" +
                        "</br>" +
                        "<a href='data:image/git;base64," + Convert.ToBase64String(imageBytes) + "' target='_blank' > DESCARGAR QR </a>" +
                        "</div> " +
                        "{0}{0}Att. Equipo de Desarrollo del Grupo de Investigación GIECOM", Environment.NewLine);

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        IsBodyHtml = true,
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "script1",
                        "swal('Exito!', '" + "Se han generado todos los códigos QR correctamente y se le ha enviado un link al correo institucional" +
                 "', 'success');", true);

                }
            }
        }
    }
}