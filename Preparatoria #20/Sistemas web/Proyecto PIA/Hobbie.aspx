<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Hobbie.aspx.vb" Inherits="PIA.Hobbie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="descripción" content="etiquetas" />
    <title>Star Wars</title>
    <link rel="stylesheet" href="misestilos.css" />
</head>
<body bgcolor="000000">
    <form id="form1" runat="server">
        <div align="center">
             <header> <nav align="center"> <h1> <font color="Yellow" size="50"> STAR WARS </font> </h1> </nav>
        <time datetime="2021-02-26" pubdate>publicado 26-02-2021</time>
    </header>
    
    <font color="Yellow" size="20"> <mark>Star Wars </mark> es saga creada en los años 70's por George Lucas, y con el tiempo se ha vuelto muy reconocida a nivel mundial. Consta de 11 películas y varias series.  </font>
    <br />
     <font color="Yellow" size="20">Los personajes más famosos son los siguientes: </font>
    <br />
    <nav>
        <ul>
            <font color="Yellow" size="20">

            <li><em>Darth Vader</em></li>
            <li><em>Luke Skywalker</em></li>

            </font>
        </ul>
    </nav>
    <section>
        <article align="center">
            Este es el texto de mi primer mensaje
            <hgroup>
                <h1><font color="0068FF" size="15" face="Arial">En una galaxia muy muy lejana...</font></h1>
                <h2><font color="0068FF" size="15" face="Arial">Que la fuerza te acompañe</font></h2>
                <div>
                   
                </div>
            </hgroup>
            <figure>
                
                <figcaption align="center">
                   <font color="White" size="10" face="Comic Sans MC"><strong>Imagen con todos los personajes</strong></font>
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="472px" ImageUrl="~/StarWarsPersonajes.jpg" Width="833px" />
                </figcaption>
            </figure>
        </article>
        <article>
            <font color="Green" size="15">Películas y series</font>
        </article>
    </section>
    <aside>
        
        <blockquote><font color="orange" size="12">Triología precuelas</font></blockquote>
        <blockquote><font color="gray" size="12">The Mandalorian</font></blockquote>
        
    </aside>
    
    <footer>
        <address>
            <a href="https://www.starwars.com/"><font color="00F7FF" size="6" face="Arial">Visita la página oficial</font></a>
        </address>
        <small><font color="White" size="2" face="Arial">Derechos reservados &copy; 2021 MiniBooks</font></small>
    </footer>
        </div>
    
    <p>
        &nbsp;</p>
    <div align="center">
            <asp:Button ID="BTN_Volver" runat="server" BackColor="#CC3300" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Volver" Width="226px" />
    </div>
    </form>
</body>
</html>
