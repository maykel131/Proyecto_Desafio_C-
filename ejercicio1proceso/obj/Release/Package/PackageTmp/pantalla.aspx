<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pantalla.aspx.cs" Inherits="ejercicio1proceso.pantalla" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
	<title>Desafio 2018 Maykel Trejo</title>
	<link rel="stylesheet" href="css/bootstrap.min.css">
	<link rel="stylesheet" href="css/estilos.css">

	    <!--                 slider new                 -->
              <link rel="stylesheet" href="slider/css/nivo-slider.css">
              <link rel="stylesheet" href="slider/css/mi-slider.css">

              <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js" type="text/javascript"></script>
              <script src="slider/js/jquery.nivo.slider.js"></script>

              <script type="text/javascript"> 
                $(window).on('load', function() {
                    $('#slider').nivoSlider(); 
                }); 
              </script>
        <!--                 slider new                 -->

</head>
<body>
	

	<form id="form1" runat="server">
	

	<section class="jumbotron">
		<div class="container">
			<h1>Engenheiro Maykel Trejo</h1>
			<p>Desafio FORTES tecnologias em sistemas 2018 </p>
		</div>
	</section>

	<section class="main container">
		<div class="row">
			<section class="posts col-md-9">
				<div class="miga-de-pan">
					<ol class="breadcrumb">
						<li><a href="#">Inicio</a></li>
						<li><a href="#">Categorias</a></li>
						<li class="active">Diseño Web</li>
					</ol>
				</div>

				<article class="post clearfix">
					<a href="#" class="thumb pull-left">
						<img class="img-thumbnail" src="img/img1.jpg" alt="">
					</a>
					<h2 class="post-title">
						<a href="#">Canguru</a>
					</h2>
					<p><span class="post-fecha">Janeiro de 2018</span> por <span class="post-autor"><a href="http://maykeltrejo.webcindario.com/">Maykel Trejo</a></span></p>
					<p class="post-contenido text-justify">
						Dado dois cangurus em uma linha numérica prontos para saltar na direção
						positiva (ou seja, em direção ao infinito positivo). O primeiro canguru começa na
						localização e se move a uma taxa de metros por salto. O segundo canguru começa
						na localização e se move a uma taxa de metros por salto. Dado os locais iniciais e
						as taxas de movimento para cada canguru, você pode determinar quando eles
						cairão no mesmo local ao mesmo tempo?<br/>Formato​ ​de​ ​entrada
						uma única linha de quatro inteiros separados por espaços que denotam os valores
						respectivos de x1, v1, x2, e v2. com essos parametros 0​ ​<=x1< x2<=1000  1<=v1<=10000  1<=v2<=10000

					</p>

					<div class="contenedor-botones">
					
					     <input ID="TextBox44"  type="text" text=""  title="hola" pattern="[0-9]{1,4}[ ]{1}[0-9]{1,4}[ ]{1}[0-9]{1,4}[ ]{1}[0-9]{1,4}" runat="server"  placeholder="ex: 1 2 3 4"  />
                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" OnClick="Button1_Click" Text="Clique" />
						<asp:Label ID="resultado1" class="resultado" runat="server" Text="Resultado"></asp:Label>
						
					</div>
				</article>

				<article class="post clearfix">
					<a href="#" class="thumb pull-left">
						<img class="img-thumbnail" src="img/img2.png" alt="">
					</a>
					<h2 class="post-title">
						<a href="#">Min-Max​ ​Soma</a>
					</h2>
					<p><span class="post-fecha">Janeiro de 2018</span> por <span class="post-autor"><a href="http://maykeltrejo.webcindario.com/">Maykel Trejo</a></span></p>
					<p class="post-contenido text-justify">
						Dado cinco inteiros positivos, encontre os valores mínimos e máximos que podem
						ser calculados somando exatamente quatro dos cinco inteiros. Em seguida, imprima
						os valores mínimos e máximos respectivos como uma única linha de dois
						segmentos longos separados por espaço.Formato​ ​de​ ​Entrada
						Uma única linha de cinco inteiros separados por espaço
						Cada número inteiro está no intervalo inclusivo [1, 10]

					</p>
               
					<div class="contenedor-botones">
                        <input  ID="TextBox22" type="text" runat="server" placeholder="ex: 1 2 3 4 5" title="input2" pattern="[0-9]{1,2}[ ]{1}[0-9]{1,2}[ ]{1}[0-9]{1,2}[ ]{1}[0-9]{1,2}[ ]{1}[0-9]{1,2}" />
						<asp:Button class="btn btn-primary" ID="Button2" runat="server" Text="Clique" OnClick="Button2_Click" Height="32px" />
						<asp:Label ID="Label2" runat="server" Text="Resultado"></asp:Label>
					
					</div>
				</article>

				<article class="post clearfix">
					<a href="#" class="thumb pull-left">
						<img class="img-thumbnail" src="img/img3.jpg" alt="">
					</a>
					<h2 class="post-title">
						<a href="#">Quase​ ​Ordenado</a>
					</h2>
					<p><span class="post-fecha">Janeiro de 2018</span> por <span class="post-autor"><a href="http://maykeltrejo.webcindario.com/">Maykel Trejo</a></span></p>
					<p class="post-contenido text-justify">
						Dada uma matriz com elementos, você pode classificar esta matriz em ordem
							crescente usando apenas uma das seguintes operações?
							1. Troque dois elementos.
							2. Inverta um sub-segmento.
						  <br/><br/>Formato​ ​de​ ​Entrada <br/>
						A primeira linha contém um único inteiro, n, que indica o tamanho da matriz.
						A próxima linha contém n inteiros separados por espaços. <br />Restrições 2<= tamanho <= 100000 e 0 <= Di 1000000
					</p>

					<div class="contenedor-botones">
                         <input  ID="Text33" type="text" runat="server" placeholder="Tamanho da matriz" title="input2" pattern="[0-9]{1,6}"  />
                        <input  ID="Text44" type="text" runat="server" placeholder="D1...DN" title="input3"   /> 
                      
						<asp:Button class="btn btn-primary" ID="Button3" runat="server" Text="Clique" OnClick="Button3_Click" />
						<asp:Label ID="Label6" runat="server" Text="Resultado"></asp:Label>
						
					</div>
				</article>

				
			</section>

			<aside class="col-md-3 hidden-xs hidden-sm">
				<h4>Categorias</h4>
				<div class="list-group">
					<a href="#" class="list-group-item active">About Maykel</a>
					<a href="http://maykeltrejo.webcindario.com/" class="list-group-item" target="_blank">Meu Portafolio</a>
					<a href="https://www.facebook.com/Maykel.el.LEON" class="list-group-item " target="_blank">Meu Facebook</a>
					<a href="#" class="list-group-item">trejomaykel@gmail.com</a>
					<a href="#" class="list-group-item">85 987096251</a>
					<a href="http://maykeltrejo.webcindario.com/" class="list-group-item" target="_blank">Recursos y Herramientas</a>
					
				</div>

				<h4>Articulos Recientes</h4>
				<a href="http://maykeltrejo.webcindario.com/paginas/blog.html" class="list-group-item">
					<h4 class="list-group-item-heading">Los 10 mejores Hosting gratuitos</h4>
					<p class="list-group-item-text">Si estas nesecitando alojar tu sitio web en un servidor que no sea de paga...</p>
				</a>

				<a href="#" class="list-group-item">
					<h4 class="list-group-item-heading">Como hacer una plantilla básica con PHP (templates)</h4>
					<p class="list-group-item-text">LoremAprende como transformar tu diseño web en una plantilla dinámica con PHP.</p>
				</a>

				<a href="#" class="list-group-item">
					<h4 class="list-group-item-heading">Como cambiar el cursor de tu sitio web con propiedad CSS</h4>
					<p class="list-group-item-text">Aprende como cambiar el cursor de los elementos de tu sitio web con CSS.</p>
				</a>
			</aside>
		</div>
	</section>

	<footer>
		<div class="container">
			<div class="row">
				<div class="col-xs-6">
					<p>Maykel Trejo - WolfObiecer</p>
				</div>
				<div class="col-xs-6">
					<ul class="list-inline text-right">
						<li><a href="#">Inicio</a></li>
						<li><a href="#">Cursos</a></li>
						<li><a href="#">Contacto</a></li>
					</ul>
				</div>
			</div>
		</div>
	</footer>

	<script src="js/jquery.js"></script>
	<script src="js/bootstrap.min.js"></script>
    </form>
</body>
</html>