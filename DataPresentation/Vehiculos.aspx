<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vehiculos.aspx.cs" Inherits="DataPresentation.Vehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
         <div class="Panel col-lg-5 col-md-5 col-sm-5 mt-4">
        <div class="card">
             <div class="card-header bg-info">
                 <h4 class="TextoContenido">Registros</h4>
             </div>
            <div class="card-body">

                  <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Sucursal a la que se registra el vehículo: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:DropDownList ID="DDLSucursal" runat="server"  CssClass="form-control" />                             
                         </div>                        
                    </div>
                </div>
                 
                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Identificador del Vehículo: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbIDvehiculo" runat="server" CssClass="form-control"  />                             
                         </div>                        
                    </div>
                </div>

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Marca: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:DropDownList ID="DDLmarca" runat="server"  CssClass="form-control" />                             
                         </div>                        
                    </div>
                </div>

                  <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Modelo: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:DropDownList ID="DDLmodelo" runat="server" CssClass="form-control"  />                             
                         </div>                        
                    </div>
                </div>




                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Año: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:DropDownList ID="DDLAño" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Color: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:DropDownList ID="DDLColor" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Categoria: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:DropDownList ID="DDLCategoria" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>


                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="IDentificador de barra: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbCodigoBarra" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Precio de compra: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbpreciocompra" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>

              

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Impuesto de venta: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:DropDownList ID="DDLImpuestoVenta" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>

                

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Impuesto de valor agregado: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbImpValorAgregado" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Excento: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:DropDownList ID="DDLExcento" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Peso: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbpeso" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Estado: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:DropDownList ID="DDLEstado" runat="server" CssClass="form-control" 
                                 />                             
                         </div>                        
                    </div>
                </div>

                <div class="form-group">  
                    <div class="row">        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Seleccione una imagen: " runat="server" />
                        </div>
                        <asp:FileUpload ID="fileimage" runat="server"></asp:FileUpload>
                                                             
                         </div>                        
                    </div>
                </div>

                
                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <asp:Button Text="Insertar" runat="server" CssClass="btn btn-outline-info" ID="tbregistrar" OnClick="tbinsertarvehiculo_Click"/>
                        </div>
                    </div>
                </div>
                    
                
                 <div class="form-group">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <asp:Button Text="Actualizar" runat="server" CssClass="btn btn-outline-info" ID="btnActualizar" OnClick="btnActualizar_Click"/>
                        </div>
                    </div>
                </div>

                 <div class="form-group">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <asp:Button Text="Eliminar" runat="server" CssClass="btn btn-outline-info" ID="btnEliminar" OnClick="btnEliminar_Click"/>
                        </div>
                    </div>
                </div>
                
                </div>


        </div>
    </center>

</asp:Content>
