/*Declaración de Variables*/

const btn1 = document.getElementById("boton1");
const btn2 = document.getElementById("boton2");

let numero = document.getElementById("num1").value;

let numA = document.getElementById("numA");
let numB = document.getElementById("numB");
const formu = document.getElementById("formulario2");

const nombre = document.getElementById("nombre");
const apellido = document.getElementById("apellido");
const conca = document.querySelector(".concatenacion");

/* 1°Actividad */

btn1.addEventListener("click", (e)=> {
    ++numero;
    document.getElementById("num1").value = numero;
})

/*2° actividad*/

formu.addEventListener("change", (e)=>{
	let seleccion = document.getElementById("operadoresMath");
	let valor = seleccion.options[seleccion.selectedIndex].value;
    var resul = "";

    if (valor == "sum"){
        var resul = parseInt(numA.value) + parseInt(numB.value);        
    }
    else if (valor == "res"){
        var resul = parseInt(numA.value) - parseInt(numB.value);        
    }
    else if (valor == "mul"){
        var resul = parseInt(numA.value) * parseInt(numB.value);
    }
    else if (valor == "div"){
        if(numB.value == 0){
            var resul = "No se puede dividir por O";
        }
        else {
            var resul = parseInt(numA.value) / parseInt(numB.value);
            document.getElementById("resultado").value = resul;  
        }    
    }
    document.getElementById("resultado").value = resul;  
 })


/*3° Actividad*/

btn2.addEventListener("click", (e)=>{
    conca.innerHTML = `Su nombres es ${nombre.value} y su apellido ${apellido.value}`;
})


