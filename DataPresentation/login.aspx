<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="DataPresentation.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<br />
     <div class="Panel col-lg-5 col-md-5 col-sm-5 mt-4">
         <center>

        <div class="card">
             <div class="card-header bg-info">
                 <h2 class="TextoContenido"> 
                       LOGIN
                 </h2>
             </div>

            <div class="card-body">
                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Correo" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbCorreo" runat="server" CssClass="form-control" 
                                 placeholder="Ex: Example@mailservice.com" />
                         </div>
                    </div>
                </div>
            
                <div class="form-group">
                    <div class="row">
                       <div class="col-lg-4 col-md-4 col-sm-4">
                          <asp:Label Text="Contraseña" runat="server" />
                       </div>

                       <div class ="col-lg-8 col-md-8 col-sm-8">
                          <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" CssClass="form-control" 
                               placeholder="Md4Ad2@q" />
                       </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <asp:Button ID="btnRVerificar" runat="server" Text="Verificar" OnClick="btnRVerificar_Click"></asp:Button>
                        </div>
                    </div>
                </div>
                
                <br />
                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <asp:LinkButton ID="lbntCrearUsuario" OnClick="lbntCrearUsuario_Click" runat="server">¿No tiene cuenta? Regístrarte</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <br />
                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                        </div>
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <asp:LinkButton ID="lbntEmpleadoLogin" OnClick="lbntEmpleadoLogin_Click" runat="server">Ingresar como administrador</asp:LinkButton>
                        </div>
                    </div>
                </div>

        </div>
     </center>
   </div>


</asp:Content>
