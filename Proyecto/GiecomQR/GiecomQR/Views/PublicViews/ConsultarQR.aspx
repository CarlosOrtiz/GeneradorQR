<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PublicViews/DefaulMaster.Master" AutoEventWireup="true" CodeBehind="ConsultarQR.aspx.cs" Inherits="GiecomQR.Views.PublicViews.ConsultarQR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center;">Consultar Codigos QR de Giecom ~ Free</h1>
    <br />
    <a href="http://191.102.85.226/GIECOM_PRUEBA/Views/PublicViews/main.aspx">Dar contribución</a>
    <br />
    <br />
    <asp:TextBox runat="server" ID="TextQR"></asp:TextBox>
    <asp:LinkButton style="padding-left:10px;"  runat="server" ID="Btn_ConsQr"  OnClick="Btn_ConsQr_Click" Text="Consultar " />
    <br />
    <br />
    <br />
    <br />
    <hr />
    <div style="text-align:center">
    <asp:Image runat="server" ID="ImgCons" />
    </div>

</asp:Content>
