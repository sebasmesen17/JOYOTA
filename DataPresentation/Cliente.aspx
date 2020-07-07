<%@ Page Title="Joyota" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="DataPresentation.Cliente" %>
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
                            <asp:Label Text="Clientes " runat="server" />
                        </div>

                        <asp:DropDownList ID="DDLClientes" OnSelectedIndexChanged="DDLClientes_SelectedIndexChanged1"   CssClass="form-control" runat="server" AutoPostBack="True">
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                             
                         </div>
                          
                          
                    </div>

                </div>

                 
                <div class="form-group">
                    
                    <div class="row">
                        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Cedula" runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbCedula" runat="server" CssClass="form-control" 
                                 placeholder="1-1234-1234" />
                             
                         </div>
                          
                          
                    </div>

                </div>
                <div class="row">
                        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Correo Electrónico" runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbCorreo" TextMode="Email" runat="server" CssClass="form-control" 
                                 placeholder="Ex: Example@mailservice.com" />
                         <div>
                        </div>
                         </div>
                        
                          
                          
                    </div>


            <br />
                <div class="form-group">
                    
                    <div class="row">
                        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Contraseña" runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbpassword" runat="server" TextMode="Password" CssClass="form-control" 
                                 placeholder="Md4Ad2@q" />
                             
                         </div>
                          
                          
                    </div>

                </div>
                <div class="form-group">
                    
                    <div class="row">
                        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Tipo de cédula: " runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                            <asp:DropDownList ID="DDLTipoCedula" runat="server" CssClass="form-control" >
                            </asp:DropDownList>
                             
                         </div>
                          
                          
                    </div>

                </div>

               <div class="form-group">
                    
                    <div class="row">
                        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Nombre" runat="server" />
                        </div>

                    <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbNombreCompleto" runat="server" CssClass="form-control" />
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
                            <asp:Label Text="Telefono" runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbTelefono" runat="server" CssClass="form-control" 
                                 placeholder="Ex: 88888888" />
                         <div>
                        </div>
                         </div>
                        
                          
                          
                    </div>

                </div>

                 
                 <div class="form-group">
                    
                    

                </div>

                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Button Text="Registrar" runat="server" CssClass="btn btn-outline-info" ID="btnregistrar" OnClick="btnregistrar_Click"/>
                        </div>
                        <div></div>
                        <div class="col-lg-8 col-md-8 col-sm-8">
                            <asp:Button Text="Actualizar" runat="server" CssClass="btn btn-outline-info" ID="btnActualizar" OnClick="btnActualizar_Click"/>
                        </div>
                    </div>
                </div>

                
                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Button Text="Limpiar" runat="server" CssClass="btn btn-outline-info" ID="btnLimpiar" OnClick="btnLimpiar_Click"/>
                        </div>
                        <div></div>
                        <div class="col-lg-8 col-md-8 col-sm-8">
                            <asp:Button Text="Eliminar" runat="server" CssClass="btn btn-outline-info" ID="btnEliminar" OnClick="btnEliminar_Click"/>
                        </div>
                        <div></div>
                    </div>
                </div>


            </div>

        </div>

    </div>
    </center>

    <center>
    <table>
        <tr>
            <td> 
                <asp:GridView ID="GVCorreo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"><AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

<EditRowStyle BackColor="#7C6F57"></EditRowStyle>

<FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"></FooterStyle>

<HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"></HeaderStyle>

<PagerStyle HorizontalAlign="Center" BackColor="#666666" ForeColor="White"></PagerStyle>

<RowStyle BackColor="#E3EAEB"></RowStyle>

<SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

<SortedAscendingCellStyle BackColor="#F8FAFA"></SortedAscendingCellStyle>

<SortedAscendingHeaderStyle BackColor="#246B61"></SortedAscendingHeaderStyle>

<SortedDescendingCellStyle BackColor="#D4DFE1"></SortedDescendingCellStyle>

<SortedDescendingHeaderStyle BackColor="#15524A"></SortedDescendingHeaderStyle>
</asp:GridView> 
        <br />
            </td>
        <br />
        </tr>
        <br />
        <tr>
            <td> 
                <asp:GridView ID="GVTelefono" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"><AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

<EditRowStyle BackColor="#7C6F57"></EditRowStyle>

<FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"></FooterStyle>

<HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"></HeaderStyle>

<PagerStyle HorizontalAlign="Center" BackColor="#666666" ForeColor="White"></PagerStyle>

<RowStyle BackColor="#E3EAEB"></RowStyle>

<SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

<SortedAscendingCellStyle BackColor="#F8FAFA"></SortedAscendingCellStyle>

<SortedAscendingHeaderStyle BackColor="#246B61"></SortedAscendingHeaderStyle>

<SortedDescendingCellStyle BackColor="#D4DFE1"></SortedDescendingCellStyle>

<SortedDescendingHeaderStyle BackColor="#15524A"></SortedDescendingHeaderStyle>
</asp:GridView> 
            </td>
        </tr>
    </table>
    </center>
</asp:Content>
