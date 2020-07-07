<%@ Page Title="Joyota - Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataPresentation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="bd-example">
      <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
          <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
          <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
          <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
            <li data-target="#carouselExampleCaptions" data-slide-to="3"></li>
            <li data-target="#carouselExampleCaptions" data-slide-to="4"></li>
        </ol>
        <div class="carousel-inner">
          <div class="carousel-item active">
            <img src="imag/portada1.jpg" class="d-block w-100" alt="Imag 1">
            <div class="carousel-caption d-none d-md-block">
              <h5>Joyota</h5>
              <p>Ponga a prueba el todoterreno.</p>
            </div>
          </div>
          <div class="carousel-item">
            <img src="imag/portada2.jpg" class="d-block w-100" alt="Imag 2">
            <div class="carousel-caption d-none d-md-block">
              <h5>Joyota</h5>
              <p>Elige tu diseño favorito.</p>
            </div>
          </div>       
            <div class="carousel-item">
            <img src="imag/portada4.jpg" class="d-block w-100" alt="Imag 2">
            <div class="carousel-caption d-none d-md-block">
              <h5>Joyota</h5>
              <p>Elige tu diseño favorito.</p>
            </div>
          </div>
            <div class="carousel-item">
            <img src="imag/portada5.jpg" class="d-block w-100" alt="Imag 2">
            <div class="carousel-caption d-none d-md-block">
              <h5>Joyota</h5>
              <p>Elige tu diseño favorito.</p>
            </div>
          </div>
            <div class="carousel-item">
            <img src="imag/portada6.jpg" class="d-block w-100" alt="Imag 2">
            <div class="carousel-caption d-none d-md-block">
              <h5>Joyota</h5>
              <p>Elige tu diseño favorito.</p>
            </div>
          </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="sr-only">Next</span>
        </a>
      </div>
    </div>

    <br />
    
    <div class="jumbotron">
        <Center>
            <table>
                <tr>
                    <td>
                        <div class="card">
                          <div class="card-header">
                            Catalogos
                          </div>
                          <div class="card-body">
                            <h5 class="card-title">Elige tu carro de sueño</h5>
                            <p class="card-text">Contamos con muchos diseño para que eligas tu favorito.</p>
                            <a href="/Catalogo.aspx" class="btn btn-primary">Catalogos</a>
                          </div>
                        </div>
                    </td>

                    <td>
                        <div class="card">
                          <div class="card-header">
                            Donde estamos ubicados
                          </div>
                          <div class="card-body">
                            <h5 class="card-title">Elige tu carro de sueño</h5>
                            <p class="card-text">Contamos con muchos diseño para que eligas tu favorito.</p>
                            <a href="/About.aspx" class="btn btn-primary">Ubicación</a>
                          </div>
                        </div>
                    </td>
                </tr>
            </table>
        </Center>
    </div>
    
</asp:Content>
