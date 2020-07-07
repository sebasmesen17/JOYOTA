<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="DataPresentation.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
    <br />
<div>
     <Center>
           <h2> <asp:Label ID="Label1" runat="server" ForeColor="HotTrack" Text ="Label">Catalogo </asp:Label> </h2>
        <br />
        <asp:DataList ID="dlVehiculos" runat="server" RepeatColumns="4" OnItemCommand="dlVehiculos_ItemCommand"> 

            <ItemTemplate>

                <div class="Panel col-lg-10 col-md-8 col-sm-8">
                        <img src='<%#Eval("img")%>' class="card-img-top" alt="Imagen no cargada - Toyota S.A.">

                        <div class="card">
                            <div class="form-group">
                                <div class="row">
                                    <div class="col-lg-4 col-md-5 col-sm-5">
                                        <asp:Label Text="Marca:" runat="server" />
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <asp:Label ID="lblDescripcion" Text='<%#Eval("marca")%>' runat="server" />
                                    </div>
                                </div>
                            </div>
                             <div class="form-group">
                                <div class="row">
                                    <div class="col-lg-4 col-md-5 col-sm-5">
                                        <asp:Label Text="Modelo:" runat="server" />
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <asp:Label ID="Label2" Text='<%#Eval("modelo")%>' runat="server" />
                                    </div>
                                </div>
                            </div>
                             <div class="form-group">
                                <div class="row">
                                    <div class="col-lg-4 col-md-5 col-sm-5">
                                        <asp:Label Text="Año:" runat="server" />
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <asp:Label ID="Label3" Text='<%#Eval("año")%>' runat="server" />
                                    </div>
                                </div>
                            </div>
                             <div class="form-group">
                                <div class="row">
                                    <div class="col-lg-4 col-md-5 col-sm-5">
                                        <asp:Label Text="Categoria:" runat="server" />
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <asp:Label ID="Label4" Text='<%#Eval("categoria")%>' runat="server" />
                                    </div>
                                </div>
                            </div>
                             <div class="form-group">
                                <div class="row">
                                    <div class="col-lg-4 col-md-5 col-sm-5">
                                        <asp:Label Text="Estado:" runat="server" />
                                    </div>
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <asp:Label ID="Label5" Text='<%#Eval("estado")%>' runat="server" />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="row">
                                    <div class="col-lg-12 col-md-12 col-sm-12">
                          <asp:Button ID="Button1" Text="Me interesa" CommandArgument="<%#((DataListItem) Container).ItemIndex%>" 
                           CommandName="Compra" runat="server"  CssClass="btn btn-outline-info" />

                            <asp:Label ID="l1" runat="server" Text='<%#Eval("IDVehiculo")%>' Visible="false" ></asp:Label>  
                                    </div>
                                </div>
                            </div>
                    </div>


                </ItemTemplate>

        </asp:DataList>
     </Center>
    </div>

</asp:Content>
