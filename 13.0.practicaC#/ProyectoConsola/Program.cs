using System;
using System.Collections.Generic; 

//Console.WriteLine("Hola Sabri , Soy el tan comentado C#");

//Declaración de una Variable
//<Tipo de Dato> <Nombre de la Variable>;

//string nombre = "Sabri";
//nombre = "Sabri"; => Se puede hacer tambien por separado;
// Lo que no se puede hacer es declararla 2 veces;
// No puede repetirse el nombre de la variable en ambitos superiores;
//Console.WriteLine("Hola " + nombre);

//int edad = 30;

//Console.WriteLine("La edad de " + nombre + " es " + edad.ToString());

//char letra = 'a'; //=> Tipo de Dato de un solo Caracter, comilla Simple.

//DateTime ahora;

//Constantes

//const double pi = 3.141516;

//double precio = 128.5;
//int unidades = 10;

//double total = precio * unidades;

//Console.WriteLine(precio);

//double resto = total % 3;

//Console.WriteLine(unidades);

//precio++;
//Console.WriteLine(precio);

//precio--;
//Console.WriteLine(precio);

//total += 1000;
// Es igual a poner total = total + 1000;
////Console.WriteLine(total);

//total /= 2;
//Console.WriteLine(total);

//bool estado = true;
////Console.WriteLine(estado);

//string Nombre = "Sara", apellido = "Connor";
////Console.WriteLine($"El nombre completo es {Nombre} {apellido}");

//string texto1 = "Izquierda", texto2 = "Derecha";
//string cadena = $"|{texto1, -20}| {texto2, 20}|"; //=> Pone espacios, El primero genera -20 y otro 20;
// Usamos | para ver la diferencia;
////Console.WriteLine(cadena);

//const int ancho = 20;
//Console.WriteLine($"{Math.PI, ancho} - numero PI por defecto");
//Console.WriteLine($"{Math.PI, ancho:F6} - numero PI por defecto");
//Console.WriteLine($"{total, ancho:C3} - es el total");


//Valores Nulos, Hora 20:40;
//int? edad1;
//edad1 = null;
//Se utiliza para Base de Datos, cuando no es obligación completar un campo;

//*******CLASE 19/10;

//int edadP = 20;

//if (edadP < 20){
    //Console.WriteLine("Es un joven");
//}
//else if (edadP >= 20 && edadP < 70)
//{
    //Console.WriteLine("*Es un adulto");
//}
//else {
    //Console.WriteLine("*Es un abuelo");
//}

//Console.WriteLine(edadP < 20 ? "*Es un joven" : "*No es joven");

//int n = 0;
//while (n <= 5 ){
    //Console.WriteLine(n);
    //n++;
//};

//string [] misTitulos = new string[5]; //=> array de string de 5 posisiones, hay que inicializarlo con posiciones;

//misTitulos[0]= " Titulo 1"; //=> Asigno valor a cada posicion;
//misTitulos[1]= " Titulo 2";
//misTitulos[2]= " Titulo 3";
//misTitulos[3]= " Titulo 4";
//misTitulos[4]= " Titulo 5";

//foreach (string elemento in misTitulos) //=> Recorre todos los elemento del MisTitutos y el valor se la asigna a "Elemento" por c/elemento; 
//{
    //Console.WriteLine(elemento);

//}

//Una coleccion es todo tipo de variables que tiene una lista de elementos;
//Un array es una coleccion de numeros por ejemplo;
//List, una liosta de enteros, el array es mas complejo de cambiarle el tamaño en C#;

//int[] numeros = new int[] {1, 2, 3, 4, 5}; //=> Otra forma de inicializar
//foreach (int elemento in numeros)
//{
    //Console.WriteLine(elemento);
//};

//List<int> numerosList = new List<int>(); //Mas dinamico que el array, la inicializa vacia y desp agrego;
//numerosList.Add(1); //=> Con este metodo los agrego;
//numerosList.Add(3);
//numerosList.Add(6);
//Console.WriteLine(numerosList.Count); //=> Devuelve la cantidad de elementos de la coleccion;
//foreach (int elemento in numerosList)
//{
    //Console.WriteLine(elemento);
//};

//******CLASE 21/10:Metodos o funcion

//string Saludar (string nombre, string apellido){ //=> Declaro el metodo y el tipo de datos tanto del metodo como de los parametros;

    //string respuestaSaludo = $"Hola {nombre} {apellido}";
    //return respuestaSaludo; //=> Retorna que va a contener el valor de esta variable;
//}
//string respuesta = (Saludar("Juana", "DeArco"));
//MostrarMensaje(respuesta);

//void MostrarMensaje(string mensaje){ //=> Para que no devuelva nada, usamos void
    //Console.WriteLine(mensaje);
//}

//*****TEMA NUEVO: OBJETOS*****;

//Definir una clase;

//Instanciar = Clase NombreVarible = new clase();
//vehiculo vehiculoUno = new vehiculo(); //=> Primero instanciar por la consola (no lo toma);
//vehiculoUno.Color = "Rojo";
//vehiculoUno.Año = 2005;
//vehiculoUno.CantidadRuedas = 2;
//vehiculoUno.Arrancar();
//Console.WriteLine(vehiculoUno.ObtenerEstado());
//vehiculoUno.Apagar();
//Console.WriteLine(vehiculoUno.ObtenerEstado());

//public class vehiculo {
    //public string Color = "";
    //public string Marca = "";
    //public short CantidadRuedas = 0;
    //public short Año = 0;
    //private bool EnUso = false;

    //public void Acelerar() {}   //=> Con esta palabra creamos la funcion/metodo;
    //public void Frena(){}
    //public void Arrancar(){
        //EnUso = true;
    //}
    //public void Apagar(){
        //EnUso = false;
    //}
    //public string ObtenerEstado(){
        //string estado;
        //if (EnUso){
            //estado = $"El vehiculo {Color} esta en uso y prendido";
        //}
        //else {
            //estado = $"El vehiculo {Color} esta libre y apagado";
        //}
        //return estado;
    //}

//}



libro libroA = new libro();
libroA.TituloLibro = "La vida es Sueño";
libroA.Autor = "Pedro Calderón de la Barca";
libroA.CopiasDisponibles = 3;
libroA.NumeroPrestados = 0;


libro libroB = new libro();
libroB.TituloLibro = "Hamlet";
libroB.Autor = "William Shakespeare";
libroB.CopiasDisponibles = 6;
libroB.NumeroPrestados = 0;


libro libroC = new libro();
libroC.TituloLibro = "El Gaucho Martín Fierro";
libroC.Autor = "Jose Hernández";
libroC.CopiasDisponibles = 9;
libroC.NumeroPrestados = 0;


libro libroD = new libro();
libroD.TituloLibro = "El principito";
libroD.Autor ="Antoine de Saint-Exupéry";
libroD.CopiasDisponibles = 5;
libroD.NumeroPrestados = 0;










