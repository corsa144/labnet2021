'use strict';

console.log("document ready");
$(document).ready(function () {
 console.log("document ready");

    $('#botonEnviar').click(function(e) {
        console.log("clicky");
        let nombre = $("#nombre").val();
        ValidarNombre(nombre, 'nombre');
        
        let apellido = $("#apellido").val();
        ValidarNombre(apellido, 'apellido');
    });


    let ValidarNombre = function(dato, campo) {
        if(dato == '' || dato == ' '){
            alert("No se completo el campo "+campo);
        }
    }

    $('#limpiar').click(function(e) {

         $("#nombre").val("");
        
         $("#apellido").val("");

         $("#edad").val("");

         $("#empresa").val("");

    });
});
