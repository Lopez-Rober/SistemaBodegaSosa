<%@ Page Title="Tienda sosa" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="SistemaVentas.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">

        <img class="card-img-top" src="css/back.png" alt="Card image cap" height="700">
        
        <p class="lead">Es una bodega ubicada en Elvira Garcia y Garcia #751 – Lambayeque. Ofrece productos tales como lácteos, carnes, frutas, verduras y abarrotes.</p> 
        <p class="lead">Nos caracterizamos por facilitar la compra, brindando rapidez en la atención, una ubicación cómoda y cercana a su hogar o trabajo, con amplios horarios de atención, y un surtido de más de 1.000 artículos, que satisfacen las necesidades de sus clientes, contando con una amplia variedad de productos a ofrecer en un ambiente grato y  personalizada atención, atendido por sus propios dueños y familia.</p>
        <p class="lead">Nos ubicamos en Elvira Garcia y Garcia #751 - Lambayeque
        </p>        
        <p><a id="publicidad" href="https://www.google.com/maps/@-6.7008636,-79.9141849,3a,90y,4.03h,87.56t/data=!3m6!1e1!3m4!1sof3Wx0M5_ewk-hxl7r3Oww!2e0!7i13312!8i6656" target="_blank" class="btn btn-primary btn-lg" class="ml-1"><b>https://promotorapimentel.com/</b></a></p>
    </div>

    <div class="row justify-content-center cont_mis_vis">
        <div class="col-11 col-md-6 col-lg-5 cont_mision">
            <div class="row">
                <div class="col-12 col-md-10">
                    <h4 class="color=blue titulo_mision">MISIÓN</h4>
                    <p class="texto_plomo">
	                    "Somos una organización comercial encargada de brindar y ofrecer productos de excelente calidad, comprometidos con la plena satisfacción del cliente a través de un trato humano y personalizado, el mejor precio y un trato amable por parte de quienes conformamos esta empresa."
                    </p>
                </div>
            </div>
         </div>

        <div class="col-11 col-md-6 col-lg-5 cont_mision">
            <div class="row">
                <div class="col-12 col-md-10">
                    <h4 class="color=blue titulo_mision">VISIÓN</h4>
                    <p class="texto_plomo">
	                    "Buscamos ser la primera opción de nuestros clientes al momento de adquirir insumos para su negocio; permitiéndonos crear relaciones duraderas basadas en la confianza, el respeto y la honestidad que nos permita crecer conjuntamente todos los días."
                    </p>
                </div>
            </div>
        </div>     
        
        <div class="jumbotron">
            <footer class="mt-1">
        <div class="info_footer">
        <ul>
           <li>
             <i class="fas fa-phone-alt"></i>
               Comunicaciones
                    <div>- 934-983-203</div>
                    <div>- 983-823-943</div>
                    <div>- 972-933-732</div>
           </li>

        </ul>
        <ul>
           <li>
              <i class="fas fa-envelope"></i>
                    bodegasosa@gmail.com
           </li>
            <li>
               <i class="fas fa-map-marker-alt"></i>
                    Sedes principal:
               
            <div>Elvira Garcia y Garcia #751</div>
            <div>Lamyeque</div></li>
          </ul>
         </div>
        </footer>
       </div>

    </div>

   <hr />

   <footer>
   </footer>

</asp:Content>
