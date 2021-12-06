public class libro {
    public string TituloLibro = ""; 
    public string Autor = "";
    public int NumeroPrestados = 0;
    public int CopiasDisponibles = 0;
  


    ////public libro(string tituloLibro, string autor, short numeroDeCopias, short numeroDePrestamos){

        //TituloLibro = tituloLibro;
        //Autor = autor;
        //NumeroDeCopias = numeroDeCopias;
        //NumeroDePrestamos = numeroDePrestamos;
    //}

    public bool PrestarLibro(){
        bool Prestado;
        if(NumeroPrestados != CopiasDisponibles){
            NumeroPrestados = NumeroPrestados + 1;
            Prestado = true;
        }
        else {
            Prestado = false;
        }
        return Prestado;
    }
    public bool DevolverLibro(){
        bool devolver;
        if( NumeroPrestados == CopiasDisponibles || NumeroPrestados != 0){
            NumeroPrestados = NumeroPrestados - 1;
            devolver = true;
        }
        else {
            devolver = false;
        }
        return devolver;
    }       
    public string MostrarLibroyAutor(){
         
        return $"El nombre del libro es '{TituloLibro}' del autor {Autor}";

    }
    public string MostrarCopiasyPrestados(){

        return $"El N° de copias es'{CopiasDisponibles}' y los que se encuentran prestados son: {NumeroPrestados}";
       
    }

};
