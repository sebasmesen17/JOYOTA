<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bodega.aspx.cs" Inherits="DataPresentation.Bodega" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <center>
        <div class="Panel col-lg-5 col-md-5 col-sm-5 mt-4">
        <div class="card">
             <div class="card-header bg-info">
                 <h4 class="TextoContenido">Bodegas</h4>
             </div>
            <div class="card-body">
                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="ID Bodega" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbBodega" runat="server" CssClass="form-control" 
                                 placeholder="" />
                         </div>
                    </div>
                </div>

               <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Modelo" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbModelo" runat="server" CssClass="form-control" />
                         </div>
                    </div>
                </div>
                 <div class="form-group">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <asp:Button Text="Registrar" runat="server" CssClass="btn btn-outline-info" ID="btnregistrar" OnClick="btnregistrar_Click"/>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
    </center>


</asp:Content>
