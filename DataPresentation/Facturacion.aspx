<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="DataPresentation.Facturacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <center>
        <table>
            <tr>
                <td>Información sobre el vehículo:</td>
                <td>
                    
                      <div class="card" style="width: 18rem;">
                      <div class="card-body">
                          <h5> <asp:Label ID="lbMarca" runat="server" Text=""></asp:Label> </h5>
                          <h6> <asp:Label ID="lbModelo" runat="server" Text=""></asp:Label> </h6>
                          <h6> <asp:Label ID="lbAño" runat="server" Text=""></asp:Label> </h6>
                          <h6> <asp:Label ID="lbCate" runat="server" Text=""></asp:Label> </h6>
                          <h6> <asp:Label ID="lbEstado" runat="server" Text=""></asp:Label> </h6>
                        </div>
                       </div>

                </td>
            </tr>
            
            <tr>
                <td> 
                </td>
            </tr>
            
            <tr>
                <td></td>
                <td><h3>Facturación</h3></td>
            </tr> 

            <tr>
                <td>  </td>
            </tr>

            <tr>
                <td>Fecha</td>
                <td> <asp:TextBox ID="tbFecha" runat="server" Enabled="false"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>Cliente</td>
                <td> <asp:Label ID="lbCliente" runat="server" Text=""></asp:Label> </td>
            </tr>
            <tr>
                <td>IVI</td>
                <td> <asp:Label ID="lbIvi" runat="server" Text=""></asp:Label> </td>
            </tr>
            <tr>
                <td>IVA</td>
                <td> <asp:Label ID="lbiva" runat="server" Text=""></asp:Label> </td>
            </tr>
            <tr>
                <td>Precio</td>
                <td> <asp:Label ID="lbPrecio" runat="server" Text=""></asp:Label> </td>
            </tr>
            
            <tr>
                <td>  </td>
            </tr>

            <tr>
                <td>Sucursal:</td>
                <td><asp:Label ID="lbIDSucursal" runat="server" Text="100"></asp:Label> </td>
            </tr>
            <tr>
                <td>Cantidad:</td>
                <td> <asp:Label ID="lbCantidad" runat="server" Text="1"> </asp:Label> </td>
            </tr>
            <tr>
                <td>Tipo pago:</td>
                <td> <asp:DropDownList ID="DDLTipoPago" AutoPostBack="True" runat="server"></asp:DropDownList> </td>
            </tr>
            
            <tr>
                <td>  </td>
            </tr>
            
            <tr>
                <td>Total</td>
                <td> <asp:Label ID="lbTotal" runat="server" Text=""></asp:Label> </td>
            </tr>

            <tr>
                <td></td>
                <td> <asp:Button ID="btnComprar" OnClick="btnComprar_Click" runat="server" Text="Comprar"></asp:Button> </td>
            </tr>
        </table>
    </center>


</asp:Content>
