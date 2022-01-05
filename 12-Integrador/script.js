$(document).ready(function(){

    const buscar = $("#buscador");
    const tarjetas = $(".tarjetas");
       
    $(buscar).click(function(){
        $(tarjetas).empty();
        let valor = $("#palabra").val();
        let clave_api = "hVWHH8MFSCVtyZzesg6qEjwE5gaDE4FE";
        let urlGif = `https://api.giphy.com/v1/gifs/search?q=${valor}&rating=g&api_key=${clave_api}`;
        $.get(urlGif, (respuesta)=> {    
            
            for (let index = 0; index < respuesta.data.length; index++) {
                const ItemsGif = respuesta.data[index];
                $(tarjetas).append(`<div class="itemTarjeta">
                        <img id="imagen" src="https://i.giphy.com/media/${ItemsGif.id}/giphy.webp" alt="${ItemsGif.title}">
                        <div class="mt-1 bg-dark" id="descripcion">
                            <h6 class="card-title"> Título: ${ItemsGif.title}</h6>
                        </div>
                </div>`);

            }

        })
        
    }); 

    


});






