<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PrivateViews/Admin.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="GiecomQR.Views.PrivateViews.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Custom styles for this page -->
    <link href="vendor/datatables/dataTables.bootstrap4.min.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800"><i style="padding-right: 5px;" class="fas fa-user"></i><b>Usuarios</b></h1>
        <a href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i style="padding-right:5px;" class="fas fa-download fa-sm text-white-50"></i>Generate Report</a>
    </div>
    <!-- Page Heading -->

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
        <div style="text-align:center;" class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Todos Los Usuarios Con QR</h6>
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                    <thead>
                        <tr>
                            <th >NOMBRES</th>
                            <th>CORREO</th>
                            <th>ESTADO</th>
                            <th class="text-center">CÓDIGO QR</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>NOMBRES</th>
                            <th>CORREO</th>
                            <th>ESTADO</th>
                            <th  class="text-center">CÓDIGO QR</th>
                        </tr>
                    </tfoot>
                    <tbody>
                        <tr>
                            <td>Tiger Nixon</td>
                            <td>System Architect</td>
                            <td>Edinburgh</td>
                            <td class="text-center">
                                <a class="btn btn-warning btn-circle btn-sm">
                                    <i class="fas fa-exclamation-triangle"></i> </a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
