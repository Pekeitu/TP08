// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
    function MostrarMasInfo(IdS, Nombre) 
    {
        $.ajax (
            {
                type: 'POST',
                dataType: 'JSON',
                url : '/Home/Index',
                data: {IdSerie : IdS},
                success:
                    function(response)
                    {
                        $("#StartYear").html("La serie comenzo en "+ response.añoInicio)
                        $("#Sinopsis").html(response.Sinopsis)
                    }
            }
        )
    }
        function MostrarTemporada(IdS, Nombre) 
    {
        $.ajax (
            {
                type: 'POST',
                dataType: 'JSON',
                url : '/Home/Index',
                data: {IdSerie : IdS},
                success:
                    function(response)
                    {
                        let body = "";
                        response.forEach(element => {
                            body+=response.TituloTemporada;
                        });
                        $("#Temporadas").html("Temporada " + response.numeroTemporada+". "+ body);
                        $("#NombreSerie").html(nombre);
                    }
            }
        )
    }
          function MostrarActores(IdS, Nombre ) 
    {
        $.ajax (
            {
                type: 'POST',
                dataType: 'JSON',
                url : '/Home/Index',
                data: {IdSerie : IdS},
                success:
                    function(response)
                    {
                        let body ="";
                        response.forEach(element => {
                            body+=response.nombre;
                        });
                        $("#Actores").html(body)
                    }
            }
        )
    } 
