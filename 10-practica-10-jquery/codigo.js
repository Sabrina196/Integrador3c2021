$(document).ready(function () {
    
    let bandera = true;
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
        if(bandera){
            $("#caja1Act3").html("<p>Hola, este es un párrafo cualquiera que se agrego en esta caja de HTML.</p>");
            bandera = false;
        }
        else {
            $("#caja1Act3").html("");
            bandera = true;
        }          
    });

    /*Input con valor del botón clickeado y cambio color de fondo*/
	$(".btnS").click(function(){
        if(bandera){
            $(".btnS").css("background", $(this).attr("id"));
            $("input").val($(this).html()); 
            bandera=false;
        }
        else {
            $(".btnS").css("background", "");
            $("input").val(""); 
            bandera= true;
        }   
    });
});


