<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PrivateViews/Admin.Master" AutoEventWireup="true" CodeBehind="ConsultarQR.aspx.cs" Inherits="GiecomQR.Views.PrivateViews.ConsultarQR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">
            <i style="padding-right: 5px;" class="fas fa-qrcode"></i><b>Consultar QR</b>
        </h1>
    </div>
    <div class="row col-lg-12">
        <div class="form-group col-lg-8">
            <div class="col-lg-8">
                <label class="h4 text-gray-900 ">Ingrese el numero de su cedula, para consultar el <b>código QR!</b> </label>
            </div>
   
            <div class="col-lg-8">
                <asp:TextBox style="margin-left:auto;margin-right:auto;" CssClass="form-control border-5 small col-md-12" ID="TextQR" TextMode="Number" MaxLength="11" runat="server"></asp:TextBox>
            </div>
      
            <div style="margin-top:8px;" class="col-lg-8 text-center">
                <asp:LinkButton runat="server" style="margin-left:auto;margin-right:auto;" ID="Btn_ConsQr" CssClass="btn btn-success btn-icon-split " OnClick="Btn_ConsQr_Click" >
                     <span class="icon text-white-50">
                      <i class="fas fa-check"></i>
                    </span>
                    <span class="text">Consultar Su QR</span>
                </asp:LinkButton>
            </div>
        </div>
        <br />
        <br />
        <div class="col-lg-4 text-center">
            <asp:Image  style="margin-left:auto;margin-right:auto;" runat="server" ID="ImgCons" /><br /><br />
            <asp:Label runat="server" style="margin-left:auto;margin-right:auto;font-weight:900;color:black;" ID="lbl_Nombre" ></asp:Label>
        </div>
    </div>
        
</asp:Content>
