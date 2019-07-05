<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PrivateViews/Admin.Master" AutoEventWireup="true" CodeBehind="GenerarQR.aspx.cs" Inherits="GiecomQR.Views.PrivateViews.GenerarQR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800"><i style="padding-right: 5px;" class="fas fa-code"></i><b>Generar QR</b></h1>
    </div>
    <div class="row col-lg-12">
        <div class="form-group col-lg-12">
            <div class="col-lg-12">
                <label class="h4 text-gray-900 ">Oprima el siguente boton para generar todos <b>código QR!</b></label>
            </div>
            <div style="padding-left:15px;" class="col-lg-12">
                <asp:LinkButton Style="font-weight: 500; border-radius: 10px; margin-left: auto; margin-right: auto;" CssClass="btn btn-success btn-icon-split" runat="server" ID="Btn_GenerarQr" OnClick="Btn_GenerarQr_Click">
                    <span class="icon text-white-50">
                      <i class="fas fa-check"></i>
                    </span>
                    <span class="text">Generar Códigos QR</span>
                </asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
