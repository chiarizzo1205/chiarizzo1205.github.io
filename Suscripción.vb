<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title>SUSCRIPCIÓN | MUSE</title>
    <link rel="stylesheet" type="Estilos.css"/>
    <link href="https://fonts.googleapis.com/css?family=Bebas+Neue&display=swap" rel="stylesheet">
    <style>
      .titulosblancos { 
       color: rgb(255, 255, 255);
       font-weight: bold; font-size: 40px; font-family: 'Bebas Neue', cursive; text-align: center; letter-spacing: 10px;} 
      .subgris { 
        color: rgb(170, 170, 170); font-size: 20px; font-family: 'Bebas Neue', cursive; letter-spacing: 5px; text-align: center;} 
      .linkslila {
        color: rgb(255, 194, 255); line-height: 1.8; font-size: 20px; text-align: justify; text-align: center;}
      .formulario {color: rgb(255, 194, 255); line-height: 1.8; font-size: 20px; text-align: justify; text-align: center;}
      .contenedor {max-width: 1200px;   margin: auto;} 
    </style>
  </head>
  <body bgcolor="black">
   <div id="contenedor">
    <header>
        <h1 id="titulo" class="titulosblancos">SUSCRIPCIÓN Y COMPRA DE ENTRADAS</h1>
    </header>
    <main>
        <section>
            <h2 id="sub" class="subgris">Regístrese para obtener las últimas noticias de MUSE sobre álbumes, gigs, competencias y más...</h2>
              <p id="links" class="linkslila"> Puede contactarse con nosotros e indicarnos sugerencias y/o peticiones para futuros eventos</p>
            <form class="formulario">
            <fieldset>
              <label for="Nombre">Nombre  </label><input type="text" /></br>
             <label for="Email">E-mail </label><input type="email" /></br>
             <label for="Teléfono">Teléfono </label><input type="number" /></br>
             <select name="Concierto de Interés">
               <option value="Alemania">Alemania</option>
               <option value="Países Bajos">Países Bajos</option>
               <option value="Reino Unido">Reino Unido</option>
               <option value="Singapur">Singapur</option>
               <option value="México">México</option>
               <option value="Brasil">Brasil</option>
               <option value="Argentina">Argentina</option>
               <option value="Chile">Chile</option>
             </select></br>
             <div>Cantidad de tickets</div>
               1 <input type="checkbox" name="1" value="1" /></br>
               2 <input type="checkbox" name="2" value="2" /></br>
               3 <input type="checkbox" name="3" value="3" /></br>
               4 <input type="checkbox" name="4" value="4" /></br>
              <label>Comentarios </label><textarea maxlenght="500"></textarea></br>
              </br>
              <input type="reset" />
              <input type="submit" />
            </fieldset>
          </form>
         </section>
    </main>
   </div>
  </body>
</html>
