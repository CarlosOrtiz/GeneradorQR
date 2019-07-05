<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PublicViews/DefaulMaster.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="GiecomQR.Views.PublicViews.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1 style="text-align: center;">Generador de QR de Giecom ~ Free</h1>
    <br />
    <div style="text-align: center;">
        <a href="http://191.102.85.226/GIECOM_PRUEBA/Views/PublicViews/main.aspx">
            <asp:Image runat="server" Style="text-align: center; margin-left: auto; margin-right: auto;" ImageAlign="Middle" Width="300" ID="IMGLOGO" ImageUrl="~/Imagen/logo_giecom.png" AlternateText="Logo_Pagina" />
        </a>
    </div>

    <div style="text-align: center; padding: 3%;">
        <h3></h3>

        <asp:LinkButton Style="font-weight: 500; border-radius: 10px;" class="btn btn-success" runat="server" ID="Btn_GenerarQr" OnClick="Btn_GenerarQr_Click" Text="Generar QR" />
    </div>
    <br />
    <br />
    <br />
    <a href="ConsultarQR.aspx">Consultar QR De La Persona</a>
    <hr />
    <div style="text-align: center;">
        <asp:Image runat="server" ID="ImgQr" />
    </div>
</asp:Content>
