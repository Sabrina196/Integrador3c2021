/*Variables*/

var visorPiso = document.getElementById("piso").value;
const visorDpto = document.getElementById("dpto").value;
const teclado = document.querySelectorAll(".numeros");
const llamar = document.getElementById("llamar");
const borrar = document.getElementById("borrar");
const visorLlamadas = document.getElementById("visor").value;


var valorP = "";
var valorD = "";

/* Funciones para marcar Botones en VisorPiso y VisorDto */

teclado.forEach(function(boton){
    boton.addEventListener("click", function(){
    concatenarP(boton.value);
    });     
})

function concatenarP(valor){

    if (valorP.length < 2){
        valorP = valorP + valor;
        resulPiso = valorP;
        numP = parseInt(resulPiso);
        if (numP > 47 ){
            document.getElementById("visor").value = "Error = Solo hay 47 Pisos";
        }

        else {
            document.getElementById("piso").value = resulPiso;              
        }
    } 

    else {
        valorD = valor;
        numD = parseInt(valorD);
        if (numD < 1 || numD > 8) {
        document.getElementById("visor").value ="Error = Solo hay 8 Dptos";

        }

        else {
            document.getElementById("dpto").value = valorD;
       }        
    }
}

/*Función LLamar*/

llamar.addEventListener("click", llamando)

function llamando(){
    var error = parseInt(valorD);
    if (numP <= 47 && valorD != "" && error >= 1 && error <= 8){
        document.getElementById("visor").value = `Piso ${resulPiso} y Dpto ${valorD}`;
    }
};

/*Función Borrar Visores*/

borrar.addEventListener("click", limpiar)

function limpiar(){
    valorD = "";
    valorP= "";
    document.getElementById("visor").value = "";
    document.getElementById("piso").value ="";
    document.getElementById("dpto").value ="";
}

