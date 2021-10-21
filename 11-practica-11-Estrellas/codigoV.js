$(document).ready(function () {
    /*Elementos que se encuentran dentro del div votacion con clase Estrella*/
    let item =  $('.votacion').find('.estrellas');


    /*Funcion que captura el numero de luces a partir de los eventos del mouse, 
    para iluminar las posiciones de las estrellas correspondientes, iterando cada elemento(span)*/
    var iluminar = function(numDeLuces) {
        $(item).each(function(index) {
            if (index < numDeLuces){
                $(this).css("color", "#ffcd56");
            } 
            else {
                $ (this).css('color', 'white');
            }
        });
    };

    /*Eventos de todos los item, se suma posicion para igualar con el numero de luces (ya que las posiciones arrancan de cero)*/
    $(item).on({
        mouseenter: function() {
            iluminar($(this).index() + 1);
        },
        mouseleave: function() {
            iluminar($(this).index() + 1);
 
        },
        click: function(){
            iluminar($(this).index()+ 1);
            numDeLuces = $(this).index();
            let puntuacion = $(this).attr('value');
            $(".calificacion").text(puntuacion);
        }
    });

    
});

 
    
 



   