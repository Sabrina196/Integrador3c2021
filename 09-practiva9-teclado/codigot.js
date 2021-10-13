/*Variables*/ 
const array = Array.from(document.querySelectorAll(".filaT"));
const del = document.getElementById("del");
const borrarTodo = document.getElementById("borrarTodo");
let display = document.getElementById("display");
let caracter ="";

/*Escucha de evento de cada Boton para capturar su valor*/
array.forEach(function(boton){
    boton.addEventListener("click", function(){
    escribir(boton.value);
    });     
});
/*Funcion Escribir en Display*/
function escribir(valor){
    caracter = caracter + valor;
    document.getElementById("display").value = caracter;
}
/*funcion Borrar el último caracter*/
del.addEventListener('click', (e) => {
    caracter = caracter.substring(0, display.value.length - 1);
    document.getElementById("display").value = caracter;
});
/*Borrar Todo*/
borrarTodo.addEventListener("click", (e)=>{
    caracter = "";
    document.getElementById("display").value = caracter;
});

