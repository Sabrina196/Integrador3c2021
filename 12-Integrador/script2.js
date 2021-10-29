$(document).ready(function(){
    /*Variables*/
    const enviar = $("#enviarDatos");
    const DivPrincipal = $("#contenedorContacto");
    const Mensaje = $("#mensaje");
    const DivSecundario = $("#contenedorSecundario");
    
    /*Funcion de Validacion*/ 
    $(enviar).click(function(){
        var nombre = $("#nombre").val();
        var apellido = $("#apellido").val();
        var telefono = $("#telefono").val();
        var email = $("#email").val();
        var detalle = $("#detalle").val();
        if(nombre.length < 3){
            $(mensaje).css("background", "#333");
            $(Mensaje).text("El campo Nombre no puede contener menos de 3 caracteres");
        }
        else if (apellido == ""){
            $(mensaje).css("background", "#333");
            $(Mensaje).text("El campo Apellido no puede estar vacio");
        }
        else if (email.length < 10 || 
            email.length >40 || 
            email.indexOf("@") == -1 || 
            email.indexOf(".com") == -1){
            $(mensaje).css("background", "#333");
            $(Mensaje).text("El correo es inválido"); 
            }
        else if (detalle == "" || detalle.length < 10){
            $(mensaje).css("background", "#333");
            $(Mensaje).text("El campo Detalle no puede contener menos de 10 caracteres");
        }
            
        else {
           enviarMensaje();
        }
    });

    /*Función para enviar los datos una vez validado los datos*/    
    const enviarMensaje = ()=> {
        /*Tomo el valor validado de cada Variable*/
        nombre = $("#nombre").val();
        apellido = $("#apellido").val();
        telefono = $("#telefono").val();
        email = $("#email").val();
        detalle = $("#detalle").val();
        /*Oculto el Div principal una vez que se envían*/
        $(DivPrincipal).hide();
        /*Creación de un nuevo Div que muestre todos los datos enviados"*/
        $(DivSecundario).css("display", "block");
        $(DivSecundario).append(`
        <div class="row">
            <div class="m-2 p-3 bg-dark"><strong>"Se ha enviado el mensaje correctamente"</strong></div>
        </div>
        <div class="row">
            <div class="col m-2  p-3 bg-dark"> <strong>Nombre</strong>: ${nombre}</div>
            <div class="col m-2  p-3 bg-dark"> <strong>Apellido</strong>: ${apellido}</div>
        </div>
        <div class="row">
            <div class="col m-2  p-3 bg-dark"> <strong>Teléfono</strong>: ${telefono}</div>
            <div class="col m-2 p-3  bg-dark"> <strong>E-mail</strong>: ${email}</div>
        </div>
        <div class="row">
            <div class="col text-center m-2 p-3  bg-dark"> <strong>Detalle</strong>: ${detalle}</div>
        </div>
        `);
    }

   




});