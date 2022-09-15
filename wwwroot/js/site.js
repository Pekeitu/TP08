// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
    function mostrarMasInfo(IdS, nombre) 
    {
        $.ajax (
            {
                type: 'GET',
                dataType: 'JSON',
                url : '/Home/VerSerie?IdSerie=',
                data: {IdSerie : IdS},
                success:
                    function(response)
                    {
                        console.log(response.AñoInicio);
                        let apoyo = `
                            <p>La serie comenzo en ${response.AñoInicio}</p>
                            <p>${response.Sinopsis}</p>
                        `
                        document.getElementById("NombreSerie").innerHTML = "Sinopsis de la serie "+ nombre;
                        document.getElementById("Texto").innerHTML = apoyo;
                        $('#ModalSerie').modal("show");
                    }
            }
        )
    }
        function mostrarTemporada(IdS, nombre) 
    {
        $.ajax (
            {
                type: 'POST',
                dataType: 'JSON',
                url : '/Home/VerTemporadas?IdSerie=',
                data: {IdSerie : IdS},
                success:
                    function(response)
                    {
                        let body = "";
                        response.forEach(element => {
                            body+="<p>"+(element.tituloTemporada)+"</p>";
                        });
                        let apoyo = `
                            <p>${body}</p>
                        `
                        
                        document.getElementById("NombreSerie").innerHTML = "Temporadas de la serie "+ nombre;
                        document.getElementById("Texto").innerHTML = apoyo;
                        $('#ModalSerie').modal("show");
                    }
            }
        )
    }
          function mostrarActores(IdS, nombre ) 
    {
       
        $.ajax (
            {
                type: 'POST',
                dataType: 'JSON',
                url : '/Home/VerActores?IdSerie=',
                data: {IdSerie : IdS},
                success:
                    function(response)
                    {
                        let body ="";
                        
                        response.forEach(element => {
                            body+="<p>"+(element.nombre)+"</p>";
                        });
                        let apoyo = `
                        <p>${body}</p>
                        `
                        console.log(apoyo);
                        document.getElementById("NombreSerie").innerHTML = "Actores de la serie "+ nombre;
                        document.getElementById("Texto").innerHTML = apoyo;
                        $('#ModalSerie').modal("show");
                    }
                
            }
        ).fail(
        function(r){
            console.log(r);
        })
    } 
