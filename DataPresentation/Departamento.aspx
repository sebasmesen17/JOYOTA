<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Departamento.aspx.cs" Inherits="DataPresentation.Departamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <center>
           <br />
        <div class="Panel col-lg-5 col-md-5 col-sm-5 mt-4">
        <div class="card">
             <div class="card-header bg-info">
                 <h4 class="TextoContenido">Departamentos</h4>
             </div>
   

                 
                <div class="form-group">
                       <br />
                    <div class="row">
                        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="ID Departamento" runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbIDDepartamento" runat="server" CssClass="form-control" 
                                 placeholder="112341234" />
                             
                         </div>
                          
                          
                    </div>

                </div>
              


            <br />
               
                <div class="form-group">
                    
                    <div class="row">
                        
                          
                    </div>

                </div>

               <div class="form-group">
                    
                    <div class="row">
                        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Label Text="Nombre" runat="server" />
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                             <asp:TextBox ID="tbNombreDep" runat="server" CssClass="form-control" />
                         </div>
                          
                          
                    </div>

                </div>

                   <div class="form-group">
                    
                    <div class="row">
                        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
                         </div>
                          
                          
                    </div>

                </div>

                

                <div class="form-group">
                    
                    <div class="row">
                        
                        <div class="col-lg-4 col-md-4 col-sm-4">
                        </div>

                         <div class ="col-lg-8 col-md-8 col-sm-8">
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
                            <asp:Button Text="Registrar" runat="server" CssClass="btn btn-outline-info" ID="btnregistrar" OnClick="btnregistrar_Click" />
                        </div>
                        <div></div>
                        <div class="col-lg-8 col-md-8 col-sm-8">
                            <asp:Button Text="Actualizar" runat="server" CssClass="btn btn-outline-info" ID="btnActualizar" OnClick="btnActualizar_Click" />
                        </div>
                    </div>
                </div>

                
                <div class="form-group">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 col-sm-4">
                            <asp:Button Text="Limpiar" runat="server" CssClass="btn btn-outline-info" ID="btnLimpiar" OnClick="btnLimpiar_Click" />
                        </div>
                        <div></div>
                        <div class="col-lg-8 col-md-8 col-sm-8" style="left: 0px; top: 0px">
                            <asp:Button Text="Eliminar" runat="server" CssClass="btn btn-outline-info" ID="btnEliminar" OnClick="btnEliminar_Click" />
                        </div>
                        
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
                <asp:GridView ID="GVDepartamentos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" DataKeyNames="IDDepartamento" OnSelectedIndexChanging="GVDepartamentos_SelectedIndexChanging" AutoGenerateColumns="False"><AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

                    <Columns>
                        <asp:BoundField DataField="nombreDepartamento" HeaderText="Departamento" />
                    </Columns>

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
      
        
    </table>
    </center>
</asp:Content>
