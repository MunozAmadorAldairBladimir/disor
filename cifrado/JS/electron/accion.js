var acciones= (function() {

 document.getElementById("mensajeTA").addEventListener("keyup", function(){
   var mensaje = document.getElementById("mensajeTA").value;
   var desplaza = Number(document.getElementById("desplazamientoIT").value);
      document.getElementById("mensajeCifradoTA").value = c.cesar(desplaza,mensaje);
  });


   document.getElementById("mensajeTA").addEventListener("keyup", function(){
     var mensaje = document.getElementById("mensajeTA").value;
     var desplaza = Number(document.getElementById("desplazamientoIT").value);
        document.getElementById("mensajeCifradoTA2").value = t.transposicion(mensaje);
    });

    document.getElementById("mensajeTA").addEventListener("keyup", function(){
      var mensaje = document.getElementById("mensajeTA").value;
      var agrupacion = Number(document.getElementById("agrupacionIT").value);
         document.getElementById("mensajeCifradoTA3").value = t.tia(agrupacion,mensaje);
     });



  document.getElementById("desplazamientoIT").addEventListener("keyup", function(){
    var mensaje = document.getElementById("mensajeTA").value;
    var desplaza = Number(document.getElementById("desplazamientoIT").value);
       document.getElementById("mensajeCifradoTA").value = c.cesar(desplaza,mensaje);
   });

   document.getElementById("mensajeCifradoTA").addEventListener("keyup", function(){
     var mensaje = document.getElementById("mensajeCifradoTA").value;
     var desplaza = Number(document.getElementById("desplazamientoIT").value);
     document.getElementById("mensajeTA").value = c.cesar(-desplaza,mensaje);
    });

    document.getElementById("mensajeCifradoTA2").addEventListener("keyup", function(){
      var mensaje = document.getElementById("mensajeCifradoTA2").value;
      document.getElementById("mensajeTA").value = t.transposicion(mensaje)
     });

     document.getElementById("agrupacionIT").addEventListener("keyup", function(){
       var mensaje = document.getElementById("mensajeTA").value;
       var agrupacion = Number(document.getElementById("agrupacionIT").value);
          document.getElementById("mensajeCifradoTA3").value = t.tia(agrupacion,mensaje);
      });

      document.getElementById("mensajeCifradoTA3").addEventListener("keyup", function(){
        var mensaje = document.getElementById("mensajeTA").value;
        var agrupacion = Number(document.getElementById("agrupacionIT").value);
        document.getElementById("mensajeTA").value = t.tia(agrupacion,mensaje);
       });


})();
