<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proveedores.aspx.cs" Inherits="DataPresentation.Proveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <div class="Panel col-lg-5 col-md-5 col-sm-5 mt-4">
        <div class="card">
             <div class="card-header bg-info">
                 <h4 class="TextoContenido">Proveedores</h4>
             </div>
            <div class="card-body">
                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Cedula Jurídica" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbCedulaJuridica" runat="server" CssClass="form-control" 
                                 placeholder="112341234" />
                         </div>
                    </div>
                </div>

               <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Nombre" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbNombre" runat="server" CssClass="form-control" />
                         </div>
                    </div>
                </div>

                 <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Dirección" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbdireccion" runat="server" CssClass="form-control" 
                                 placeholder="Ex: Orotina, Alajuela." />
                         </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Contacto" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbContacto" runat="server" CssClass="form-control" />
                         </div>
                    </div>
                </div>

              

                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <asp:Button Text="Registrar" runat="server" CssClass="btn btn-outline-info" ID="tbregistrar" OnClick="tbregistrar_Click"/>
                        </div>



                    </div>
                        <div>
                            <asp:GridView ID="GVProveedor" runat="server"></asp:GridView>

                        </div>
                    </div>
                </div>
    </center>
</asp:Content>
