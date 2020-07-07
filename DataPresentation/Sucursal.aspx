<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sucursal.aspx.cs" Inherits="DataPresentation.Sucursal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
                    <center>
                        <div class="Panel col-lg-5 col-md-5 col-sm-5 mt-4">
                        <div class="card">
                             <div class="card-header bg-info">
                                 <h4 class="TextoContenido">Sucursal</h4>
                             </div>
                            <div class="card-body">

                 
                                <div class="form-group">  
                                    <div class="row">        
                                        <div class="col-lg-4 col-md-4 col-sm-4">
                                            <asp:Label Text="IDsucursal" runat="server" />
                                        </div>

                                         <div class ="col-lg-8 col-md-8 col-sm-8">
                                             <asp:DropDownList ID="ddlidsucursal" runat="server"  CssClass="form-control" />                             
                                         </div>                        
                                    </div>
                                </div>
                    <div class="form-group">  
                                    <div class="row">        
                                        <div class="col-lg-4 col-md-4 col-sm-4">
                                            <asp:Label Text="Nombre:" runat="server" />
                                        </div>

                                         <div class ="col-lg-8 col-md-8 col-sm-8">
                                             <asp:TextBox ID="tbnombre" runat="server"  CssClass="form-control" />                             
                                         </div>                        
                                    </div>
                                </div>
                    <div class="form-group">  
                                    <div class="row">        
                                        <div class="col-lg-4 col-md-4 col-sm-4">
                                            <asp:Label Text="Ubicación " runat="server" />
                                        </div>

                                         <div class ="col-lg-8 col-md-8 col-sm-8">
                                             <asp:TextBox ID="tbubicacion" runat="server"  CssClass="form-control" />                             
                                         </div>                        
                                    </div>
                                </div>
                    <div class="form-group">  
                                    <div class="row">        
                                        <div class="col-lg-4 col-md-4 col-sm-4">
                                            <asp:Label Text="Bodega ID: " runat="server" />
                                        </div>

                                         <div class ="col-lg-8 col-md-8 col-sm-8">
                                             <asp:DropDownList ID="DDLBodega" runat="server"  CssClass="form-control" />                             
                                         </div>                        
                                    </div>
                                </div>

                                  <div class="form-group">  
                                    <div class="row">        
                                         <div class ="col-lg-8 col-md-8 col-sm-8">
                                             <asp:GridView ID="gvproveedores" runat="server"  CssClass="form-control" />                             
                                         </div>                        
                                    </div>
                                </div>
                
                                </div>
                                <div class="form-group">

                                    <div class="row">

                                        <div class="col-lg-12 col-md-12 col-sm-12">
                                            <asp:Button Text="Insertar" runat="server" CssClass="btn btn-outline-info" OnClick="btninsertar_Click" ID="btninsertar"/>
                                        </div>
                                    </div>
                                </div>
                        </div>
                    </div>
     <div class="container">

</div>
                    </center>
</asp:Content>
