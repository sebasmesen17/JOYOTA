<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginEmp.aspx.cs" Inherits="DataPresentation.LoginEmp" %>
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
                            <asp:Label Text="Nombre" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbNombre" runat="server" CssClass="form-control" 
                                 placeholder="Ex: Geovanni Álvarez" />
                         </div>
                    </div>
                </div>
            
                <div class="form-group">
                    <div class="row">
                       <div class="col-lg-4 col-md-4 col-sm-4">
                          <asp:Label Text="ID" runat="server" />
                       </div>

                       <div class ="col-lg-8 col-md-8 col-sm-8">
                          <asp:TextBox ID="tbID" runat="server" CssClass="form-control" 
                               placeholder="01" />
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
        </div>
     </center>
   </div>

</asp:Content>
