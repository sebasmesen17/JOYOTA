<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="DataPresentation.Empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
             
                <center>
                    <div class="Panel col-lg-5 col-md-5 col-sm-5 mt-4">
                        <div>
        <div class="card">
             <div class="card-header bg-info">
                 <h4 class="TextoContenido">Empleados</h4>
             </div>
            <div class="card-body">
                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4" style="left: 0px; top: -4px">
                            <asp:Label Text="ID Empleado" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbIDEmpleado" runat="server" CssClass="form-control" 
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
                            <asp:Label Text="Salario" runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbSalario" runat="server" CssClass="form-control" 
                                  />
                         </div>
                    </div>
                </div>

                   <div class="form-group">                   
                    <div class="row">  
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Cargo: " runat="server" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                            <asp:DropDownList ID="DDLCargo" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DDLCargo_SelectedIndexChanged1" >
                            </asp:DropDownList>
                             
                         </div>                                                   
                    </div>
                </div>
                <div class="form-group">                   
                    <div class="row">  
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Departamento: " runat="server" ID="lbDepartamento" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                            <asp:DropDownList ID="DDLDepartamento" runat="server" CssClass="form-control" >
                            </asp:DropDownList>
                             
                         </div>                                                   
                    </div>
                </div>
                <div class="form-group">                   
                    <div class="row">  
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Sucursal: " runat="server" ID="lbSucursal" />
                        </div>
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                            <asp:DropDownList ID="DDLSucursal" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DDLCargo_SelectedIndexChanged1" >
                            </asp:DropDownList>
                             
                         </div>                                                   
                    </div>
                </div>
                
                 <div class="form-group">
                    <div class="row">
                        <div class="col-lg-12 col-md-12 col-sm-12">
                            <asp:Button Text="Registrar" runat="server" CssClass="btn btn-outline-info" ID="tbregistrar" OnClick="tbregistrar_Click"/>
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
                    
                     <left>
                         <div class="form-group">                   
                            <div class="row">  
                                <div class="col-lg-4 col-md-4 col-sm-4">
                                    <asp:Label Text="Cargos: " runat="server" ID="Label1" />
                                </div>
                                 <div class ="col-lg-8 col-md-8 col-sm-8">
                                    <asp:DropDownList ID="DDlEmpleadosPorDepartamento" runat="server" CssClass="form-control" >
                                    </asp:DropDownList>
                             
                                 </div>                                                   
                            </div>
                        </div>
                    </left>
               
                </div>


            </div>
        </div>
                         <div class="form-group">                   
                         <div class ="col-lg-8 col-md-8 col-sm-8">
                           <asp:GridView ID="GVEmpleados" runat="server" CssClass="form-control" DataKeyNames="IDEmpleado" AutoGenerateSelectButton="True" OnSelectedIndexChanging="GVEmpleados_SelectedIndexChanging"></asp:GridView>
                         </div> 
                        
                    </div>
    </div>
                         
                  
                    
                </center>
</asp:Content>
