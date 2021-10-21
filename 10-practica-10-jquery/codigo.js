$(document).ready(function () {
    
    let bandera = true;
    let bandera2 = true;
    let bander3 = true;
    /*Cambiar color de fondo de otro Elemento*/
    $("#colorF").on("click", function(){
        if(bandera){
            $("#caja1Act1").css("background", "#b80036");
            bandera = false;
        }
        else {
            $("#caja1Act1").css("background", "");
            bandera = true;
        }        
    });

    /*Mostrar-Ocultar Elemento*/
    $("#btnM").on("click", function(){
        $("#btnM").text(($("#caja1Act2").is(":visible") ? "Mostrar" : "Ocultar"));
        $("#caja1Act2").toggle();        
    });

    /*Agregar un elemento HTML*/
    $("#agregar").on("click", function(){
        if(bandera2){
            $("#caja1Act3").html("<p>Hola, este es un párrafo cualquiera que se agrego en esta caja de HTML.</p>");
            bandera2 = false;
        }
        else {
            $("#caja1Act3").html("");
            bandera2 = true;
        }          
    });

    /*Input con valor del botón clickeado y cambio color de fondo*/
    let BotonAnterior = "";

	$(".btnS").click(function(){
        if(bandera3){
            $(".btnS").css("background", $(this).attr("id"));
            $("input").val($(this).html());
            BotonAnterior = $(this).html(); 
            bandera3=false;
        }
        else {
            if ($(this).html() == BotonAnterior){
                $(".btnS").css("background", "");
                $("input").val(""); 
                bandera3 = true;
            }
            else {
                $(".btnS").css("background", $(this).attr("id"));
                $("input").val($(this).html());
                BotonAnterior = $(this).html();
            } 
        }    
    }); 
});
