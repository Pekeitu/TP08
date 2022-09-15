using System;

namespace TP08
{
    public class Serie
    {
        private int _IdSerie;
        private string _Nombre;
        private int _AñoInicio;
        private string _Sinopsis;
        private string _ImagenSerie;
        
        public Serie(int IdSerie, string Nombre, int AñoInicio, string Sinopsis, string ImagenSerie)
        {
            _IdSerie = IdSerie;
            _Nombre = Nombre;
            _AñoInicio = AñoInicio;
            _Sinopsis = Sinopsis;
            _ImagenSerie = ImagenSerie;
        }
         public int IdSerie
        {
            get {return _IdSerie;}
        }
        public string Nombre
        {
            get {return _Nombre;}
        }
        public int AñoInicio
        {
            get {return _AñoInicio;}
        }
        public string Sinopsis
        {
            get {return _Sinopsis;}
        }
        public string ImagenSerie
        {
            get {return _ImagenSerie;}
        }
    }
}